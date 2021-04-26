using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IReply
    {
        /// <summary>
        /// 添加回复
        /// </summary>
        /// <param name="reply"></param>
        /// <returns></returns>
        int InsertReply(Reply reply);

        /// <summary>
        /// 删除回复
        /// </summary>
        /// <param name="rp_no"></param>
        /// <returns></returns>
        int DeleteReply(string rp_no);

        /// <summary>
        /// 获取某条评论下的全部回复
        /// </summary>
        /// <param name="r_no"></param>
        /// <returns></returns>
        DataSet GetReplyOfRemark(string r_no);

        /// <summary>
        /// 获取某条评论下指定数量的回复
        /// </summary>
        /// <param name="r_no"></param>
        /// <param name="rp_num"></param>
        /// <returns></returns>
        DataSet GetReplyOfRemark(string r_no, int rp_num);
    }
}
