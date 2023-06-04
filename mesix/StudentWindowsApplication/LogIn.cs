using DAL;
using DataTransferObjects;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace StudentWindowsApplication
{
    public partial class LogIn : Form
    {
        Roles Obj = new Roles();
        Roles FetchedObj = new Roles();
        public LogIn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public DBContext DBcontextObj = new DBContext();

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            cbxRoles.Visible = false;
            this.Text = "Login";
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtPassword.PasswordChar = '*';
            //should be empty
            //Obj.Id = 0;
            //FetchedObj.LoginId=0;
            //HomeDAL hdal = new HomeDAL();
            //List<Roles> RolesList = hdal.GetRoles();
            //cbxRoles.DataSource = RolesList;
            //cbxRoles.DisplayMember = "Role";
            //cbxRoles.ValueMember = "Id";
        }
        private void SignIn_Clicked()
        {
            try
            {
                //check for user
                //fetch user with role
                //if admin then admin else others....
                HomeDAL hdal = new HomeDAL();
                Users User = hdal.ValidateLogin(txtEmail.Text.Trim().ToLower(), txtPassword.Text.Trim().ToLower());
                //if(user!=null){Then Proceed}

                //if(hdal.ValidateLogin())
                //{

                //}
                if (User != null && User.isAuthenticated == true)
                {


                    //Obj.Id = (int)cbxRoles.SelectedValue;
                    //Obj.Email = txtEmail.Text;
                    //Obj.Password = txtPassword.Text;

                    //Admin
                    if (User.Role == "Admin" || User.Role == "ADMIN")
                    {
                        //FetchedObj = hdal.IsValidAdmin(Obj);
                        //if (FetchedObj.LoginId != 0)
                        //{
                        //FetchedObj.Email = txtEmail.Text;
                        this.Hide();
                        //Set User Session For App
                        SessionBean.GlobalSessionUser = User;
                        LoadSystemData(User);
                        AdminHome nextForm = new AdminHome(User);
                        nextForm.SessionObject = new Users();
                        nextForm.SessionObject = User;
                        nextForm.ShowDialog();
                        this.Close();
                        //} else
                        //    MessageBox.Show("Invalid Login ID or Password", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else
                    ////Students
                    //if (User.RoleID == 2)
                    //{
                    //    FetchedObj = hdal.IsValidStudent(Obj);
                    //    if (FetchedObj.LoginId != 0)
                    //    {
                    //        this.Hide();
                    //        StudentHome nextForm = new StudentHome();
                    //        nextForm.StudentObj = new Roles();
                    //        nextForm.StudentObj = FetchedObj;
                    //        nextForm.ShowDialog();
                    //        this.Close();
                    //    }
                    //    else
                    //        MessageBox.Show("Invalid Login ID or Password", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                    ////Employee
                    //if (User.RoleID == 3)
                    //{
                    //    FetchedObj = hdal.IsValidEmployee(Obj);
                    //    if (FetchedObj.LoginId != 0)
                    //    {
                    //        if (FetchedObj.EmpId == 1)//Teacher
                    //        {
                    //            this.Hide();
                    //            TeacherHome nextForm = new TeacherHome();
                    //            nextForm.TeacherLoginObj = new Roles();
                    //            nextForm.TeacherLoginObj = FetchedObj;
                    //            nextForm.ShowDialog();
                    //            this.Close();
                    //        }
                    //        else
                    //        if (FetchedObj.EmpId == 4)//Clerk
                    //        {
                    //            this.Hide();
                    //            ManagementHome nextForm = new ManagementHome();
                    //            nextForm.HomeLoginObj = new Roles();
                    //            nextForm.HomeLoginObj = FetchedObj;
                    //            nextForm.ShowDialog();
                    //            this.Close();
                    //        }
                    //        else
                    //        {
                    //            this.Hide();
                    //            EmployeeHome nextForm = new EmployeeHome();
                    //            nextForm.EmpStaffLoginObj = new Roles();
                    //            nextForm.EmpStaffLoginObj = FetchedObj;
                    //            nextForm.ShowDialog();
                    //            this.Close();
                    //        }
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Invalid Login ID or Password", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    //else
                    ////Parents
                    //if (User.RoleID == 4)
                    //{
                    //    FetchedObj = hdal.IsValidParents(Obj);
                    //    if (FetchedObj.LoginId != 0)
                    //    {
                    //        this.Hide();
                    //        ParentsHome nextForm = new ParentsHome();
                    //        nextForm.ParentObj = new Roles();
                    //        nextForm.ParentObj = FetchedObj;
                    //        nextForm.ShowDialog();
                    //        this.Close();
                    //    }
                    //    else
                    //        MessageBox.Show("Invalid Login ID or Password", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    else
                        MessageBox.Show("Invalid attempt of Login Type. Not Authorized to Access Resources", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password... Please Try Again", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Continue with Currently Subscribed Package", "Unable to Access", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignIn_Clicked();
        }
        private void LoadSystemData(Users u)
        {
            HomeDAL hdal = new HomeDAL();
            var sysDate = hdal.getCurrentSystemDate(u.school.SchoolID);
            if (sysDate.Month < DateTime.Now.Month || sysDate.Year < DateTime.Now.Year)
            {
                hdal.GenerateFeeAtMonthStart(u);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SignIn_Clicked();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.FromArgb(255, 230, 1);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.FromArgb(200, 207, 228);
        }
    }
}
