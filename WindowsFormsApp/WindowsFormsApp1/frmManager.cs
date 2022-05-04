using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
            customizeDesign();
        }

        public void customizeDesign()
        {
           
            func5SubMenuPanel.Visible = false;

        }

        public void hideSubmenu()
        {
            
            if (func5SubMenuPanel.Visible == true)
                func5SubMenuPanel.Visible = false;
        }

        public void showSubmenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubmenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        
        /*private void panelMenuFunc1Btn_Click(object sender, EventArgs e)
        {
            openChildForm(new childForm.carStatistics());
        }*/

        private void panelMenuFunc2Btn_Click(object sender, EventArgs e)
        {
            openChildForm(new childForm.contract());
            hideSubmenu();

        }

        private void panelMenuFunc3Btn_Click(object sender, EventArgs e)
        {
            openChildForm(new childForm.carDepot());
            hideSubmenu();
        }

        private void panelMenuFunc3Sub1Btn_Click(object sender, EventArgs e)
        {
            openChildForm(new childForm.carType());
            hideSubmenu();
        }
        


       

        private void panelMenuFunc5Btn_Click_1(object sender, EventArgs e)
        {
            showSubmenu(func5SubMenuPanel);
        }

        private void func5SubMenupanelBtn1_Click(object sender, EventArgs e)
        {
            openChildForm(new childForm.sale());
            hideSubmenu();
        }

        private void func5SubMenupanelBtn2_Click(object sender, EventArgs e)
        {
            openChildForm(new childForm.contractStatistic());
            hideSubmenu();
        }

        private void func5SubMenupanelBtn3_Click(object sender, EventArgs e)
        {
            openChildForm(new childForm.carStatistics());
            hideSubmenu();

        }
    }
}
