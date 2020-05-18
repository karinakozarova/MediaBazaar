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
            lbRuleList.Items.Clear();
            tbDescription.Clear();
            foreach (Rules r in Rules.GetAllRules())
            {
                lbRuleList.Items.Add(r.id.ToString() + "  -  " + r.description);
            }
        }

        private void AddRulebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
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
            if (lbRuleList.SelectedIndex == -1)
            {
                MessageBox.Show("Select a rule");
            }
            else
            {
                string ruleText = lbRuleList.SelectedItem.ToString();
                string idSubstring = ruleText.Substring(0, ruleText.IndexOf("-"));
                if (MessageBox.Show("Do you really want to delete this rule?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Rules.RemoveRule(Convert.ToInt32(idSubstring));
                    UpdateForm();
                }
            }
        }
    }
}
