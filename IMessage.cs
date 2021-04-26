using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IMessage
    {
        int InsertMessage(Message meg);

        DataSet GetMessageOfUser(string id1,string id2,int num=0);
    }
}
