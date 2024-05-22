using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceCalculator
{
    public partial class Form1 : Form
    {
       private static int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ONLY FOR POSITIVE INTEGER!!!!!!!
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        public void buttons_Clicked(object sender,EventArgs e)
        {
            Button btns = (Button)sender;
            if(lblFirst.Text=="lblnumber" && count==0)
            {
                txtshow.Text = btns.Text;
                count++;
                return;
            }
            if (txtshow.Text.Contains(".") && btns.Text == ".")
            {
                MessageBox.Show("ALready DOT contain");
                return;
            }
            if ( txtshow.Text=="0" && btns.Text!=".")
            {
                txtshow.Text = "";
                txtshow.Text = btns.Text;
            }
            else if(txtshow.Text=="0" && btns.Text==".")
            {
                txtshow.Text += btns.Text;
            }
            else
            {
                txtshow.Text += btns.Text;
            }          
            
        }
        private void buttonsapp_Clicked(object sender,EventArgs e)
        {
            Button btnop = (Button)sender;
            lbloperator.Text = btnop.Text;
            if (lblFirst.Text== "lblnumber")
            {
               lblFirst.Text = txtshow.Text;
               txtshow.Text = "0";
            }
            if(lblFirst.Text=="0" && txtshow.Text=="0")
            {
                MessageBox.Show("Please Enter number");
                return;
            }
           
            if(lblFirst.Text=="0" && txtshow.Text!="0")
            {
                lblFirst.Text = txtshow.Text;
                txtshow.Text = "0";
            }
              double x =Double.Parse(lblFirst.Text);
            if((btnop.Text=="*" || btnop.Text=="/" || btnop.Text== "√") && txtshow.Text=="0")
            {
                //MessageBox.Show("PLEASE ENTER NUMBER");
                return;
                //txtshow.Text = "1";
            }
            else if(btnop.Text=="%" && txtshow.Text=="0")
            {
                return;
            }
                double y = Double.Parse(txtshow.Text);
                if(lbloperator.Text=="+")
                {
                    double sum = x + y;
                    lblFirst.Text = sum.ToString();
                    txtshow.Text = "0";
                }
                else if(lbloperator.Text=="-")
                {
                    double sub = x - y;
                    lblFirst.Text = sub.ToString();
                    txtshow.Text = "0";
                    

                }
                else if (lbloperator.Text == "*")
                {
                    
                    double multi = x * y;
                    lblFirst.Text = multi.ToString();
                    txtshow.Text = "0";


                }
                else if (lbloperator.Text== "/")
                {
                    double div = x / y;
                    lblFirst.Text = div.ToString();
                    txtshow.Text = "";


                }
                else if (lbloperator.Text == "%")
                {
                    double mod = x % y;
                    lblFirst.Text = mod.ToString();
                    txtshow.Text = "0";


                }
            
            
        }
        private void buttonequal_Clicked(object sender ,EventArgs e)
        {
            if(txtshow.Text=="0")
            {
                MessageBox.Show(lblFirst.Text);
            }
            else
            {
                try
                {
                    double x = double.Parse(lblFirst.Text);
                    double y = double.Parse(txtshow.Text);
                    if (lbloperator.Text == "+")
                    {
                        double sum = x + y;
                        lblFirst.Text = sum.ToString();
                        txtshow.Text = "";
                        lbloperator.Text = "";

                        MessageBox.Show(lblFirst.Text);
                        lblFirst.Text = "lblnumber";
                    }
                    else if (lbloperator.Text == "-")
                    {
                        double sub = x - y;
                        lblFirst.Text = sub.ToString();
                        txtshow.Text = "0";
                        lbloperator.Text = "";

                        MessageBox.Show(lblFirst.Text);
                        lblFirst.Text = "lblnumber";

                    }
                    else if (lbloperator.Text == "*")
                    {
                        double multi = x * y;
                        lblFirst.Text = multi.ToString();
                        txtshow.Text = "0";
                        lbloperator.Text = "";

                        MessageBox.Show(lblFirst.Text);
                        lblFirst.Text = "lblnumber";

                    }
                    else if (lbloperator.Text == "/")
                    {
                        double div = x / y;
                        lblFirst.Text = div.ToString();
                        txtshow.Text = "0";
                        lbloperator.Text = "";

                        MessageBox.Show(lblFirst.Text);

                        lblFirst.Text = "lblnumber";
                    }
                    else if (lbloperator.Text == "%")
                    {
                        double mod = x % y;
                        lblFirst.Text = mod.ToString();
                        txtshow.Text = "0";
                        lbloperator.Text = "";

                        MessageBox.Show(lblFirst.Text);
                        lblFirst.Text = "lblnumber";

                    }

                }
                catch
                {
                    MessageBox.Show("INVALID OPERATION");
                }
                

            }
        }

        private void txtshow_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if(txtshow.Text=="0")
            {
                return;
            }
            string s = txtshow.Text;
            
            txtshow.Text = s.Substring(0,s.Length-1 );
        }

        private void rootButton_Click(object sender,EventArgs e)
        {
            if (txtshow.Text == "0")
            {
                MessageBox.Show("YOU DID NOT ENTER ANY NUMBER");
            }
            else
            {
                double r = Math.Sqrt(double.Parse(txtshow.Text));
                lblFirst.Text = r.ToString();
                txtshow.Text = "0";
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtshow.Text = "0";
            lblFirst.Text = "lblnumber";
            lbloperator.Text= "lblop";
            count = 0;
        }
    }
}
