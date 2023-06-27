using Student_Crud_Ajax_Model;
using Student_Crud_Ajax_Model.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Crud_Ajax_Helpers.Helper
{
  public  class StudentHelper
    {
        studentcrudop_vkEntities1 _db = new studentcrudop_vkEntities1();
        public Student Converttodb(Studentcustom student)
        {
            Student studentcustom = new Student();
            studentcustom.fname = student.FirstName;
            studentcustom.lname = student.LastName;
            studentcustom.address = student.Address;
            studentcustom.phoneNumber = (int)student.PhoneNumber;
            studentcustom.gender = student.Gender;
            studentcustom.Date = student.Date;
            studentcustom.Role = Convert.ToInt32(student.UTYPE);
            studentcustom.isDelete = student.IsDelete;
            return studentcustom;

        }
    //    public Student Converttocust(Student studentdb)
    //    {
    //        Studentcustom student = new Studentcustom();
    //        {
    //            student.FirstName = studentdb.fname;
    //            student.LastName = studentdb.lname;
    //            student.Address = studentdb.address;
    //            student.PhoneNumber = (int)studentdb.phoneNumber;
    //            student.Gender = studentdb.gender;
    //            student.Date = (DateTime)studentdb.Date;
    //            student.UTYPE = (Student_Crud_Ajax_Model.models.RoleType)studentdb.Role;
    //            return student;
    //        }
    //}
}
}
