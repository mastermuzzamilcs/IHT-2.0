using DataTransferObjects;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
        }
        public Roles StudentObj;
        private void StudentHome_Load(object sender, EventArgs e)
        {
            ctrlStudentHome1.homeStudentObj = StudentObj;
            ctrlStudentHome1.load();
            ShowHideControls(ctrlStudentHome1);
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

        private void SettingsTSItem1_Click(object sender, EventArgs e)
        {
            //ShowHideControls(ctrlStudentSettings1);
            MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void LogoutTSItem1_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void AttendanceTSItem1_Click(object sender, EventArgs e)
        {
            ctrlStudentAttendanceReport1.attendanceStudentObj = StudentObj;
            ctrlStudentAttendanceReport1.load();
            ShowHideControls(ctrlStudentAttendanceReport1);
        }

        private void TestsTSItem1_Click(object sender, EventArgs e)
        {
            ctrlStudentTestNExam1.testStudentObj = StudentObj;
            ctrlStudentTestNExam1.load();
            ShowHideControls(ctrlStudentTestNExam1);
        }

        private void ClassesTSItem1_Click(object sender, EventArgs e)
        {
            ctrlStudentClass1.classStudentObj = StudentObj;
            ctrlStudentClass1.load();
            ShowHideControls(ctrlStudentClass1);
        }

        private void ProfileTSItem1_Click(object sender, EventArgs e)
        {
            ctrlStudentProfile1.profileStudentObj = StudentObj;
            ctrlStudentProfile1.load();
            ShowHideControls(ctrlStudentProfile1);
        }

        private void HomeTSItem1_Click(object sender, EventArgs e)
        {
            ctrlStudentHome1.homeStudentObj = StudentObj;
            ctrlStudentHome1.load();
            ShowHideControls(ctrlStudentHome1);
        }
    }
}
