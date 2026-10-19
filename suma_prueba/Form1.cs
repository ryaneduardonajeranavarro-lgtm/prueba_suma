using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2;
            bool esNum1 = double.TryParse(textBox1.Text, out n1);
            bool esNum2 = double.TryParse(textBox2.Text, out n2);
            if(esNum1 && esNum2)
            {
                label1.Text = (n1 + n2).ToString();
            }
            else
            {
                label1.Text = "error";
            }
        }
    }
}
