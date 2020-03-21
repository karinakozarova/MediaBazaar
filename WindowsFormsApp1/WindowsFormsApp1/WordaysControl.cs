using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WordaysControl : UserControl
    {
        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public WordaysControl(int[] numbers, String daytime)
        {
            InitializeComponent();
            timeOfTheDayData.Text = UppercaseFirst(daytime);
            mondayData.Text = numbers[0].ToString();
            tuesData.Text = numbers[1].ToString();
            wedData.Text = numbers[2].ToString();
            thurData.Text = numbers[3].ToString();
            fridayData.Text = numbers[4].ToString();
            satData.Text = numbers[5].ToString();
            sunData.Text = numbers[6].ToString();
            totalData.Text = numbers[7].ToString();
        }
    }
}
