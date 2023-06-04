using DataTransferObjects;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{

    public partial class ManagementHome : Form
    {
        public ManagementHome()
        {
            InitializeComponent();
        }
        public Roles HomeLoginObj;
        private void ManagementHome_Load(object sender, EventArgs e)
        {
            ctrlManagementEmployeeHome1.EmpLoginObj = HomeLoginObj;
            ctrlManagementEmployeeHome1.load();
            ShowHideControls(ctrlManagementEmployeeHome1);
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
        private void StudentsTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlManagementStudent1);
        }

        private void SectionsTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlManagementSection1);
        }

        private void TestExamTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlManagementTestExam1);
        }

        private void EmployeeTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlManagementEmployee1);
        }

        private void ExamReportsTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlManagementExamReport1);
        }

        private void FeeTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlManagementSearchFee1);
        }

        private void ProfileTSItem1_Click(object sender, EventArgs e)
        {
            ctrlManagementProfile1.EmpProfileObj = HomeLoginObj;
            ctrlManagementProfile1.load();
            ShowHideControls(ctrlManagementProfile1);
        }

        private void SettingsTSItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void ClassesTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlManagementClass1);
        }

        private void HomeTSItem1_Click(object sender, EventArgs e)
        {
            ctrlManagementEmployeeHome1.EmpLoginObj = HomeLoginObj;
            ctrlManagementEmployeeHome1.load();
            ShowHideControls(ctrlManagementEmployeeHome1);
        }

        private void SubjectsTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlManagementSubjects1);
        }
        private void CurriculumTSItem1_Click(object sender, EventArgs e)
        {
            ShowHideControls(ctrlManagementCurriculum1);
        }

        private void ctrlManagementEmployeeHome1_Load(object sender, EventArgs e)
        {
        }
    }
}
