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
    public partial class Form2 : Form
    {
        Form3 frm3;
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
             
            Form3 ss = new Form3();
            ss.Show();
            ss.fethullah += Ss_fethullah;
            
        }

        private void Ss_fethullah(object sender, string e)
        {
            MessageBox.Show("CLSTI");
        }
    }
}
