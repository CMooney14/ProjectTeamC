using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Login Button
        {
            //DialogResult dialog = MessageBox.Show("Loging In","", MessageBoxButtons.OK);
            Splash  f1 = new Splash();
            f1.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e) //Exit Button
        {
           // DialogResult dialog = MessageBox.Show("Confirm Exit","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (MessageBox.Show("Confirm Logout", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            //else if (dialog == DialogResult.No)
           // {
                
           // }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //User Name Input
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //User Password Input
        {

        }
    }
}
