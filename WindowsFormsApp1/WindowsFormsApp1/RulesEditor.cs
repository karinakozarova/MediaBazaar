using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class RulesEditor : Form
    {
        Rules rule;
        private int CreatedBy;
        public RulesEditor(int user_id)
        {
            InitializeComponent();
            this.CreatedBy = user_id;
            UpdateForm();
        }
        private void UpdateForm()
        {
            rulesLv.Items.Clear();
            tbDeleteId.Clear();
            tbDescription.Clear();
            foreach (Rules r in Rules.GetAllRules())
            {
                ListViewItem item = new ListViewItem(new[] { r.id.ToString(), r.description });
                rulesLv.Items.Add(item);
            }
        }

        private void AddRulebtn_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text == "")
            {
                MessageBox.Show("Description is empty");
            }
            else
            {
                Rules newRule = new Rules(tbDescription.Text, CreatedBy);
                UpdateForm();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tbDeleteId.Text == "")
            {
                MessageBox.Show("Fill in the ID");
            }
            else
            {
                int RuleRemoveid = Convert.ToInt32(tbDeleteId.Text);
                int counter = 0;
                foreach (Rules r in Rules.GetAllRules())
                {
                    if (r.id == RuleRemoveid)
                    {
                        counter = 1;
                    }
                }
                if (counter == 0)
                {
                    MessageBox.Show("Id does not exist");
                }
                else
                {
                    Rules.RemoveRule(RuleRemoveid);
                    UpdateForm();
                }



            }
        }
    }
}
