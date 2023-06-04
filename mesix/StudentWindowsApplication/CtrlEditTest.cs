using DAL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class CtrlEditTest : UserControl
    {
        private static CtrlEditTest _instance;
        public static CtrlEditTest Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CtrlEditTest();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new CtrlEditTest();
        }
        public ExamTestManager controller;
        public CtrlEditTest()
        {
            InitializeComponent();
            controller = new ExamTestManager();
            //this.listView1.View = View.List;
        }
        public void LoadData(int _testID)
        {
            button2.Visible = false;
            btnSaveTest.Visible = false;
            btnCloseTest.Visible = false;
            controller = new ExamTestManager();
            controller.InitializeTestID(_testID);
            //check if EditTest already committed or not
            //ExamClass
            this.TestID = _testID;
            RefreshFormControls();
            if (controller.CheckIfTestExists(_testID))
            {
                isExists = true;
            }
            else
            {
                isExists = false;
            }
            LoadMandatoryData();
        }
        public void LoadMandatoryData()
        {
            Panel1.Controls.Clear();
            if (isExists)
            {
                var obj = controller.GetControllerTestEditEntity();
                foreach (var sec in obj.TestSection)
                {
                    ctrlExamSection ces = new ctrlExamSection(sec.IsObjective, this.controller, sec.Title, sec.SecID, isExists);
                    ces.DeleteExamSectionCtrlEvent += log_DeleteExamSectionCtrlEvent;
                    Panel1.Controls.Add(ces);
                    ces.PopulateTestSectionByQuestions(sec.Questions);
                }
            }
        }
        public bool isExists;
        public int SecID = 0;
        public int TestID;

        //public int TestID { get { return controller.testEntity.TestID; } set { controller.testEntity.TestID = value; } }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                TestSections ts = new TestSections()
                {
                    TestID = this.controller.GetControllerTestID(),
                    SecID = this.controller.GetControllerSecID(),
                    Title = txtTitle.Text,
                    IsObjective = cbxSecType.SelectedIndex == 1 ? true : false
                    //State=DataTransferObjects.Enums.EntityState.Added
                };
                this.controller.addSection(ts);
                ctrlExamSection ces = new ctrlExamSection(cbxSecType.SelectedIndex == 1 ? true : false, this.controller, txtTitle.Text, ts.SecID);
                ces.DeleteExamSectionCtrlEvent += log_DeleteExamSectionCtrlEvent;
                Panel1.Controls.Add(ces);
            }
            RefreshFormControls();
        }
        public void RefreshFormControls()
        {
            txtTitle.Clear();
            cbxSecType.SelectedIndex = 0;
            txtTitle.Focus();
        }
        public bool isValid()
        {
            if (cbxSecType.SelectedIndex < 1)
            {
                MessageBox.Show("Please select sector type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            return true;
        }
        public void log_DeleteExamSectionCtrlEvent(object sender, ExamSectionDeletedEventArgs e)
        {
            //this.controller.testEntity.TestSection.Remove(this.controller.testEntity.TestSection.Where(x => x.SecID == this.SecID).FirstOrDefault());

            var controls = this.Panel1.Controls.Cast<Control>();
            foreach (ctrlExamSection ctrlE in controls.OfType<ctrlExamSection>())
            {
                if (ctrlE.TestSection.SecID == e.ExamSectionID && ctrlE.TestSection.TestID == e.ExamTestID)
                {
                    this.Panel1.Controls.Remove(ctrlE);
                }
            }
        }
        public void RemoveSection(int row)
        {
            //tableLayoutPanel1.Controls.Remove(new ctrlExamSection(), 1, tableLayoutPanel1.RowCount - 1);

            //Panel1.RowStyles.Remove(new RowStyle(SizeType.Percent, 100));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            controller.ResetData();
            if (CloseEditTestCtrlEvent != null)
            {
                CloseEditTestCtrlEvent(sender, new EventArgs());
            }
        }
        public event EventHandler CloseEditTestCtrlEvent;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.controller.PersistTest())
            {
                MessageBox.Show("Test Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An Unhandled Error Occured. Please Try Again or Contact Product Maintainance Support", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CloseEditTestCtrlEvent != null)
            {
                CloseEditTestCtrlEvent(sender, new EventArgs());
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                TestSections ts = new TestSections()
                {
                    TestID = this.controller.GetControllerTestID(),
                    SecID = this.controller.GetControllerSecID(),
                    Title = txtTitle.Text,
                    IsObjective = cbxSecType.SelectedIndex == 1 ? true : false
                    //State=DataTransferObjects.Enums.EntityState.Added
                };
                this.controller.addSection(ts);
                ctrlExamSection ces = new ctrlExamSection(cbxSecType.SelectedIndex == 1 ? true : false, this.controller, txtTitle.Text, ts.SecID);
                ces.DeleteExamSectionCtrlEvent += log_DeleteExamSectionCtrlEvent;
                Panel1.Controls.Add(ces);
            }
            RefreshFormControls();
        }

        private void btnAddNew_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btnAddNew, "It new Sector");
        }

        private void btnAddNew_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(this);
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btnSave, "It Saves the Test");
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(this);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btnClose, "Go Back/ Close");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(this);
        }
    }
}
