using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASHMD5TEST
{
    public partial class Form3 : Form
    {
        Form2 kaya2;
        public event EventHandler<string> fethullah;

        public Form3()
        {
            InitializeComponent();
            kaya2 = new Form2();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fethullah?.Invoke(this, "ASDASD");

        }

         
    }
}
