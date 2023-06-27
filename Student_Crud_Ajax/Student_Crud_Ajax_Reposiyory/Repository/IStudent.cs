using Student_Crud_Ajax_Model;
using Student_Crud_Ajax_Model.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Crud_Ajax_Reposiyory.Repository
{
   public interface IStudent
    {

        bool GetStudent(Studentcustom student);

        Student GetStudentById(int id);


    }
}
