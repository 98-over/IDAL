using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IUser_Manager 
    {
        int InsertManager(User_Manager m);
        int UpdateManager(User_Manager m);
        int DeleteManager(string id);
        DataSet GetManager(string id);
        DataSet GetAllManager();
    }
}
