using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class NoticesForm : Form
    {
        public NoticesForm()
        {
            InitializeComponent();
            this.Controller = new HomeDAL();
            this.Notice = new Notices();
        }
        public NoticesForm(Notices _notice)
        {
            InitializeComponent();
            this.Controller = new HomeDAL();
            this.Notice = _notice;
            this.IsExisting = true;
        }
        HomeDAL Controller;
        Notices Notice;
        public event EventHandler CloseNoticeFormEvent;


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.Controller.DeleteNotices(this.Notice.NoticeID) == 0)
            {
                MessageBox.Show("An Unhandleld Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Notice.SchoolID = SessionBean.GlobalSessionUser.school.SchoolID;
            this.Notice.DSCR = txtDSCR.Text;
            if (!IsExisting)
            {
                if (this.Controller.InsertNotices(this.Notice) == 0)
                {
                    MessageBox.Show("An Unhandleld Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (this.Controller.UpdateNotices(this.Notice) == 0)
                {
                    MessageBox.Show("An Unhandleld Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }
        public bool IsExisting = false;
        private void NoticesForm_Load(object sender, EventArgs e)
        {
            if (IsExisting)
            {
                txtDSCR.Text = this.Notice.DSCR;
            }
            else
            {
                btnDelete.Visible = false;
            }
            this.CenterToScreen();
        }

        private void NoticesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseNoticeFormEvent != null)
            {
                CloseNoticeFormEvent(sender, new EventArgs());
            }
        }
    }
}
