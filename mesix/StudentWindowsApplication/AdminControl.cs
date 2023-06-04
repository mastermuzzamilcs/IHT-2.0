using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace StudentWindowsApplication
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
            this.Controller = new HomeDAL();
            this.NoticeList = new List<Notices>();
            this.fDetail = new FinancialEntity();
            this.fOvrv = new FinancialOvrv();
        }
        public HomeDAL Controller;
        public FinancialEntity fDetail;
        public FinancialOvrv fOvrv;
        public List<Notices> NoticeList;
        public static AdminControl _instance;
        public static AdminControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminControl();
                return _instance;
            }
        }
        public List<string> Notices { get; set; }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        public void reset()
        {
            _instance = new AdminControl();
        }
        public void LoadFormData()
        {
            //Notices = new List<string>();
            //Notices.Add("\tAhmad joined our school today\n");
            //Notices.Add("\tToday is his first Day\n");
            //Notices.Add("\tAT 9:00 you have a Session with students\n");
            //Notices.Add("\tAt 10 you have meeting with Teachers\n");

            ////
            //foreach (var item in Notices)
            //{
            //    lblNotice1.Text += " " + item;
            //}

            
            List<Int32> listCounts = Controller.GetAllCounts();
            lblCountStudent.Text = Convert.ToString(listCounts[0]);
            lblTeacherCount.Text = Convert.ToString(listCounts[1]);
            lblEmployeeCount.Text = Convert.ToString(listCounts[2]);


            txtMessage.Text = SessionBean.GlobalSessionUser.school.Message;
            LoadNotices();
            LoadFinancialOverview();

            if (File.Exists(ConfigurationManager.AppSettings["ImageRouteDir"] + SessionBean.GlobalSessionUser.school.picName))
            {
                using (FileStream stream = new FileStream(ConfigurationManager.AppSettings["ImageRouteDir"] + SessionBean.GlobalSessionUser.school.picName, FileMode.Open, FileAccess.Read))
                {
                    picPrincipal.Image = Image.FromStream(stream);
                    //picPrincipal.Image = Image.FromFile(ConfigurationManager.AppSettings["ImageRouteDir"] + SessionBean.GlobalSessionUser.school.picName);
                    picPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        public void LoadFinancialOverview()
        {
            this.fOvrv = Controller.GetFinancialOvrv(SessionBean.GlobalSessionUser.school.SchoolID);
            fDetail.IncomeFees = fOvrv.IncomePaidInvoices;
            fDetail.ExpenseSalary = fOvrv.ExpensePaidInvoices;

            lblIncomeFees.Text=fDetail.IncomeFees.ToString();
            lblIncomeServices.Text = fDetail.IncomeServices.ToString();
            lblIncomeOther.Text = fDetail.IncomeOther.ToString();
            lblExpenseSalary.Text = fDetail.ExpenseSalary.ToString();
            lblExpenseAdvertising.Text = fDetail.ExpenseAdvertising.ToString();
            lblExpenseOther.Text = fDetail.ExpenseOthers.ToString();
            lblExpenseMiscCharges.Text = fDetail.ExpenseMiscCharges.ToString();
            lblIncomeTotal.Text = (fDetail.IncomeFees+fDetail.IncomeServices+fDetail.IncomeOther).ToString();
            lblExpenseTotal.Text=(fDetail.ExpenseSalary+ fDetail.ExpenseAdvertising+ fDetail.ExpenseOthers+ fDetail.ExpenseMiscCharges).ToString();
            lblProfitOrLoss.Text = (Convert.ToDecimal(lblIncomeTotal.Text) - Convert.ToDecimal(lblExpenseTotal.Text)).ToString();
        }
        public void HideAllControls()
        {
            //var controls = this.pnlNotices.Controls.Cast<Control>();
            foreach (var ctrl in this.pnlNotices.Controls.Cast<Control>())
            {
                this.pnlNotices.Controls.Remove(ctrl);
            }
        }
        public void LoadNotices()
        {
            this.NoticeList=this.Controller.GetNoticesBySchool(SessionBean.GlobalSessionUser.school.SchoolID);

            while (this.pnlNotices.Controls.Count > 0)
            {

            HideAllControls();
            }
            //string temp = string.Empty;
            foreach(var item in this.NoticeList)
            {
                //temp = item.DSCR + "\n";
                LoadNoticeControl(item);

            }
            //lblNotice1.Text = temp;
        }
        private void AdminControl_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }

        private void smsButtons1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                picPrincipal.Image = bit;
                picPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
                picPrincipal.Image = bit;
                picPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
                SavePic();
            }
        }
        private void SavePic()
        {
            if (picPrincipal != null)
            {
                Image img = picPrincipal.Image;
                SessionBean.GlobalSessionUser.school.picName = "IHT-picPrincipal"+SessionBean.GlobalSessionUser.school.SchoolID;// Asad14
                string path = ConfigurationManager.AppSettings["ImageRouteDir"];// +stu.PictureName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = ConfigurationManager.AppSettings["ImageRouteDir"] + SessionBean.GlobalSessionUser.school.picName;

                if (File.Exists(path))
                {
                    //picPrincipal.Image = null;
                    File.Delete(path);
                }
                if (img != null)
                {
                    img.Save(path);
                    Controller.SaveSchool(SessionBean.GlobalSessionUser.school);
                }
            }
        }
        private void btnMessageSave_Click(object sender, EventArgs e)
        {
            SessionBean.GlobalSessionUser.school.Message = txtMessage.Text;
            HomeDAL hdal = new HomeDAL();
            hdal.SaveSchool(SessionBean.GlobalSessionUser.school);
        }

        private void btnAddNotice_Click(object sender, EventArgs e)
        {
            NoticesForm frm = new NoticesForm();
            frm.CloseNoticeFormEvent += new EventHandler(log_CloseNoticeFormEvent);
            frm.Show();
        }

        private void log_CloseNoticeFormEvent(object sender, EventArgs e)
        {
            LoadNotices();
        }
        public void LoadNoticeControl(Notices item)
        {
                this.pnlNotices.Controls.Add(new RichTextBox()
                {
                    Name = "txtNotice" + item.NoticeID.ToString(),
                    Multiline = true,
                    ReadOnly = true,
                    BackColor = System.Drawing.Color.White,
                    BorderStyle= BorderStyle.FixedSingle,
                    Width = pnlNotices.Size.Width - 30,
                    Tag = item.NoticeID.ToString(),
                    Text = item.DSCR,
                    Font= new Font(FontFamily.GenericSansSerif,12),
                });

                pnlNotices.Controls
                .Cast<RichTextBox>()
                .Where(x => x.Tag.ToString() == item.NoticeID.ToString()).FirstOrDefault()
                .DoubleClick += delegate (object sendera, EventArgs ea)
                {
                    NoticesForm frm = new NoticesForm(item);
                    frm.CloseNoticeFormEvent+= new EventHandler(log_CloseNoticeFormEvent);
                    //frm.QuestionModelUpdatedFormEvent += log_QuestionModelUpdatedFormEvent;
                    //frm.QuestionModelDeletedFormEvent += log_QuestionModelDeletedFormEvent;
                    frm.Show();
                };
        }
    }
}
