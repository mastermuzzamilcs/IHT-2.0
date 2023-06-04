using DataTransferObjects;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }
        public Roles EmpStaffLoginObj;
        private void EmployeeHome_Load_1(object sender, EventArgs e)
        {
            ctrlEmployeeHome1.EmpLoginObj = EmpStaffLoginObj;
            ctrlEmployeeHome1.load();
            ShowHideControls(ctrlEmployeeHome1);
        }

        private void tsHome_Click(object sender, EventArgs e)
        {
            ctrlEmployeeHome1.EmpLoginObj = EmpStaffLoginObj;
            ctrlEmployeeHome1.load();
            ShowHideControls(ctrlEmployeeHome1);
        }

        private void tsProfile_Click(object sender, EventArgs e)
        {
            ctrlEmployeeProfile1.EmpProfileObj = EmpStaffLoginObj;
            ctrlEmployeeProfile1.load();
            ShowHideControls(ctrlEmployeeProfile1);
        }

        private void tsAttendance_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlEmployeeAttendanceMark1);
        }

        private void tsSettings_Click(object sender, EventArgs e)
        {
            //ShowHideControls(ctrlEmployeeSettings1);
            MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void tsLogout_Click(object sender, EventArgs e)
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
                {
                    ctrl.Hide();
                }
            }
        }


    }
}
