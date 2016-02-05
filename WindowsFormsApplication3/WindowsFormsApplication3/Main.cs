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
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Do Not Remove
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e) //Customer Information Form Select
        {
            Customer child = new Customer();
            child.MdiParent = this;
            child.Show();
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e) //Order Information Form Select
        {
            Order child = new Order();
            child.MdiParent = this;
            child.Show();
        }

        private void paymentInformationToolStripMenuItem_Click(object sender, EventArgs e) //Payment Information Form Select
        {
            Payment child = new Payment();
            child.MdiParent  = this;
            child.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) //System Logout
        {
            if (MessageBox.Show("Confirm Logout", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Login f1 = new Login();
                f1.Show();
                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // System Exit
        {
            if (MessageBox.Show("Confirm Logout", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void inventoryControlToolStripMenuItem_Click(object sender, EventArgs e) //Inventory Control Form Select
        {
            Inventory_Control child = new Inventory_Control();
            child.MdiParent = this;
            child.Show();
        }

        private void orderApprovalToolStripMenuItem_Click(object sender, EventArgs e) //Manager Approval Form Select
        {
            ManagerApproval child = new ManagerApproval();
            child.MdiParent = this;
            child.Show();
        }

        private void orderQualityControlToolStripMenuItem_Click(object sender, EventArgs e) //Manager Order Quality Control Form Select
        {
            QualityControl child = new QualityControl();
            child.MdiParent = this;
            child.Show();
        }

    }
}
