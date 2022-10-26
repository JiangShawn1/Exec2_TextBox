using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
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
                if (DateTime.Today.Year-date.Year >= 13)
                {
                    answerLabel.Text = "已滿13歲";
                }
                else
                {
                    answerLabel.Text = "未滿13歲";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private DateTime GetDate(TextBox input)
        {
            string value=input.Text;
            bool isDate=DateTime.TryParse(value,out DateTime date);
            date = isDate ? date : throw new Exception("必須輸入正確日期&格式");
            bool beforeDate = date < DateTime.Today;
            return beforeDate ? date : throw new Exception("生日不可大於今天");
        }
    }
}
