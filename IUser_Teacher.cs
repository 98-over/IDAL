using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IUser_Teacher
    {
        int InsertTeacher(User_Teacher t);
        int UpdateTeacher(User_Teacher t);
        int DeleteTeacher(string id);
        DataSet GetTeacher(string id);
        DataSet GetAllTeacher();
    }
}
