using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nasiib1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nasibbtn_Click(object sender, EventArgs e)
        {
            Class1 myclass= new Class1();
            myclass.ex();
            lbitem.Items.Add("coin kagu waa :" + " " + myclass.getex());
        }
    }
}
