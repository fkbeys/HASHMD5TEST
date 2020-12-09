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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var ilk = textBox1.Text.ToString().Replace(",", ".");
          //  var ilk = textBox1.Text.ToString();
            var plusum = float.Parse(ilk);
            
            plusum++;
         

            label1.Text = plusum.ToString();
        }
    }
}
