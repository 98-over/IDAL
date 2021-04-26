using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IUser_Student
    {
        int InsertStudent(User_Student s);
        int UpdateStudent(User_Student s);
        int DeleteStudent(string id);
        DataSet GetStudent(string id);
        DataSet GetAllStudent();

    }
}
