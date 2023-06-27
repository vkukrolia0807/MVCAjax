using Newtonsoft.Json;
using Student_Crud_Ajax_Model;
using Student_Crud_Ajax_Model.db;
using Student_Crud_Ajax_Reposiyory.Repository;
using System.Linq;
using System.Web.Mvc;

namespace Student_Crud_Ajax.Controllers
{

    public class StudentController : Controller
    {
        IStudent studentinterface;
        public StudentController(IStudent studentint)
        {
            studentinterface = studentint;
        }


        studentcrudop_vkEntities1 _db = new studentcrudop_vkEntities1();


        //GET: Student
        public ActionResult StudentAdd(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                return View(studentinterface.GetStudentById((int)id));
            }
        }
        [HttpPost]
        public JsonResult StudentAdd(Studentcustom studentcustom)
        {
           
              Student student = new Student
                {
                    fname = studentcustom.FirstName,
                    lname = studentcustom.LastName,
                    address = studentcustom.Address,
                    phoneNumber = studentcustom.PhoneNumber,
                    gender = studentcustom.Gender,
                    Date = studentcustom.Date,
                    Role = (int)studentcustom.UTYPE,
                    isDelete = studentcustom.IsDelete


                };
                _db.Students.Add(student);
                _db.SaveChanges();
                return Json(student, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public JsonResult Updatestudent(Studentcustom student)
        {
            Student studentdb = new Student();
            {
                studentdb.id = student.Id;
                studentdb.fname = student.FirstName;
                studentdb.lname = student.LastName;
                studentdb.address = student.Address;
                studentdb.phoneNumber = student.PhoneNumber;
                studentdb.address = student.Address;
                studentdb.gender = student.Gender;
                studentdb.Date = student.Date;
                studentdb.Role = (int?)student.UTYPE;
                
            };

            _db.sp_Update_students_data(studentdb.id, studentdb.fname, studentdb.lname, studentdb.address, studentdb.phoneNumber, studentdb.gender, studentdb.Date, (int)studentdb.Role);
      
            _db.SaveChanges();
            return Json(studentdb, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetbyID(int ID)
        {
            var student = _db.Students.Where(x => x.id.Equals(ID));
     
            return Json(student, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult AllStudents()
        {
            var student = _db.Students.ToList();
            var students = JsonConvert.SerializeObject(student);
            return Json(students, JsonRequestBehavior.AllowGet);
        }

        public void Delete(int Id)
        {

            _db.Students.Remove(_db.Students.Find(Id));
            _db.SaveChanges();
           
        }
    }
}