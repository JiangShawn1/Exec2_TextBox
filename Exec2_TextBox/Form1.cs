using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            
            //string input=numTextBox.Text;
            //bool isInt = int.TryParse(input, out int number);
            //number = isInt ? number : throw new Exception("必須輸入整數值");

            try
            {
                int number = GetNumber(numTextBox);

                if (number > 0 && number < 100)
                {
                    ansLabel.Text = "是";
                }
                else
                {
                    ansLabel.Text = "否";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           

        }

        private int GetNumber(TextBox input)
        {        
            string value = input.Text;
            bool isInt = int.TryParse(value, out int number);
            return isInt ? number : throw new Exception("必須輸入整數值");         
        }
    }
}
