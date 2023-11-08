using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Xml.Schema;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double crispprice = 2.00;
        double chocprice = 1.25;
        double drinkprice = 1.75;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            if (s.Length > 3)
            {
                s = s.Substring(0, s.Length - 1);
            }


            textBox1.Text = s;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void button12_Click(object sender, EventArgs e)
        {
            double crispprice = 2.00;
            double chocprice = 1.25;
            double drinkprice = 1.75;

            if (textBox1.Text[0] == '1' || textBox1.Text[0] == '2')
            {
                double total = crispprice;
                textBox2.Text = ("balance due:" + total);
            }
            while (textBox1.Text[0] == '3' || textBox1.Text[0] == '4')
            {
                double total = chocprice;
                textBox2.Text += ("balance due: " + total);
            }
            if (textBox1.Text[0] == '5')
            {
                double total = drinkprice;
                textBox2.Text = ("balance due: " + total);
            }

        }


        private void button17_Click(object sender, EventArgs e)
        {



            if (textBox1.Text[0] == '1' || textBox1.Text[0] == '2')
            {

                textBox2.Text = ("balance due: " + Math.Round((crispprice - 0.05), 2));
                crispprice = crispprice - 0.05;
                crispprice = Math.Round(crispprice, 2);
                if (crispprice < 0)
                {
                    double change = 0 - crispprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '3' || textBox1.Text[0] == '4')
            {

                textBox2.Text += ("balance due: " + Math.Round((chocprice - 0.05), 2));
                chocprice = chocprice - 0.05;
                if (chocprice < 0)
                {
                    double change = 0 - chocprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '5')
            {
                textBox2.Text = ("balance due: " + Math.Round((drinkprice - 0.05), 2));
                drinkprice = drinkprice - 0.05;
                drinkprice = Math.Round(drinkprice, 2);
                if (drinkprice < 0)
                {
                    double change = 0 - drinkprice;
                    textBox2.Text = ("change: £" + change);
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {



            if (textBox1.Text[0] == '1' || textBox1.Text[0] == '2')
            {

                textBox2.Text = ("balance due: " + Math.Round((crispprice - 2), 2));
                crispprice = crispprice - 2;
                crispprice = Math.Round(crispprice, 2);
                if (crispprice < 0)
                {
                    double change = 0 - crispprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '3' || textBox1.Text[0] == '4')
            {

                textBox2.Text += ("balance due: " + Math.Round((chocprice - 2), 2));
                chocprice = chocprice - 2;
                if (chocprice < 0)
                {
                    double change = 0 - chocprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '5')
            {
                textBox2.Text = ("balance due: " + Math.Round((drinkprice - 2), 2));
                drinkprice = drinkprice - 2;
                drinkprice = Math.Round(drinkprice, 2);
                if (drinkprice < 0)
                {
                    double change = 0 - drinkprice;
                    textBox2.Text = ("change: £" + change);
                }
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {



            if (textBox1.Text[0] == '1' || textBox1.Text[0] == '2')
            {

                textBox2.Text = ("balance due: " + Math.Round((crispprice - 1), 2));
                crispprice = crispprice - 1;
                crispprice = Math.Round(crispprice, 2);
                if (crispprice < 0)
                {
                    double change = 0 - crispprice;
                    textBox2.Text = ("change: £" + change);
                }

            }
            if (textBox1.Text[0] == '3' || textBox1.Text[0] == '4')
            {
                textBox2.Text += ("balance due: " + Math.Round((chocprice - 1), 2));
                chocprice = chocprice - 1;
                if (chocprice < 0)
                {
                    double change = 0 - chocprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '5')
            {
                textBox2.Text = ("balance due: " + Math.Round((drinkprice - 1), 2));
                drinkprice = drinkprice - 1;
                drinkprice = Math.Round(drinkprice, 2);
                if (drinkprice < 0)
                {
                    double change = 0 - drinkprice;
                    textBox2.Text = ("change: £" + change);
                }
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '1' || textBox1.Text[0] == '2')
            {
                textBox2.Text = ("balance due: " + Math.Round((crispprice - 0.5), 2));
                crispprice = crispprice - 0.5;
                crispprice = Math.Round(crispprice, 2);
                if (crispprice < 0)
                {
                    double change = 0 - crispprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '3' || textBox1.Text[0] == '4')
            {

                textBox2.Text += ("balance due: " + Math.Round((chocprice - 0.5), 2));
                chocprice = chocprice - 0.5;
                if (chocprice < 0)
                {
                    double change = 0 - chocprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '5')
            {
                textBox2.Text = ("balance due: " + Math.Round((drinkprice - 0.5), 2));
                drinkprice = drinkprice - 0.5;
                drinkprice = Math.Round(drinkprice, 2);
                if (drinkprice < 0)
                {
                    double change = 0 - drinkprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '1' || textBox1.Text[0] == '2')
            {

                textBox2.Text = ("balance due: " + Math.Round((crispprice - 0.2), 2));
                crispprice = crispprice - 0.2;
                crispprice = Math.Round(crispprice, 2);
                if (crispprice < 0)
                {
                    double change = 0 - crispprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '3' || textBox1.Text[0] == '4')
            {
                textBox2.Text += ("balance due: " + Math.Round((chocprice - 0.2), 2));
                chocprice = chocprice - 0.2;
                if (chocprice < 0)
                {
                    double change = 0 - chocprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '5')
            {
                textBox2.Text = ("balance due: " + Math.Round((drinkprice - 0.2), 2));
                drinkprice = drinkprice - 0.2;
                drinkprice = Math.Round(drinkprice, 2);
                if (drinkprice < 0)
                {
                    double change = 0 - drinkprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '1' || textBox1.Text[0] == '2')
            {

                textBox2.Text = ("balance due: " + Math.Round((crispprice - 0.1), 2));
                crispprice = crispprice - 0.1;
                crispprice = Math.Round(crispprice, 2);
                if (crispprice < 0)
                {
                    double change = 0 - crispprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '3' || textBox1.Text[0] == '4')
            {

                textBox2.Text += ("balance due: " + Math.Round((chocprice - 0.1), 2));
                chocprice = chocprice - 0.1;
                if (chocprice < 0)
                {
                    double change = 0 - chocprice;
                    textBox2.Text = ("change: £" + change);
                }
            }
            if (textBox1.Text[0] == '5')
            {
                textBox2.Text = ("balance due: " + Math.Round((drinkprice - 0.1), 2));
                drinkprice = drinkprice - 0.1;
                drinkprice = Math.Round(drinkprice, 2);
                if (drinkprice < 0)
                {
                    double change = 0 - drinkprice;
                    textBox2.Text = ("change: £" + change);
                }
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox2.Text[14] == '0' || textBox2.Text[0] == 'c')
            {
                textBox2.Text = "enjoy!!!";
            }
        }
    }
}