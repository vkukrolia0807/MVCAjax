using Student_Crud_Ajax_Helpers.Helper;
using Student_Crud_Ajax_Model;
using Student_Crud_Ajax_Model.db;
using Student_Crud_Ajax_Reposiyory.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Crud_Ajax_Reposiyory.Services
{
    public class Studentservice : IStudent
    {
        studentcrudop_vkEntities1 _db = new studentcrudop_vkEntities1();
        StudentHelper studenthelper = new StudentHelper();
        public bool GetStudent(Studentcustom student)
        {
            try
            {
                if (student.Id != 0)
                {
                    _db.update_student(student.Id, student.FirstName, student.LastName, student.Address, student.PhoneNumber, student.Gender, student.Date, Convert.ToInt32(student.UTYPE), student.IsDelete);
                    _db.SaveChanges();
                    return true;
                }
                else
                {
                    var studentobj = studenthelper.Converttodb(student);
                    _db.Students.Add(studentobj);
                    _db.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw (e);
            }
            
        }

        public Student GetStudentById(int id)
        {
            return _db.Students.Where(x => x.id == id).FirstOrDefault();
        }


    }
}
