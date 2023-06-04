using System;

namespace DataTransferObjects
{
    public class SchoolClass
    {
        public int TID { get; set; }
        public int Id { get; set; }
        public string CName { get; set; }
        public Decimal ClassFee { get; set; }

    }
    public class SystemDate
    {
        public int DateID { get; set; }
        public DateTime CurrDate { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool Status { get; set; }
        public int SchoolID { get; set; }
    }
    public class School
    {
        public int SchoolID { get; set; }
        public string SchoolName { get; set; }
        public string picName { get; 
            set; }
        public string Message { get; 
            set; }
    }
    public class Users
    {
        public Users()
        {
            this.school = new School();
        }
        public School school { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string Role { get; set; }
        public int RoleID { get; set; }
        public bool isAuthenticated { get; set; }
        public string Password { get; set; }
    }
    public class StudentProp
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int Roll { get; set; }
        public int ClassId { get; set; }
        public int Section { get; set; }
        public string Address { get; set; }
        public int City { get; set; }
        public string BloodGroup { get; set; }
        public int AdmissionId { get; set; }
        public string AdmissionDate { get; set; }
        public string PictureName { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
    }
    public class Student
    {
        public Student()
        {
            this.userObj = new Users();
        }
        public int stdID
        {
            get;
            set;
        }
        public int GenderID { get; set; }
        public bool IsCR { get; set; }
        public string Dsc { get; set; }
        public string Contact1 { get; set; }
        public string CNIC { get; set; }
        public string Contact2 { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string Parent { get; set; }
        public string Name { get; set; }
        public string FOccupation { get; set; }
        public string FatherName { get; set; }
        public int Roll { get; set; }
        public string Class { get; set; }
        public int ClassId { get; set; }
        public string Section { get; set; }
        public int SectionId { get; set; }
        public int BloodID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CityId { get; set; }
        public string BloodGroup { get; set; }
        public int AdmissionId { get; set; }
        public string AdmissionNum { get; set; }
        public string AdmissionDate { get; set; }
        public string PictureName { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public int Salary { get; set; }
        public Users userObj { get; set; }
    }
    public class Cities
    {
        public string CityName { get; set; }
        public int Id { get; set; }

    }
    public class ClassFeeCnfg
    {
        public int ClassFeeCnfgID { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public decimal FeeAmount { get; set; }
        public bool Status { get; set; }
    }
    public class Roles
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int LoginId { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
    }
    public class SchoolFee
    {
        public string Fee { get; set; }
        public int Id { get; set; }

    }
    public class FeeCnfg
    {
        public int FeeCnfgID { get; set; }
        public int StudentID { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }
        public string ExtraString { get; set; }
        public string StudentName { get; set; }
    }
    public class FeeMonths
    {
        public string Month { get; set; }
        public int Id { get; set; }
    }
    public class ClassNum
    {
        public string Class { get; set; }
        public int id { get; set; }
    }





}
public class Subject
{
    public int Id { get; set; }
    public int ClassID { get; set; }
    public string SName { get; set; }
}
public class SectionClass
{
    public int classid { get; set; }
    public int Id { get; set; }
    public string SecName { get; set; }
}
public class curriculum
{
    public int ClassId { get; set; }
    public int SectionId { get; set; }
    public int SubjectId { get; set; }
    public string Curriculum { get; set; }
}
public class Attendance
{
    public DateTime date { get; set; }
    public bool status { get; set; }
}