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
        private int createdBy;

        public RulesEditor(int userId)
        {
            InitializeComponent();
            this.createdBy = userId;
            UpdateForm();
        }

        private void UpdateForm()
        {
            lbRuleList.Items.Clear();
            tbDescription.Clear();
            foreach (Rules rule in Rules.GetAllRules())
            {
                lbRuleList.Items.Add(rule.id.ToString() + "  -  " + rule.description);
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
                Rules newRule = new Rules(tbDescription.Text, createdBy);
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
                if (MessageBox.Show("Do you really want to delete this rule?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ruleText = lbRuleList.SelectedItem.ToString();
                    string ruleId = ruleText.Substring(0, ruleText.IndexOf("-"));
                    Rules.RemoveRule(Convert.ToInt32(ruleId));
                    UpdateForm();
                }
            }
        }
    }
}
