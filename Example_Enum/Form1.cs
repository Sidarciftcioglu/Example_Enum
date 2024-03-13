using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum cities { X, Mardin, İstanbul, Diyarbakır, İzmir };
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt16(textBox1.Text);
            cities c;
            c=(cities)plaka;
            label1.Text = c.ToString();
        }
    }
}
