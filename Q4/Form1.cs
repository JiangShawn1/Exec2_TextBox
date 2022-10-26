using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                int carNum = GetCarNum(carTextBox);
                int peoNum = GetPeoNum(peopleTextBox1);
                int carMon = carNum * 200;
                int peoMon = peoNum * 60;

                answerTextBox.Text = $"人:{peoMon}$ 車:{carMon}$ 共:{peoMon + carMon}$";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetPeoNum(TextBox input)
        {
            string value=input.Text;
            bool isInt = int.TryParse(value, out int peoNum);
            return isInt ? peoNum : throw new Exception("請檢查輸入數值，若為零請輸入0");
        }

        private int GetCarNum(TextBox input)
        {
            string value=input.Text;
            bool isInt = int.TryParse(value, out int carNum);
            return isInt ? carNum : throw new Exception("請檢查輸入數值，若為零請輸入0");                
                        
        }
    }
}
