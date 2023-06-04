using DAL;
using DataTransferObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentWindowsApplication
{
    public class ExamTestManager
    {
        public static TestEdit ControllertestEntity;
        public static int ControllerSecID = 0;
        public static int ControllerSrNo = 0;
        public static int ControllerTestID;
        public List<QuestionModel> QuesListEntity;
        private ExamClass Srv;
        public void InitializeTestID(int _testid)
        {
            ControllerTestID = _testid;
            ControllertestEntity.TestID = ControllerTestID;
        }
        public void ResetData()
        {
            ControllertestEntity = null; ControllerSecID = 0; ControllerSrNo = 0; ControllerTestID = 0; QuesListEntity = null;
        }
        public bool CheckIfTestExists(int _testid)
        {
            List<TestSections> TestSectionList = new List<TestSections>();
            TestSectionList = Srv.GetTestSectionsByTestID(_testid);
            if (TestSectionList != null && TestSectionList.Count > 0)
            {
                foreach (TestSections t in TestSectionList)
                {
                    var res = Srv.GetTestQuestionModelsByTestSectionID(t.TestSectionID);
                    if (res != null && res.Count > 0)
                    {
                        t.Questions = res;
                        t.SrNoCount = res.Max(x => x.QuesSrNo) + 1;
                    }
                }
                ControllertestEntity.TestSection = TestSectionList;
                return true;
            }
            else
                return false;

        }
        public void CopyTestSectionWithoutQuestions(ref TestSections t, TestSections s)
        {
            t.TestSectionID = s.TestSectionID;
            t.TestID = s.TestID;
            t.SecID = s.SecID;
            t.TotalMarks = s.TotalMarks;
            t.Title = s.Title;
            t.IsObjective = s.IsObjective;
            t.Questions = new List<QuestionModel>();
        }
        public TestEdit GetControllerTestEditEntity()
        {
            TestEdit response = new TestEdit();
            TestSections tSec = new TestSections();
            response.TestID = ControllertestEntity.TestID;
            foreach (var sec in ControllertestEntity.TestSection)
            {
                if (sec.State != EntityState.Deleted)
                {
                    CopyTestSectionWithoutQuestions(ref tSec, sec);
                    //tSec = sec;
                    //tSec.Questions = new List<QuestionModel>();
                    foreach (var q in sec.Questions)
                    {
                        if (q.State != EntityState.Deleted)
                        {
                            tSec.Questions.Add(q);
                        }
                    }
                    response.TestSection.Add(tSec);
                    tSec = new TestSections();
                }
            }
            return response;
        }
        public int GetControllerTestID()
        {
            return ControllerTestID;
        }
        public void SetControllerSecID(int _secid)
        {
            ControllerSecID = _secid;
        }
        public void IncControllerSecID()
        {
            ControllerSecID++;
        }
        public int GetControllerSecID()
        {
            return ControllerSecID;
        }
        public void SetControllerSrNo(int _srno)
        {
            ControllerSrNo = _srno;
        }
        public void IncControllerSrNo()
        {
            ControllerSrNo++;
        }
        public int GetControllerSrNo()
        {
            return ControllerSrNo;
        }
        public int GetSrNoBySecID(int secid)
        {
            var sec = ControllertestEntity.TestSection.Where(x => x.SecID == secid).FirstOrDefault();
            return sec.SrNoCount;
        }
        public ExamTestManager()
        {
            ControllerSecID = 1;
            ControllerSrNo = 1;
            this.QuesListEntity = new List<QuestionModel>();
            ControllertestEntity = new TestEdit();
            this.Srv = new ExamClass();
        }
        public void addSection(TestSections ts)
        {
            ts.State = EntityState.Added;
            ControllertestEntity.TestSection.Add(ts);
            ControllerSecID++;
        }
        public void RemoveSection(TestSections ts)
        {
            ts.State = EntityState.Deleted;
            ControllertestEntity.TestSection.Remove(ControllertestEntity.TestSection.Where(x => x.SecID == ts.SecID).FirstOrDefault());
        }
        public void addQuestion(QuestionModel q, int secid)
        {
            //q.QuesSrNo = ControllerSrNo;
            q.State = EntityState.Added;
            ControllertestEntity.TestSection.Where(x => x.SecID == secid).FirstOrDefault().Questions.Add(q);
            var sec = ControllertestEntity.TestSection.Where(x => x.SecID == secid).FirstOrDefault();
            sec.SrNoCount++;
            //ControllerSrNo++;
        }
        public void UpdateQuestion(QuestionModel q, int secid)
        {
            //q.QuesSrNo = ControllerSrNo;
            if (q.IsPersisted)
            {
                QuestionModel ques = ControllertestEntity.TestSection.Where(x => x.TestSectionID == secid).FirstOrDefault().Questions.Where(y => y.QuesID == q.QuesID).FirstOrDefault();
                ques = q;
            }
            else
            {
                QuestionModel ques = ControllertestEntity.TestSection.Where(x => x.SecID == secid).FirstOrDefault().Questions.Where(y => y.QuesSrNo == q.QuesSrNo).FirstOrDefault();
                ques = q;
            }
            //ControllerSrNo++;
        }
        public void RemoveQuestion(QuestionModel q, int secid)
        {
            if (q.IsPersisted)
            {
                ControllertestEntity.TestSection.Where(x => x.TestSectionID == secid).FirstOrDefault().Questions.Remove(q);
            }
            else
            {
                ControllertestEntity.TestSection.Where(x => x.SecID == secid).FirstOrDefault().Questions.Remove(q);
            }
        }

        public bool PersistTest()
        {
            try
            {
                //delete all sections
                Srv.DeleteTestSection(ControllertestEntity.TestID);
                //Save Test Entity
                //foreachsections - insert section - foreach questions - insert questions
                foreach (TestSections ts in ControllertestEntity.TestSection)
                {
                    int res = 0;
                    //if (ts.State == EntityState.Added)
                    //{
                    res = Srv.InsertTestSection(ts);
                    ts.TestSectionID = res;
                    //}
                    //else
                    //if (ts.State == EntityState.Modified)
                    //{
                    //    //Update Section
                    //    res = Srv.UpdateTestSection(ts);
                    //}
                    //else
                    //if (ts.State == EntityState.Deleted)
                    //{
                    //    //Delete Section
                    //res = Srv.DeleteTestSection(ts);
                    //    continue;
                    //}
                    if (res > 0)
                    {
                        foreach (QuestionModel q in ts.Questions)
                        {
                            int res2 = 0;
                            //if (q.State == EntityState.Added)
                            //{
                            q.SecID = res;
                            if (!Srv.InsertTestQuestion(q))
                            {
                                UndoPersist();
                                return false;
                            }
                            //Insert Question
                            //res = Srv.InsertTestSection(ts);

                            //}

                            //else if (ts.State == EntityState.Modified)
                            //{                                
                            //    if (!Srv.UpdateTestQuestion(q))
                            //    {
                            //        UndoPersist();
                            //        return false;
                            //    }
                            //    //Update Question
                            //    //res = Srv.InsertTestSection(ts);
                            //}
                            //else if (ts.State == EntityState.Deleted)
                            //{
                            //    if (!Srv.DeleteTestQuestion(q))
                            //    {
                            //        UndoPersist();
                            //        return false;
                            //    }
                            //    //Delete Question
                            //    res = Srv.InsertTestSection(ts);
                            //}
                        }
                    }
                    else
                    {
                        UndoPersist();
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                UndoPersist();
                return false;
            }
        }
        public void UndoPersist()
        {
            //foreach section in testEntity - delete * from Section where testsectionid = secid then delete all from sections where testid = testentity.testid

        }
    }

    public class QuestionModelAddedEventArgs : EventArgs
    {
        public QuestionModel Question { get; set; }
    }
}
