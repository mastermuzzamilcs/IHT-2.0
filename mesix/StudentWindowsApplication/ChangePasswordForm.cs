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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.TopMost = true;
        }

        private void ChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        public bool IsValid()
        {
            if(txtOldPass.Text ==null || txtOldPass.Text == string.Empty)
            {
                MessageBox.Show("Incorrect Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNewPass.Text == null || txtNewPass.Text == string.Empty)
            {
                MessageBox.Show("Incorrect Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtConfirmNewPass.Text == null || txtConfirmNewPass.Text == string.Empty)
            {
                MessageBox.Show("Incorrect Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtConfirmNewPass.Text !=  txtNewPass.Text)
            {
                MessageBox.Show("Passwords Do Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtOldPass.Text == txtNewPass.Text)
            {
                MessageBox.Show("Passwords Cant be same as old", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public event EventHandler<PasswordChangedEventArgs> PasswordUpdatedEvent;
        private void btnGntnInvc_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (PasswordUpdatedEvent != null)
                {
                    PasswordChangedEventArgs args = new PasswordChangedEventArgs()
                    {
                        OldPassword = txtOldPass.Text,
                        NewPassword = txtNewPass.Text
                    };
                    //args.Question.State = DataTransferObjects.Enums.EntityState.Added;
                    PasswordUpdatedEvent(sender, args);
                }
            }
            this.Close();
        }
    }
    public class PasswordChangedEventArgs : EventArgs
    {
        public string OldPassword{ get; set; }
        public string NewPassword{ get; set; }
    }
}
