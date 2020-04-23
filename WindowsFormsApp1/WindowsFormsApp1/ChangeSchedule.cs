using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace MediaBazar
{
    public partial class ChangeSchedule : Form
    {
        private const string Status = "unread";
        private int userId;
        List<int> workdays;
        List<int> workshifts;
        public ChangeSchedule(int id)
        {
            InitializeComponent();
            PopulateEmployees(Employee.GetAllEmployees());
            workdays = new List<int>();
            workshifts = new List<int>();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.userId = id;
            gbShifts.Enabled = false;
            gbWorkDays.Enabled = false;
        }

        private void PopulateEmployees(List<Employee> employees)
        {
            cbEmployee.Items.Clear();
            foreach (Employee e in employees)
            {
                cbEmployee.Items.Add(new EmployeeComboBoxItem(e));
            }
        }

        private void PopulateSchedule(List<int> workingDays, List<string> workingShifts)
        {
            cbAfternoonShift.Checked = false;
            cbEveningShift.Checked = false;
            cbMorningShift.Checked = false;
            cbMonday.Checked = false;
            cbTuesday.Checked = false;
            cbWednesday.Checked = false;
            cbThursday.Checked = false;
            cbFriday.Checked = false;
            cbSaturday.Checked = false;
            cbSunday.Checked = false;

            foreach(int day in workingDays)
            {
                if(day == 0)
                {
                    cbMonday.Checked = true;
                }
                if (day == 1)
                {
                    cbTuesday.Checked = true;
                }
                if (day == 2)
                {
                    cbWednesday.Checked = true;
                }
                if (day == 3)
                {
                    cbThursday.Checked = true;
                }
                if (day == 4)
                {
                    cbFriday.Checked = true;
                }
                if (day == 5)
                {
                    cbSaturday.Checked = true;
                }
                if (day == 6)
                {
                    cbSunday.Checked = true;
                }
            }
            foreach(string shift in workingShifts)
            {
                if(shift == "morning")
                {
                    cbMorningShift.Checked = true;
                }
                if (shift == "afternoon")
                {
                    cbAfternoonShift.Checked = true;
                }
                if (shift == "evening")
                {
                    cbEveningShift.Checked = true;
                }
            }
        }

        private void CbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbShifts.Enabled = true;
            gbWorkDays.Enabled = true;
            int employeeId = ((EmployeeComboBoxItem)cbEmployee.SelectedItem).Id;
            List<int> workDays = Employee.GetEmployeeWorkingDays(employeeId);
            List<string> workShifts = Employee.GetEmployeeWorkingShifts(employeeId);
            PopulateSchedule(workDays, workShifts);
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            string message = rtbMessage.Text;
            if (cbEmployee.Text == "Employee" || cbEmployee.Text == "")
            {
                MessageBox.Show("Please select an employee!");
            }else if (rtbMessage.Text == "Message" || rtbMessage.Text == "")
            {
                MessageBox.Show("Please write a message to the employee!");
            }
            else
            {
                if (MessageBox.Show("Do you really want to change this schedule?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cbMonday.Checked)
                    {
                        this.workdays.Add(0);
                    }
                    if (cbTuesday.Checked)
                    {
                        this.workdays.Add(1);
                    }
                    if (cbWednesday.Checked)
                    {
                        this.workdays.Add(2);
                    }
                    if (cbThursday.Checked)
                    {
                        this.workdays.Add(3);
                    }
                    if (cbFriday.Checked)
                    {
                        this.workdays.Add(4);
                    }
                    if (cbSaturday.Checked)
                    {
                        this.workdays.Add(5);
                    }
                    if (cbSunday.Checked)
                    {
                        this.workdays.Add(6);
                    }
                    if (cbMorningShift.Checked)
                    {
                        this.workshifts.Add(1);
                    }
                    if (cbAfternoonShift.Checked)
                    {
                        this.workshifts.Add(2);
                    }
                    if (cbEveningShift.Checked)
                    {
                        this.workshifts.Add(3);
                    }
                    int employeeId = ((EmployeeComboBoxItem)cbEmployee.SelectedItem).Id;
                    Employee.ChangeEmployeeShift(employeeId, this.workdays, this.workshifts);
                    DateTime today = DateTime.Now;
                    string employeeEmail = "";
                    
                    MySqlConnection conn = Utils.GetConnection();
                    try
                    {
                        string sendNotification = "INSERT INTO notifications (employee_id, created_by_id, message, datetime, status) VALUE(@employee_id, @user_id, @message, @datetime, @status)";
                        MySqlCommand notificationQuery = new MySqlCommand(sendNotification, conn);
                        conn.Open();
                        notificationQuery.Parameters.AddWithValue("@employee_id", employeeId);
                        notificationQuery.Parameters.AddWithValue("@user_id", this.userId);
                        notificationQuery.Parameters.AddWithValue("@message", message);
                        notificationQuery.Parameters.AddWithValue("@datetime", today);
                        notificationQuery.Parameters.AddWithValue("@status", Status);
                        notificationQuery.ExecuteNonQuery();

                        string getEmployeeEmail = "SELECT email FROM person WHERE id=@employee_id";
                        MySqlCommand getEmployeeEmailQuery = new MySqlCommand(getEmployeeEmail, conn);
                        getEmployeeEmailQuery.Parameters.AddWithValue("@employee_id", employeeId);
                        Object emailResult = getEmployeeEmailQuery.ExecuteScalar();

                        if (emailResult != null)
                        {
                            employeeEmail = emailResult.ToString();
                        }
                        try
                        {
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                            mail.From = new MailAddress("mediabazaartest@gmail.com");
                            mail.To.Add(employeeEmail);
                            mail.Subject = "New notification!";
                            mail.Body = "Hey you have a new notification on the website! Go and check it out: <link here>.";

                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("MediaBazaarTest@gmail.com", "MediaBazaar!Test123");
                            SmtpServer.EnableSsl = true;

                            SmtpServer.Send(mail);
                            MessageBox.Show("Mail sent!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    catch(Exception)
                    {
                        // TODO: add it to error log in the future
                    }
                    finally
                    {
                        conn.Close();
                    }

                    rtbMessage.Text = "";
                    cbEmployee.Text = "Employee";
                    cbAfternoonShift.Checked = false;
                    cbEveningShift.Checked = false;
                    cbMorningShift.Checked = false;
                    cbMonday.Checked = false;
                    cbThursday.Checked = false;
                    cbTuesday.Checked = false;
                    cbSaturday.Checked = false;
                    cbSunday.Checked = false;
                    cbWednesday.Checked = false;
                    cbFriday.Checked = false;
                    gbShifts.Enabled = false;
                    gbWorkDays.Enabled = false;
                }
            }
            
        }

        private void RtbMessage_Enter(object sender, EventArgs e)
        {
            if(rtbMessage.Text == "Message")
            {
                rtbMessage.Text = "";
            }
        }

        private void RtbMessage_Leave(object sender, EventArgs e)
        {
            if(rtbMessage.Text == "")
            {
                rtbMessage.Text = "Message";
            }
        }
    }
}
