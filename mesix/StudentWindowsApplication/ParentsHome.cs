using DataTransferObjects;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ParentsHome : Form
    {
        public ParentsHome()
        {
            InitializeComponent();
        }
        public Roles ParentObj;
        private void ShowHideControls(UserControl currentControl)
        {
            HideAllControls();
            var controls = this.pnlModule.Controls.Cast<Control>();
            foreach (var ctrl in controls)
            {
                if (ctrl.GetType().BaseType.Name == typeof(UserControl).Name)
                    ctrl.Hide();
            }
            if (currentControl != null)
                currentControl.Show();
        }
        private void HideAllControls()
        {

            var controls = this.pnlModule.Controls.Cast<Control>();
            foreach (var ctrl in controls)
            {
                if (ctrl.GetType().BaseType.Name == typeof(UserControl).Name)
                    ctrl.Hide();
            }
        }
        private void StudentMenuBar_Click(object sender, EventArgs e)
        {
            ctrlParentProfile1.profileParentObj = ParentObj;
            ctrlParentProfile1.load();
            ShowHideControls(ctrlParentProfile1);
        }
        private void LogoutTSItem1_Click(object sender, EventArgs e)
        {
            logout();
        }
        private void logout()
        {
            this.Hide();
            LogIn loginObj = new LogIn();
            loginObj.ShowDialog();
            this.Close();
        }

        private void FeeStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ParentsHome_Load(object sender, EventArgs e)
        {
            ctrlParentHome1.homeParentObj = ParentObj;
            ctrlParentHome1.load();
            ShowHideControls(ctrlParentHome1);
        }

        private void ClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrlParentsChildren1.childrenParentObj = ParentObj;
            ctrlParentsChildren1.load();
            ShowHideControls(ctrlParentsChildren1);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrlParentHome1.homeParentObj = ParentObj;
            ctrlParentHome1.load();
            ShowHideControls(ctrlParentHome1);
        }
    }
}
