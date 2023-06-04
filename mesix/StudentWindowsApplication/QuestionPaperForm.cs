using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class QuestionPaperForm : Form
    {
        public QuestionPaperForm()
        {
            InitializeComponent();
            this.QuesSrNo = 1;
            this.Ques = new QuestionModel();
        }
        public bool IsObjective;
        //public QuestionModel Question;
        public ExamTestManager controller;
        public QuestionPaperForm(ExamTestManager _controller, int _secid, int _testid, bool _isObjective)
        {
            InitializeComponent();
            this.controller = _controller;
            this.Ques = new QuestionModel();
            this.Ques.TestID = _testid;
            this.Ques.SecID = _secid;
            this.Ques.isObjective = _isObjective;
            this.Ques.QuesSrNo = controller.GetSrNoBySecID(this.Ques.SecID);
            //this.Ques.isObjective = this.controller.isObjective;
        }
        public QuestionPaperForm(ExamTestManager _controller, QuestionModel _q)
        {
            InitializeComponent();
            this.controller = _controller;
            this.Ques = _q;
            LoadDataForExistingQues();
            this.isExisting = true;
        }
        public bool isExisting;
        private void LoadDataForExistingQues()
        {
            RefreshFormControl();
            txtSrNo.Text = this.Ques.QuesSrNo.ToString();
            txtMarks.Text = this.Ques.Marks.ToString();
            txtDesc.Text = this.Ques.DESC;
            if (this.Ques.isObjective)
            {
                txtChoiceA.Text = this.Ques.ChoiceA;
                txtChoiceB.Text = this.Ques.ChoiceB;
                txtChoiceC.Text = this.Ques.ChoiceC;
                txtChoiceD.Text = this.Ques.ChoiceD;
            }
            btnDelete.Visible = true;
            btnSubmit.Text = "Update";
        }

        public int QuesSrNo;
        public QuestionModel Ques { get; set; }
        private void QuestionPaperForm_Load(object sender, EventArgs e)
        {
            RefreshFormControl();
            LoadFormData();
            if (this.Ques.isObjective)
            {
                LoadFormDataForObjective();
            }
            else
            {
                LoadFormDataForSubjective();
            }
        }
        public void LoadFormData()
        {
            txtSrNo.Text = this.Ques.QuesSrNo.ToString();
            txtSrNo.ReadOnly = true;
            txtDesc.Text = this.Ques.DESC;
            txtMarks.Text = this.Ques.isObjective ? "1" : "2";
            if (this.Ques.isObjective)
            {
                txtChoiceA.Text = this.Ques.ChoiceA;
                txtChoiceB.Text = this.Ques.ChoiceB;
                txtChoiceC.Text = this.Ques.ChoiceC;
                txtChoiceD.Text = this.Ques.ChoiceD;
            }
        }
        private void LoadFormDataForSubjective()
        {
            this.pnlObjective.Hide();
        }
        private void LoadFormDataForObjective()
        {
        }
        private void RefreshFormControl()
        {
            txtSrNo.Text = String.Empty;
            txtDesc.Text = String.Empty;
            txtMarks.Text = String.Empty;
            txtDesc.Focus();
            if (this.Ques.isObjective)
            {
                txtChoiceA.Text = String.Empty;
                txtChoiceB.Text = String.Empty;
                txtChoiceC.Text = String.Empty;
                txtChoiceD.Text = String.Empty;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFormControl();
        }
        public event EventHandler<QuestionModelAddedEventArgs> QuestionModelAddedFormEvent;
        public event EventHandler<QuestionModelAddedEventArgs> QuestionModelUpdatedFormEvent;
        public event EventHandler<QuestionModelAddedEventArgs> QuestionModelDeletedFormEvent;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Ques.DESC = txtDesc.Text;
            this.Ques.Marks = Convert.ToDecimal(txtMarks.Text);
            if (this.Ques.isObjective)
            {
                this.Ques.ChoiceA = txtChoiceA.Text;
                this.Ques.ChoiceB = txtChoiceB.Text;
                this.Ques.ChoiceC = txtChoiceC.Text;
                this.Ques.ChoiceD = txtChoiceD.Text;
            }
            if (isExisting)
            {
                //controller.UpdateQuestion(this.Ques, this.Ques.SecID);
                if (QuestionModelUpdatedFormEvent != null)
                {
                    QuestionModelAddedEventArgs args = new QuestionModelAddedEventArgs()
                    {
                        Question = this.Ques,
                    };
                    //args.Question.State = DataTransferObjects.Enums.EntityState.Modified;
                    QuestionModelUpdatedFormEvent(sender, args);
                }
            }
            else
            {
                controller.addQuestion(this.Ques, this.Ques.SecID);
                if (QuestionModelAddedFormEvent != null)
                {
                    QuestionModelAddedEventArgs args = new QuestionModelAddedEventArgs()
                    {
                        Question = this.Ques
                    };
                    //args.Question.State = DataTransferObjects.Enums.EntityState.Added;
                    QuestionModelAddedFormEvent(sender, args);
                }
            }

            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isExisting)
            {
                controller.RemoveQuestion(this.Ques, this.Ques.SecID);

                if (QuestionModelDeletedFormEvent != null)
                {
                    QuestionModelAddedEventArgs args = new QuestionModelAddedEventArgs()
                    {
                        Question = this.Ques
                    };
                    args.Question.State = DataTransferObjects.Enums.EntityState.Deleted;
                    QuestionModelDeletedFormEvent(sender, args);
                }
            }
        }
    }

}
