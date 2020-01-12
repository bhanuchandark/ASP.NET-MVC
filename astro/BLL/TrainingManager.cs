using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class TrainingManager
    {
        public static List<Student> GetAllStudents()
        {
            List<Student> students = TraningRepository.GetAllData();
            return students;
        }
        public static bool ValidateStudent(string email, string password)
        {
            bool status = false;
            if (TraningRepository.ValidateStudent(email, password))
            {
                status = true;

            }
            return status;
             
        }
        public static bool DeleteStudent(int id)
        {
            bool status = false;
            if(TraningRepository.DeleteStudent(id))
            {
                status = true;
            }
            return status;
        }
        public static bool Update(int id,string name,string email,string city)
        {
            bool status = false;
            if (TraningRepository.Update(id, name, email, city))
            {
                status = true;
            }
            return status;
        }

        public static bool Register(int id, string name, string email, string password, string city)
        {
            bool status = false;
            if (TraningRepository.Register(id, name, email, password, city))
            {
                status = true;
            }
            return status;
        }
    }
}
