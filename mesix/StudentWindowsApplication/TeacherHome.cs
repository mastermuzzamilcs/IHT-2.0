using DataTransferObjects;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class TeacherHome : Form
    {
        public TeacherHome()
        {
            InitializeComponent();
        }
        public Roles TeacherLoginObj;
        private void TeacherHome_Load(object sender, EventArgs e)
        {
            ctrlTeacherEmployeeHome1.EmpLoginObj = TeacherLoginObj;
            ctrlTeacherEmployeeHome1.load();
            ShowHideControls(ctrlTeacherEmployeeHome1);
        }
        private void ShowHideControls(UserControl currentControl)
        {
            HideAllControls();
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
        private void logout()
        {
            this.Hide();
            LogIn loginObj = new LogIn();
            loginObj.ShowDialog();
            this.Close();
        }

        private void HomeTSItem1_Click(object sender, EventArgs e)
        {
            ctrlTeacherEmployeeHome1.EmpLoginObj = TeacherLoginObj;
            ctrlTeacherEmployeeHome1.load();
            ShowHideControls(ctrlTeacherEmployeeHome1);
        }

        private void SettingsTSItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void LogoutTSItem1_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void ProfileTSItem1_Click(object sender, EventArgs e)
        {
            ctrlTeacherEmployeeProfile1.EmpProfileObj = TeacherLoginObj;
            ctrlTeacherEmployeeProfile1.load();
            ShowHideControls(ctrlTeacherEmployeeProfile1);
        }

        private void FeeTSItem1_Click(object sender, EventArgs e)
        {
            ctrlTeacherStudentAttendance1.stuAttendanceTeacherObj = TeacherLoginObj;
            ctrlTeacherStudentAttendance1.load();
            ShowHideControls(ctrlTeacherStudentAttendance1);
        }

        private void ExamReportsTSItem1_Click(object sender, EventArgs e)
        {
            ctrlTeacherExamReport1.ExamTeacherObj = TeacherLoginObj;
            ctrlTeacherExamReport1.load();
            ShowHideControls(ctrlTeacherExamReport1);
        }

        private void TestExamTSItem1_Click(object sender, EventArgs e)
        {
            ctrlTeacherTestNExam1.testTeacherObj = TeacherLoginObj;
            ctrlTeacherTestNExam1.load();
            ShowHideControls(ctrlTeacherTestNExam1);
        }

        private void ClassesTSItem1_Click(object sender, EventArgs e)
        {
            ctrlTeacherClass11.classTeacherObj = TeacherLoginObj;
            ctrlTeacherClass11.load();
            ShowHideControls(ctrlTeacherClass11);
        }

        private void MarkAttendanceTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlEmployeeAttendanceMark1);
        }
    }
}
