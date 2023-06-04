using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlExamSection : UserControl
    {
        public ctrlExamSection()
        {
            InitializeComponent();
        }
        public ExamTestManager controller;
        public TestSections TestSection;
        public int SecID
        {
            get;
            set;
        }
        public bool IsExists;
        public ctrlExamSection(bool _isObjective, ExamTestManager _controller, string _title, int _secid, bool _isExists = false)
        {
            InitializeComponent();
            this.TestSection = new TestSections();
            //this.controller = new ExamTestManager();
            this.controller = _controller;
            //this.controller.isObjective = _isObjective;
            this.TestSection.Title = _title;
            this.TestSection.TestID = this.controller.GetControllerTestID();
            this.TestSection.SecID = _secid;
            this.TestSection.IsObjective = _isObjective;
            this.IsExists = _isExists;
        }
        public bool IsObjective;
        public string Title;
        private void ctrlExamSection_Load(object sender, EventArgs e)
        {
            lblSecTitle.Text = this.TestSection.Title;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionPaperForm qpf = new QuestionPaperForm(this.controller, this.TestSection.SecID, this.TestSection.TestID, this.TestSection.IsObjective);
            qpf.QuestionModelAddedFormEvent += log_QuestionModelAddedFormEvent;
            qpf.QuestionModelDeletedFormEvent += log_QuestionModelDeletedFormEvent;
            qpf.Show();
        }

        private void log_QuestionModelDeletedFormEvent(object sender, QuestionModelAddedEventArgs e)
        {
            Panel1.Controls.Remove(
            Panel1.Controls.Cast<RichTextBox>().Where(x => x.Tag.ToString() == e.Question.QuesSrNo.ToString()).FirstOrDefault());
        }
        public void PopulateTestSectionByQuestions(List<QuestionModel> Quests)
        {
            if (IsExists)
            {
                foreach (var q in Quests)
                {
                    LoadQuestion(q);
                }
            }
        }
        public void LoadQuestion(QuestionModel Question)
        {
            if (Question.isObjective)
            {
                this.Panel1.Controls.Add(new RichTextBox()
                {
                    Name = "lblQDesc" + Question.QuesSrNo.ToString(),
                    Multiline = true,
                    ReadOnly = true,
                    BackColor=System.Drawing.Color.White,
                    Width = Panel1.Size.Width - 10,
                    ScrollBars = RichTextBoxScrollBars.None,
                    Tag = Question.QuesSrNo.ToString(),
                    Text = Question.QuesSrNo.ToString() + ". " + Question.DESC + "\n (A)" + Question.ChoiceA
                    + "\n (B)" + Question.ChoiceB + "\n (C)" + Question.ChoiceC + "\n (D)" + Question.ChoiceD
                });

                Panel1.Controls.Cast<RichTextBox>().Where(x => x.Tag.ToString() == Question.QuesSrNo.ToString()).FirstOrDefault()
                .DoubleClick += delegate (object sendera, EventArgs ea)
                {
                    QuestionPaperForm qpf = new QuestionPaperForm(this.controller, Question);
                    qpf.QuestionModelUpdatedFormEvent += log_QuestionModelUpdatedFormEvent;
                    qpf.QuestionModelDeletedFormEvent += log_QuestionModelDeletedFormEvent;
                    qpf.Show();
                };

            }
            else
            {
                this.Panel1.Controls.Add(new RichTextBox()
                {
                    Name = "lblQDesc" + Question.QuesSrNo.ToString(),
                    Multiline = true,
                    ReadOnly = true,
                    BackColor=System.Drawing.Color.White,
                    Width = Panel1.Size.Width - 10,
                    ScrollBars = RichTextBoxScrollBars.None,
                    Tag = Question.QuesSrNo.ToString(),
                    Text = "Q " + Question.QuesSrNo.ToString() + ". " + Question.DESC
                });

                Panel1.Controls.Cast<RichTextBox>().Where(x => x.Tag.ToString() == Question.QuesSrNo.ToString()).FirstOrDefault()
                .DoubleClick += delegate (object sendera, EventArgs ea)
                {
                    QuestionPaperForm qpf = new QuestionPaperForm(this.controller, Question);
                    qpf.QuestionModelUpdatedFormEvent += log_QuestionModelUpdatedFormEvent;
                    qpf.QuestionModelDeletedFormEvent += log_QuestionModelDeletedFormEvent;
                    qpf.Show();
                };
            }
        }
        private void log_QuestionModelAddedFormEvent(object sender, QuestionModelAddedEventArgs e)
        {
            LoadQuestion(e.Question);
            //if (e.Question.isObjective)
            //{
            //    this.Panel1.Controls.Add(new RichTextBox()
            //    {
            //        Name = "lblQDesc" + e.Question.QuesSrNo.ToString(),
            //        Multiline = true,
            //        ReadOnly = true,
            //        Width = Panel1.Size.Width - 10,
            //        ScrollBars = RichTextBoxScrollBars.None,
            //        Tag = e.Question.QuesSrNo.ToString(),
            //        Text = e.Question.QuesSrNo.ToString() + ". " + e.Question.DESC + "\n (A)" + e.Question.ChoiceA
            //        + "\n (B)" + e.Question.ChoiceB + "\n (C)" + e.Question.ChoiceC + "\n (D)" + e.Question.ChoiceD
            //    });

            //    Panel1.Controls.Cast<RichTextBox>().Where(x => x.Tag.ToString() == e.Question.QuesSrNo.ToString()).FirstOrDefault()
            //    .DoubleClick += delegate (object sendera, EventArgs ea)
            //    {
            //        QuestionPaperForm qpf = new QuestionPaperForm(this.controller, e.Question);
            //        qpf.QuestionModelUpdatedFormEvent += log_QuestionModelUpdatedFormEvent;
            //        qpf.QuestionModelDeletedFormEvent += log_QuestionModelDeletedFormEvent;
            //        qpf.Show();
            //    };

            //}
            //else
            //{
            //    this.Panel1.Controls.Add(new RichTextBox()
            //    {
            //        Name = "lblQDesc" + e.Question.QuesSrNo.ToString(),
            //        Multiline = true,
            //        ReadOnly = true,
            //        Width = Panel1.Size.Width - 10,
            //        ScrollBars = RichTextBoxScrollBars.None,
            //        Tag = e.Question.QuesSrNo.ToString(),
            //        Text = "Q " + e.Question.QuesSrNo.ToString() + ". " + e.Question.DESC
            //    });

            //    Panel1.Controls.Cast<RichTextBox>().Where(x => x.Tag.ToString() == e.Question.QuesSrNo.ToString()).FirstOrDefault()
            //    .DoubleClick += delegate (object sendera, EventArgs ea)
            //    {
            //        QuestionPaperForm qpf = new QuestionPaperForm(this.controller, e.Question);
            //        qpf.QuestionModelUpdatedFormEvent += log_QuestionModelUpdatedFormEvent;
            //        qpf.QuestionModelDeletedFormEvent += log_QuestionModelDeletedFormEvent;
            //        qpf.Show();
            //    };
            //}
            RefreshForm();
        }

        private void log_QuestionModelUpdatedFormEvent(object sender, QuestionModelAddedEventArgs e)
        {
            RichTextBox rtb = Panel1.Controls.Cast<RichTextBox>().Where(x => x.Tag.ToString() == e.Question.QuesSrNo.ToString()).FirstOrDefault();
            if (e.Question.isObjective)
            {
                rtb.Text = e.Question.QuesSrNo.ToString() + ". " + e.Question.DESC + "\n (A)" + e.Question.ChoiceA
                        + "\n (B)" + e.Question.ChoiceB + "\n (C)" + e.Question.ChoiceC + "\n (D)" + e.Question.ChoiceD;

            }
            else
            {
                rtb.Text = "Q " + e.Question.QuesSrNo.ToString() + ". " + e.Question.DESC;
            }
        }
        private void RefreshForm()
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if ()
            //{
            //    listView1.Items.Remove(listView1.SelectedItems[0]);

            //}
        }
        public event EventHandler<ExamSectionDeletedEventArgs> DeleteExamSectionCtrlEvent;
        private void button3_Click(object sender, EventArgs e)
        {

            controller.RemoveSection(this.TestSection);
            if (DeleteExamSectionCtrlEvent != null)
            {
                DeleteExamSectionCtrlEvent(sender, new ExamSectionDeletedEventArgs() { ExamSectionID = TestSection.SecID, ExamTestID = TestSection.TestID });
            }

        }

        private void btnAddQues_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btnDelete, "It Deletes the Whole Sector");
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(this);
        }

        private void btnAddQues_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btnAddQues, "It Add new Question");

        }

        private void btnAddQues_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(this);

        }

        //private void richTextBox1_DoubleClick(object sender, EventArgs e)
        //{
        //    QuestionPaperForm qpf = new QuestionPaperForm(this.controller, this.TestSection.SecID, this.TestSection.TestID, this.TestSection.IsObjective);
        //    qpf.QuestionModelAddedFormEvent += log_QuestionModelAddedFormEvent;
        //    qpf.QuestionModelDeletedFormEvent += log_QuestionModelDeletedFormEvent;
        //    qpf.Show();
        //}
    }
    public class ExamSectionDeletedEventArgs : EventArgs
    {
        public int ExamSectionID { get; set; }
        public int ExamTestID { get; set; }
    }
}
