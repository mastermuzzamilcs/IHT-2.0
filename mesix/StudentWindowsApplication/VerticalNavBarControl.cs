using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class VerticalNavBarControl : UserControl
    {
        // Custom event to handle navigation button clicks
        public event EventHandler<string> NavigationItemClick;

        public VerticalNavBarControl()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        // Method to raise the NavigationItemClick event
        private void OnNavigationItemClick(string item,Control ctrl)
        {
            HoverColorEffect(ctrl);
            NavigationItemClick?.Invoke(this, item);
        }
        private void HoverColorEffect(Control item)
        {
            var controls = this.tableLayoutPanel1.Controls.Cast<Control>();
            foreach (var ctrl in controls)
            {
                if (ctrl.Name == item.Name)
                {
                    if (ctrl.BackColor != Color.Green)
                    {
                        ctrl.BackColor = Color.Green;
                    }
                }
                else
                {
                    if (ctrl.BackColor != Color.Transparent)
                    {
                        ctrl.BackColor = Color.Transparent;
                    }
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Home",btnHome);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Students",btnStudents);
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Classes",btnClasses);
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Sections",btnSections);
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Subjects",btnSubjects);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("TestExam",btnTest);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Attendance",btnAttendance);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Employees",btnEmployees);
        }

        private void btnExamReport_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("ExamReport",btnExamReport);
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Fee",btnFee);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Salary",btnSalary);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Settings",btnSettings);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("logout",btnLogout);
        }

        private void VerticalNavBarControl_Load(object sender, EventArgs e)
        {

        }

        private void tsiVendors_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Suppliers", btnProductConfs);
        }

        private void tsiCategories_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Categories", btnProductConfs);
        }

        private void tsiProduct_Click(object sender, EventArgs e)
        {
            OnNavigationItemClick("Products", btnProductConfs);
        }
    }

}
