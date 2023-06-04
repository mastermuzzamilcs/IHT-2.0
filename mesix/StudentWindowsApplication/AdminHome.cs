using DataTransferObjects;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace StudentWindowsApplication
{

    public partial class AdminHome : Form
    {
        SpeechRecognitionEngine speechRecognitionEngine = null;
        SpeechSynthesizer Jarvis = new SpeechSynthesizer();
        Users SessionUser;
        Color BackColorPnlVertical;
        Color BackColorPnlSchoolName;
        Color ForeColorPnlSchoolName;
        Color BackColorPnlSearch;
        Color ColorLblWelcome;
        Color ColorDivider;
        Color ColorLblTitle;
        public void InitForm()
        {

            if (ConfigurationManager.AppSettings.Get("Theme").ToString() == "Dark")
            {
                BackColorPnlVertical = Color.FromName(ConfigurationManager.AppSettings["ControlDarkDark"]);
                BackColorPnlSchoolName = Color.FromName(ConfigurationManager.AppSettings["White"]);
                ForeColorPnlSchoolName = Color.FromName(ConfigurationManager.AppSettings["White"]);
                BackColorPnlSearch = Color.FromName(ConfigurationManager.AppSettings["ControlDark"]);
                ColorLblWelcome = Color.FromName(ConfigurationManager.AppSettings["White"]);
                ColorDivider = Color.FromName(ConfigurationManager.AppSettings["White"]);
                ColorLblTitle = Color.FromName(ConfigurationManager.AppSettings["ControlLightLight"]);
            }
            else
            {
                BackColorPnlVertical = Color.FromName(ConfigurationManager.AppSettings["MidnightBlue"]);
                BackColorPnlSchoolName = Color.FromName(ConfigurationManager.AppSettings["White"]);
                ForeColorPnlSchoolName = Color.FromName(ConfigurationManager.AppSettings["ControlText"]);
                BackColorPnlSearch = Color.FromName(ConfigurationManager.AppSettings["White"]);
                ColorLblWelcome = Color.FromName(ConfigurationManager.AppSettings["ControlText"]);
                ColorDivider = Color.FromName(ConfigurationManager.AppSettings["ControlText"]);
                ColorLblTitle = Color.FromName(ConfigurationManager.AppSettings["ControlDarkDark"]);
            }
        }
        public void ReloadFormData()
        {
            InitForm();
            LoadData();
        }
        public AdminHome(Users u)
        {
            InitializeComponent();
            InitForm();
            this.SessionUser = u == null ? new Users() : u;
            LoadData();
        }
        public AdminHome()
        {
            InitializeComponent();
            InitForm();
            LoadData();



            #region AI Declaration


            //// Set the language for speech engine
            //speechRecognitionEngine = SetLanguage("en-US");
            ////Event handler for recognized text 
            //speechRecognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Mainevent_SpeechRecognized);
            ////This is for speak completed event
            //Jarvis.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(speak_completed);
            ////Event for load grammar for speech engine 
            //LoadGrammarAndCommands();
            //// Using the system's default microphone
            //speechRecognitionEngine.SetInputToDefaultAudioDevice();
            //// Start listening 
            //speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);

            #endregion

        }


        #region AI
        /////////////////////////////////////////////////////////////////////////////////////////
        private SpeechRecognitionEngine SetLanguage(string preferredCulture)
        {
            //Checking for installed language and comparing with our given parameter preferredCulture to set speech recognition engine language
            foreach (RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())
            {
                if (config.Culture.ToString() == preferredCulture)
                {
                    speechRecognitionEngine = new SpeechRecognitionEngine(config);
                    break;
                }
            }

            // if the desired culture is not found, then load default
            if (speechRecognitionEngine == null)
            {
                MessageBox.Show("The desired languages is not installed on this machine, the speech-engine will continue using "
                    + SpeechRecognitionEngine.InstalledRecognizers()[0].Culture.ToString() + " as the default language.",
                    "Culture " + preferredCulture + " not found!");
                speechRecognitionEngine = new SpeechRecognitionEngine(SpeechRecognitionEngine.InstalledRecognizers()[0]);
            }

            return speechRecognitionEngine;
        }
        private void speak_completed(object sender, SpeakCompletedEventArgs e)
        {
            //Jarvis.SpeakAsyncCancelAll();
            //ReadBtn.Enabled = true;
        }
        private void Mainevent_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //System Username 
            string Name = Environment.UserName;
            //Recognized Spoken words result is e.Result.Text
            string speech = e.Result.Text;
            //Debug_Livetxt.Text += "You said : " + e.Result.Text + "\n";
            //Switch to e.Result.Text
            switch (speech)
            {
                //Greetings
                case "Ignoring":
                case "You are Ignoring":
                case "You are Ignoring me":
                    Jarvis.SpeakAsync("Yes! Huh! ");
                    break;
                case "hello PC":
                    Jarvis.SpeakAsync("hello " + Name);
                    System.DateTime timenow = System.DateTime.Now;
                    if (timenow.Hour >= 5 && timenow.Hour < 12)
                    { Jarvis.SpeakAsync("Goodmorning " + Name); }
                    if (timenow.Hour >= 12 && timenow.Hour < 18)
                    { Jarvis.SpeakAsync("Good afternoon " + Name); }
                    if (timenow.Hour >= 18 && timenow.Hour < 24)
                    { Jarvis.SpeakAsync("Good evening "); }
                    if (timenow.Hour < 5)
                    { Jarvis.SpeakAsync("Hello " + Name + ", you are still awake you should go to sleep, it's getting late"); }
                    //Jarvis.SpeakAsyncCancelAll();
                    break;
                case "what time is it":
                    System.DateTime now = System.DateTime.Now;
                    string time = now.GetDateTimeFormats('t')[0];
                    Jarvis.SpeakAsync(time);
                    break;
                case "what day is it":
                    string day = "Today is," + System.DateTime.Now.ToString("dddd");
                    Jarvis.SpeakAsync(day);
                    break;
                case "Tell me the date":
                case "Tell me todays date":
                    string date = "The date is, " + System.DateTime.Now.ToString("dd MMM");
                    Jarvis.SpeakAsync(date);
                    date = "" + System.DateTime.Today.ToString(" yyyy");
                    Jarvis.SpeakAsync(date);
                    break;
                case "who are you":
                    Jarvis.SpeakAsync("i am your personal assistant");
                    //Jarvis.SpeakAsync("i can read email, weather report, i can search web for you, anything that you need like a personal assistant do, you can ask me question i will reply to you");
                    break;
                case "what is my name":
                    Jarvis.SpeakAsync(Name);
                    break;
                case "How are you Boy":
                case "Are you okay":
                    Jarvis.SpeakAsync("Yess! i am working correctly");
                    break;
                case "what are you doing":
                    Jarvis.SpeakAsync("i am here to assist you! but people says i am irritating you. huH!");
                    break;
                case "Logout my session":
                case "Lets Exit it":
                    logout();
                    break;
                case "goto settings":
                    TSISettings();
                    break;
                case "Open Students":
                    //ShowHideControls(ctrlStudent1);
                    break;
                case "Open Employees":
                    //ShowHideControls(ctrlEmployee1);
                    break;
                case "Goto Home":
                    //ShowHideControls(adminControl1);
                    break;
                case "View Exam Reports":
                    //ShowHideControls(ctrlExamReport2);
                    break;
                case "Create a Test":
                    //ShowHideControls(ctrlExamTest1);
                    break;
                case "Pay Student Fee":
                    //ShowHideControls(ctrlSearchFee1);
                    break;
                case "Open Classes":
                    //ShowHideControls(ctrlClass1);
                    break;
                case "Open Sections":
                    //ShowHideControls(ctrlSection1);
                    break;
                case "Open Subjects":
                    //ShowHideControls(subjectsCTRL1);
                    break;
                case "View Curriculum":
                    //implementation pending
                    MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //
                    //ShowHideControls(ctrlCurriculum1);
                    break;
                case "Read Todays Notices":
                    //foreach (var item in adminControl1.Notices)
                    {
                        //Jarvis.SpeakAsync(item);
                    }
                    break;
                case "Oh Shutup Please":
                    Jarvis.SpeakAsync("You Shut up ");
                    break;
                case "Be Quiet":
                    Jarvis.SpeakAsyncCancelAll();
                    break;
                case "Azan":
                case "Prayer Time":
                    Jarvis.SpeakAsyncCancelAll();
                    Thread.Sleep(600000);
                    Jarvis.SpeakAsyncCancelAll();
                    //600000
                    break;
                case "thangkeu":
                    Jarvis.SpeakAsync("Your Welcome");
                    break;
                case "Meet My Friend":
                case "Meet My Brother":
                case "Meet My Sister":
                case "Meet My Father":
                case "Meet My Mother":
                case "Meet My Cousin":
                case "Greet My Friend":
                case "Greet My Brother":
                case "Greet My Sister":
                case "Greet My Father":
                case "Greet My Mother":
                case "Greet My Cousin":
                    Jarvis.SpeakAsync("Oh! Masha allah! Welcome! How do you Do?");
                    break;
                case "Say Hi to":
                case "Say Hello to":
                    System.DateTime timenowT = System.DateTime.Now;
                    if (timenowT.Hour >= 5 && timenowT.Hour < 12)
                    { Jarvis.SpeakAsync("Hi a very Goodmorning! How are you"); }
                    if (timenowT.Hour >= 12 && timenowT.Hour < 18)
                    { Jarvis.SpeakAsync("Hi a very Good afternoon! How are you " + Name); }
                    if (timenowT.Hour >= 18 && timenowT.Hour < 24)
                    { Jarvis.SpeakAsync("Hi a very Good evening! How are you "); }

                    if (timenowT.Hour < 5)
                    {
                        Jarvis.SpeakAsync("Hi , you are still awake you should go to sleep, it's getting late. " +
                          "Early to bed and Early to rize... Makes a Man! Healthy! Wealthy! And Wise... You Silly Human");
                    }
                    //Jarvis.SpeakAsyncCancelAll();
                    break;
                case "Say Salam to":
                    Jarvis.SpeakAsync("Assalam O Alikum! ");
                    System.DateTime timenowS = System.DateTime.Now;
                    if (timenowS.Hour >= 5 && timenowS.Hour < 12)
                    { Jarvis.SpeakAsync(" and a very Goodmorning! How are you"); }
                    if (timenowS.Hour >= 12 && timenowS.Hour < 18)
                    { Jarvis.SpeakAsync(" and a very Good afternoon! How are you " + Name); }
                    if (timenowS.Hour >= 18 && timenowS.Hour < 24)
                    { Jarvis.SpeakAsync(" and a very Good evening! How are you "); }

                    if (timenowS.Hour < 5)
                    {
                        Jarvis.SpeakAsync("you are still awake you should go to sleep, it's getting late. " +
                          "Early to bed and Early to rize... Makes a Man Healthy Wealthy And Wise... You Silly Human");
                    }
                    //Jarvis.SpeakAsyncCancelAll();
                    break;
                case "Saad is here":
                case "Saad is Listening to you":
                    Jarvis.SpeakAsync(Name + " ! I dont Care. I am a Robot. I am much powerful than Human");
                    break;
                case "He is Sad":
                case "She is Sad":
                case "He is not Happy":
                case "She is not Happy":
                case "He is not Happy Today":
                case "She is not Happy Today":
                    Jarvis.SpeakAsync("Silly Human Chonchulay! I dont have Feelings Sorry!");
                    break;

            }
        }
        private void LoadGrammarAndCommands()
        {
            try
            {
                //string connectionstring = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                string connectionstring = @"Data Source=DESKTOP-A61AK54\NEWTEST;Initial Catalog=StudentDataBase;Integrated Security=True";// ConfigurationManager.AppSettings["Con1"];           
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.Connection = con;
                sc.CommandText = "SELECT LanguageData FROM GrammarDictionary";
                //sc.CommandType = CommandType.TableDirect;
                SqlDataReader sdr = sc.ExecuteReader();
                while (sdr.Read())
                {
                    var Loadcmd = sdr["LanguageData"].ToString();
                    Grammar commandgrammar = new Grammar(new GrammarBuilder(new Choices(Loadcmd)));
                    speechRecognitionEngine.LoadGrammarAsync(commandgrammar);

                }
                sdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Jarvis.SpeakAsync("I've detected an in valid entry in your web commands, possibly a blank line. web commands will case to work until it is fixed." + ex.Message);
            }
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////



        public Users SessionObject
        {
            get;
            set;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            this.Text = "Admin Dashboard";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            lblAdminName.Text = Convert.ToString(SessionObject.UserName);
            ShowAdminHomeForm();
            //HideAllControls();
            //try
            //{
            //    //if (this.pnlModule.Controls.Contains(AdminControl.Instance))
            //    //{
            //    //    AdminControl.Instance.reset();
            //    //}

            //    //    this.pnlModule.Controls.Add(AdminControl.Instance);
            //    //    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
            //    //    //ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.studentId, this.classid, Convert.ToInt32(this.RollNum), this.name);
            //    //    AdminControl.Instance.Dock = DockStyle.Fill;
            //    //    AdminControl.Instance.BringToFront();

            //}
            //catch (Exception)
            //{
            //}
            //HoverColorEffect(menuStrip1);
            //ShowHideControls(adminControl1);
            Jarvis.SpeakAsync("Welcome" + SessionObject.UserName);
        }
        public void LoadData()
        {
            //this.pnlVerticalMenu.BackColor = BackColorPnlVertical;
            //this.pnlSchoolName.BackColor = BackColorPnlSchoolName;
            //this.lblSchoolName.BackColor = BackColorPnlSchoolName;
            //this.lblSchoolName.ForeColor = ForeColorPnlSchoolName;
            //this.pnlSearch.BackColor = BackColorPnlSearch;
            //this.lblWellcome.ForeColor = ColorLblWelcome;
            ////this.label1.ForeColor = ColorDivider;
            //this.lblTitle.ForeColor = ColorLblTitle;

            this.lblSchoolName.Text = this.SessionUser.school.SchoolName.ToString();
            this.lblAdminName.Text = this.SessionUser.UserName.ToString();
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAdminHomeForm();
        }
        private void HoverColorEffect(MenuStrip item)
        {
            var controls = this.pnlVerticalMenu.Controls.Cast<Control>();
            foreach (var ctrl in controls)
            {
                if (ctrl.Name == item.Name)
                {
                    ctrl.BackColor = Color.Green;
                }
                else
                {
                    ctrl.BackColor = Color.Transparent;
                }
            }
        }
        private void ShowAdminHomeForm()
        {
            HoverColorEffect(menuStrip1);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(AdminControl.Instance))
                //{
                //    this.pnlModule.Controls.Add(AdminControl.Instance);
                //    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                //    //ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.studentId, this.classid, Convert.ToInt32(this.RollNum), this.name);
                //    AdminControl.Instance.Dock = DockStyle.Fill;
                //    AdminControl.Instance.BringToFront();
                //}
                //else
                //{
                //    AdminControl.Instance.BringToFront();
                //}
                AdminControl.Instance.reset();
                AdminControl._instance = null;
                this.pnlModule.Controls.Add(AdminControl.Instance);
                //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                //ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.studentId, this.classid, Convert.ToInt32(this.RollNum), this.name);
                AdminControl.Instance.Dock = DockStyle.Fill;
                AdminControl.Instance.BringToFront();
            }
            catch (Exception)
            {
            }
            //ShowHideControls(adminControl1);
        }
        private void SectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSectionsCtrl();
        }
        private void ShowSectionsCtrl()
        {
            HoverColorEffect(menuStrip9);
            HideAllControls();
            try
            {
                ctrlSection.Instance.reset();
                this.pnlModule.Controls.Add(ctrlSection.Instance);
                //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                ctrlSection.Instance.LoadData();
                ctrlSection.Instance.Dock = DockStyle.Fill;
                ctrlSection.Instance.BringToFront();
            }
            catch (Exception)
            {
            }
            //ctrlSection1.LoadData();
            //ShowHideControls(ctrlSection1);
        }
        private void SubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSubjectsCtrl();
        }
        private void ShowSubjectsCtrl()
        {
            HoverColorEffect(menuStrip8);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(SubjectsCTRL.Instance))
                //{
                SubjectsCTRL.Instance.reset();
                    this.pnlModule.Controls.Add(SubjectsCTRL.Instance);
                    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    SubjectsCTRL.Instance.LoadData();
                    SubjectsCTRL.Instance.Dock = DockStyle.Fill;
                    SubjectsCTRL.Instance.BringToFront();
                //}
                //else
                //{
                //    SubjectsCTRL.Instance.BringToFront();
                //}
            }
            catch (Exception)
            {
            }
            //subjectsCTRL1.LoadData();
            //ShowHideControls(subjectsCTRL1);
        }
        private void ExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExamsTestCtrl();
        }
        private void ShowExamsTestCtrl()
        {
            HoverColorEffect(menuStrip7);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(ctrlExamTest.Instance))
                //{
                ctrlExamTest.Instance.reset();
                    this.pnlModule.Controls.Add(ctrlExamTest.Instance);
                    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    ctrlExamTest.Instance.LoadData();
                    ctrlExamTest.Instance.Dock = DockStyle.Fill;
                    ctrlExamTest.Instance.BringToFront();
                //}
                //else
                //{
                //    ctrlExamTest.Instance.BringToFront();
                //}
            }
            catch (Exception)
            {
            }
            //ctrlExamTest1.LoadData();
            //ShowHideControls(ctrlExamTest1);
        }
        private void CurriculumToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowAttendanceCtrl();
        }
        private void ShowAttendanceCtrl()
        {
            MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEmployeesCtrl();
        }
        private void ShowEmployeesCtrl()
        {
            HoverColorEffect(menuStrip5);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(ctrlEmployee.Instance))
                //{
                ctrlEmployee.Instance.reset();
                    this.pnlModule.Controls.Add(ctrlEmployee.Instance);
                    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    //ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.studentId, this.classid, Convert.ToInt32(this.RollNum), this.name);
                    ctrlEmployee.Instance.Dock = DockStyle.Fill;
                    ctrlEmployee.Instance.BringToFront();
                //}
                //else
                //{
                //    ctrlEmployee.Instance.BringToFront();
                //}
            }
            catch (Exception)
            {
            }
            //ShowHideControls(ctrlEmployee1);
        }
        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExamReportsCtrl();
        }
        private void ShowExamReportsCtrl()
        {
            HoverColorEffect(menuStrip4);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(ctrlExamReport.Instance))
                //{
                ctrlExamReport.Instance.reset();
                    this.pnlModule.Controls.Add(ctrlExamReport.Instance);
                    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    ctrlExamReport.Instance.LoadData();
                    ctrlExamReport.Instance.Dock = DockStyle.Fill;
                    ctrlExamReport.Instance.BringToFront();
                //}
                //else
                //{
                //    ctrlExamReport.Instance.BringToFront();
                //}
            }
            catch (Exception)
            {
            }
            //ctrlExamReport2.LoadData();
            //ShowHideControls(ctrlExamReport2);
        }
        private void StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsCtrl();
        }
        private void ShowStudentsCtrl()
        {
            HoverColorEffect(menuStrip11);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(ctrlStudent.Instance))
                //{
                ctrlStudent.Instance.reset();
                this.pnlModule.Controls.Add(ctrlStudent.Instance);
                //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                //ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.studentId, this.classid, Convert.ToInt32(this.RollNum), this.name);
                ctrlStudent.Instance.Dock = DockStyle.Fill;
                ctrlStudent.Instance.BringToFront();
                //}
                //else
                //{
                //    ctrlStudent.Instance.BringToFront();
                //}
            }
            catch (Exception)
            {
            }
            //ShowHideControls(ctrlStudent1);
        }
        private void LogoutTSItem1_Click(object sender, EventArgs e)
        {
            TSISettings();
        }
        private void logout()
        {
            Jarvis.SpeakAsyncCancelAll();
            this.Hide();
            LogIn loginObj = new LogIn();
            SessionBean.GlobalSessionUser = null;
            loginObj.ShowDialog();
            DisposeAllControls();
            this.Dispose();
            this.Close();
        }

        private void FeeStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowFeeCtrl();
        }
        private void ShowFeeCtrl()
        {
            HoverColorEffect(menuStrip2);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(ctrlSearchFee.Instance))
                //{
                ctrlSearchFee.Instance.reset();
                    this.pnlModule.Controls.Add(ctrlSearchFee.Instance);
                    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    //ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.studentId, this.classid, Convert.ToInt32(this.RollNum), this.name);
                    ctrlSearchFee.Instance.Dock = DockStyle.Fill;
                    ctrlSearchFee.Instance.BringToFront();
                //}
                //else
                //{
                //    ctrlSearchFee.Instance.BringToFront();
                //}
            }
            catch (Exception)
            {
            }
            //ShowHideControls(ctrlSearchFee1);
        }
        private void ClassesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowClassesCtrl();
        }

        private void ShowClassesCtrl()
        {
            HoverColorEffect(menuStrip10);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(ctrlClass.Instance))
                //{
                ctrlClass.Instance.reset();
                this.pnlModule.Controls.Add(ctrlClass.Instance);
                //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                //ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.studentId, this.classid, Convert.ToInt32(this.RollNum), this.name);
                ctrlClass.Instance.Dock = DockStyle.Fill;
                ctrlClass.Instance.BringToFront();
                //}
                //else
                //{
                //    ctrlClass.Instance.BringToFront();
                //}
            }
            catch (Exception)
            {
            }
            //ShowHideControls(ctrlClass1);
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
        private void DisposeAllControls()
        {
            var controls = this.pnlModule.Controls.Cast<Control>();
            foreach (var ctrl in controls)
            {
                ctrl.Dispose();
                this.pnlModule.Controls.Remove(ctrl);
            }
        }
        private void HideAllControls()
        {
            var controls = this.pnlModule.Controls.Cast<Control>();
            foreach (var ctrl in controls)
            {
                ctrl.Dispose();
                this.pnlModule.Controls.Remove(ctrl);
            }
        }
        private void SettingsTSItem1_Click(object sender, EventArgs e)
        {
            TSI_Salary();
        }
        private void TSISettings()
        {
            HoverColorEffect(menuStrip12);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(ctrlSettings.Instance))
                //{
                ctrlSettings.Instance.reset();
                    this.pnlModule.Controls.Add(ctrlSettings.Instance);
                    ctrlSettings.Instance.changeParentTextWithCustomEvent += new EventHandler(log_changeParentTextWithCustomEvent);
                    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    ctrlSettings.Instance.loadData(SessionBean.GlobalSessionUser);
                    //ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.studentId, this.classid, Convert.ToInt32(this.RollNum), this.name);
                    ctrlSettings.Instance.Dock = DockStyle.Fill;
                    ctrlSettings.Instance.BringToFront();
                //}
                //else
                //{
                //    ctrlSettings.Instance.BringToFront();
                //}
            }
            catch (Exception)
            {
            }
            //ShowHideControls(ctrlSettings1);
            //ctrlSettings settingCtrl = new ctrlSettings(this.SessionUser);
            //ShowHideControls(ctrlSettings1);
        }
        private void log_changeParentTextWithCustomEvent(object sender, EventArgs e)
        {
            this.ReloadFormData();
        }
        private void TSI_Salary()
        {
            HoverColorEffect(menuStrip3);
            HideAllControls();
            try
            {
                //if (!this.pnlModule.Controls.Contains(ctrlSearchSalary.Instance))
                //{
                ctrlSearchSalary.Instance.reset();
                    this.pnlModule.Controls.Add(ctrlSearchSalary.Instance);
                    //ctrlSettings.Instance.changeParentTextWithCustomEvent += new EventHandler(log_changeParentTextWithCustomEvent);
                    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    //ctrlSettings.Instance.loadData(this.SessionObject);
                    //ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.studentId, this.classid, Convert.ToInt32(this.RollNum), this.name);
                    ctrlSearchSalary.Instance.Dock = DockStyle.Fill;
                    ctrlSearchSalary.Instance.BringToFront();
                //}
                //else
                //{
                //    ctrlSearchSalary.Instance.BringToFront();
                //}
            }
            catch (Exception)
            {
            }

        }
        private void SalaryTSI_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            ShowAdminHomeForm();
        }

        private void menuStrip11_Click(object sender, EventArgs e)
        {
            ShowStudentsCtrl();
        }

        private void menuStrip10_Click(object sender, EventArgs e)
        {
            ShowClassesCtrl();
        }

        private void menuStrip9_Click(object sender, EventArgs e)
        {
            ShowSectionsCtrl();
        }

        private void menuStrip8_Click(object sender, EventArgs e)
        {
            ShowSubjectsCtrl();
        }

        private void menuStrip7_Click(object sender, EventArgs e)
        {
            ShowExamsTestCtrl();
        }

        private void menuStrip6_Click(object sender, EventArgs e)
        {
            ShowAttendanceCtrl();
        }

        private void menuStrip5_Click(object sender, EventArgs e)
        {
            ShowEmployeesCtrl();
        }

        private void menuStrip4_Click(object sender, EventArgs e)
        {
            ShowExamReportsCtrl();
        }

        private void menuStrip2_Click(object sender, EventArgs e)
        {
            ShowFeeCtrl();
        }

        private void menuStrip3_Click(object sender, EventArgs e)
        {
            TSI_Salary();
        }

        private void menuStrip11_MouseHover(object sender, EventArgs e)
        {

        }

        private void menuStrip11_MouseEnter(object sender, EventArgs e)
        {
            //HoverColorEffect(menuStrip11, true, true);
            //isHoverLock = false;
            menuStrip11.BackColor = Color.Green;
        }
        public bool isHoverLock = false;
        private void menuStrip11_MouseLeave(object sender, EventArgs e)
        {
            //HoverColorEffect(menuStrip11, true, false);
            //isHoverLock = true;
            //menuStrip11.BackColor = Color.Transparent;
        }

        private void menuStrip12_Click(object sender, EventArgs e)
        {
            TSISettings();
        }
    }
}
