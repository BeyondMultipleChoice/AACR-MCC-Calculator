using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Interface where user enters number of true positives, true negatives, false positives, and false negatives 
//to calculate the Matthews Correlation Coefficient.  
//Programmer: Marisol Mercado Santiago (marisolvsh@gmail.com)
//Automated Analysis of Constructed Response Research Group

//Acknowledgements: 
//This material is based upon work supported by the National Science Foundation(Grants 1323162 and 1347740). 
//Any opinions, findings and conclusions or recommendations expressed in this material are those of the author(s) and do not necessarily reflect the views of the supporting agencies.


namespace MCC_Calculator_GUI
{
    public partial class Form1 : Form
    {
        //these properties will save the integers entered by the user in this order: true positives, true negatives, false positives, false negatives
        double tp, tn, fp, fn;

        //Clear all textboxes button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        //Calculate MCC button
        private void button1_Click(object sender, EventArgs e)
        {
            int retTemp = SaveTextBoxContent();

            if (retTemp == 0) //If the program did not find any input errors in the textboxes, then calculate MCC
            {
                CalculateMCC myMCC = new CalculateMCC(tp, tn, fp, fn);
                double result = myMCC.GetMCCResult();
                textBox5.Text = result.ToString();
            }
          
        }

        //Saving the contents of the tp, fp, tp, and tn textboxes, checking for input errors.
        private int SaveTextBoxContent()
        {
            try
            {
                 tp = Convert.ToDouble(textBox1.Text);
                 tn = Convert.ToDouble(textBox2.Text);
                 fp = Convert.ToDouble(textBox3.Text);
                 fn = Convert.ToDouble(textBox4.Text);
            }
           
            catch(FormatException e)
            {
                MessageBox.Show("Please make sure that you only enter integers in the textboxes.");
                return 1;
            }
            return 0;

        }
    }
}
