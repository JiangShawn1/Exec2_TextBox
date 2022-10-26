using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {           

            try
            {
                DateTime date = GetDate(dateTextBox);

                if (date > DateTime.Today)
                {
                    answerLabel.Text = "大於今天";
                }
                else
                {
                    answerLabel.Text = "不大於今天";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DateTime GetDate(TextBox input)
        {
            string value = input.Text;
            bool isDate = DateTime.TryParse(value, out DateTime date);
            return isDate ? date : throw new Exception("必須輸入正確日期&格式");                
        }
    }
}
