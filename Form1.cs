using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        // global Variable
        public static double E=0;
        public static double MounthlyIncome=0;
        public static double Accomadation=0;
        public static double Vechile=0;
        // method to check if entry are numbers
        public static bool IsOnlyDigits(string inputString)
        {
            bool isValid = true;

            foreach (char c in inputString)
            {
                if (!Char.IsDigit(c))
                    isValid = false;
            }
            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variables
            double Purchurseprice =0;
            double Totaldeposit = 0;
            double IntrestRate = 0;
            int numberofmonths = 0;
            double rentalamount = 0;
            string Accomendation = " ";


            
            if (IsOnlyDigits(textBox1.Text)==false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            double GMI = Convert.ToDouble(textBox1.Text);
            if (IsOnlyDigits(textBox2.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            double EMT = Convert.ToDouble(textBox2.Text);
            MounthlyIncome = GMI;

            if (IsOnlyDigits(textBox3.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            double Egroceries = Convert.ToDouble(textBox3.Text);
            if (IsOnlyDigits(textBox4.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            double Ewaterandlights = Convert.ToDouble(textBox4.Text);
            if (IsOnlyDigits(textBox5.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            double Etravelcosts = Convert.ToDouble(textBox5.Text);
            if (IsOnlyDigits(textBox6.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            double Ecellphone = Convert.ToDouble(textBox6.Text);
            if (IsOnlyDigits(textBox7.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            double Eotherexpenses = Convert.ToDouble(textBox7.Text);

            




            if (comboBox1.SelectedIndex == 0)
            {
                Accomendation = "Renting Accommodation";
                if (IsOnlyDigits(textBox8.Text) == false)
                {
                    MessageBox.Show(" Please Enter Valid amount in Input");
                }
                rentalamount = Convert.ToDouble(textBox8.Text);
                ExpensesClass expensesClass = new ExpensesClass(GMI,EMT,Egroceries,Ewaterandlights,Etravelcosts,Ecellphone,Eotherexpenses,Accomendation,rentalamount);
                richTextBox1.Text = expensesClass.ToDisplay();
                E = expensesClass.MoneyAvailable();
                

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Accomendation = "Buying A Property";
                if (IsOnlyDigits(textBox9.Text) == false)
                {
                    MessageBox.Show(" Please Enter Valid amount in Input");
                }
                Purchurseprice = Convert.ToDouble(textBox9.Text);
                if (IsOnlyDigits(textBox10.Text) == false)
                {
                    MessageBox.Show(" Please Enter Valid amount in Input");
                }
                Totaldeposit = Convert.ToDouble(textBox10.Text);
                IntrestRate = Convert.ToDouble(numericUpDown1.Value / 100);
                numberofmonths = Convert.ToInt32(numericUpDown2.Value);
                HomeLoanClass homeLoanClass = new HomeLoanClass(Purchurseprice, Totaldeposit, IntrestRate, numberofmonths, GMI, EMT, Egroceries, Ewaterandlights, Etravelcosts, Ecellphone, Eotherexpenses, Accomendation, rentalamount);
                richTextBox1.Text= homeLoanClass.ToDisplay();
                E = homeLoanClass.MoneyAvailable();
                Accomadation =homeLoanClass.MonthlyHomeLoanRepayment();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                panel5.Enabled = false;
                panel4.Enabled = true;
               
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                panel4.Enabled = false;
                panel5.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            richTextBox1.Clear();
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                
                panel8.Enabled = true;
            }
            else if (radioButton2.Checked)
            {
                
                panel8.Enabled = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            

            // variables
            string ModelandMake;
            double PurchasePrice; double TotalDeposit; double VIntrestRate; double InsurancePremium; int numMonths;
            double Totale;

            if (IsOnlyDigits(textBox11.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            PurchasePrice = double.Parse(textBox11.Text);
            if (IsOnlyDigits(textBox12.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            ModelandMake = textBox13.Text;
            if (IsOnlyDigits(textBox1.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            TotalDeposit = double.Parse(textBox13.Text);
            if (IsOnlyDigits(textBox14.Text) == false)
            {
                MessageBox.Show(" Please Enter Valid amount in Input");
            }
            InsurancePremium = double.Parse(textBox14.Text);
            VIntrestRate = Convert.ToDouble(numericUpDown5.Value / 100);
            numMonths = Convert.ToInt32(numericUpDown3.Value);

            VehiclePurchaseClass vehiclePurchaseClass = new VehiclePurchaseClass(PurchasePrice,TotalDeposit,VIntrestRate,InsurancePremium,ModelandMake,numMonths);
            richTextBox2.Text = vehiclePurchaseClass.ToDisplay() + Environment.NewLine;
            E= E + vehiclePurchaseClass.CalculateTotalMonthlyCost();
            if (E> (MounthlyIncome/0.75))
            {
                MessageBox.Show(" Please Note Your total expenses exceed 75% of your income");
            }
            Vechile= vehiclePurchaseClass.MonthlyVehiclePurchaseRepayment();
            int n = 7;
            String[] Expenses = { "Groceries", "Water and lights","Travel costs", "Cell phone and telephone", "Other expenses","Accomadation", "Vechile" };
            double[] ExpensesAmount = { Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text),
                                        Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text),
                                        Convert.ToDouble(textBox7.Text),Accomadation,Vechile};

            foreach (string s in Expenses)
            {
                richTextBox2.Text += (Expenses, ExpensesAmount, n) + Environment.NewLine;
            }
            //richTextBox2.Text = printParallelArray(Expenses, ExpensesAmount, n);

        }

        


        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series["Income"].Points.AddXY("2022", MounthlyIncome.ToString("C"));
            chart1.Series["Income"].Points.AddXY("2023", (MounthlyIncome*24).ToString("C"));
            chart1.Series["Income"].Points.AddXY("2024", (MounthlyIncome*36).ToString("C"));
            chart1.Series["Income"].Points.AddXY("2025", (MounthlyIncome *48).ToString("C"));
            chart1.Series["Income"].Points.AddXY("2026", (MounthlyIncome * 60)).ToString("C");
            //chart title  
            chart1.Titles.Add("Salary Chart");
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel9.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel7.Visible = true;
            panel6.Visible = true;
            panel9.Visible = false;
        }
    }
}

