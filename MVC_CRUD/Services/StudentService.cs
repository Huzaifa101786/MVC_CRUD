using MVC_CRUD.Models;

namespace MVC_CRUD.Services
{
    public static class StudentService
    {
        private static List<StudentModel> list = new List<StudentModel>();

        public static List<StudentModel> GetNameEmail()
        {
            return list;
        }

        public static void SetNameEmail(StudentModel model)
        {
            list.Add(model);            
        }

        public static List<StudentModel> DeleteUser(string name)
        {
            foreach(StudentModel student in list) 
            { 
                if(student.Name == name)
                {
                    list.Remove(student);
                    break;
                }
            }

            return list;
        }

        public static List<StudentModel> UpdateUser(StudentModel model)
        {
            string OldName = model.Name;
            foreach (StudentModel student in list)
            {
                if (student.Name == OldName)
                {
                    student.Name = model.Name;
                    student.Email = model.Email;
                    break;
                }
            }

            return list;
        }
    }
    
}
