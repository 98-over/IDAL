using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IRemark
    {
        /// <summary>
        /// 插入数据，成功返回1，失败返回0
        /// </summary>
        /// <param name="remark"></param>
        /// <returns></returns>
        int insertRemark(Remark remark);

        /// <summary>
        /// 删除数据，成功返回1，失败返回0
        /// </summary>
        /// <param name="remark"></param>
        /// <returns></returns>
        int deleteRemark(string r_no);

        /// <summary>
        /// 更新数据项，成功返回1，失败返回0
        /// </summary>
        /// <param name="remark"></param>
        /// <returns></returns>
        int updateRemark(Remark remark);

        /// <summary>
        /// 根据r_no获取单条数据，成功返回1，失败返回0
        /// </summary>
        /// <param name="r_no"></param>
        /// <returns></returns>
        DataSet getRemark(string r_no);

        /// <summary>
        /// 查询指定Blog的全部评论,返回结果为DataSet
        /// </summary>
        /// <param name="b_no"></param>
        /// <returns></returns>
        DataSet GetRemarkOfBlog(string b_no);

        /// <summary>
        /// 查询指定Blog下指定数量的评论
        /// </summary>
        /// <param name="b_no"></param>
        /// <param name="r_num"></param>
        /// <returns></returns>
        DataSet GetRemarkOfBlog(string b_no, int r_num);
    }
}
