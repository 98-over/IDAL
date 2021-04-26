using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IBlog
    {
        /// <summary>
        /// 插入数据，成功返回1，失败返回0
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        int insertBlog(Blog blog);
        /// <summary>
        /// 删除数据项，成功返回1，失败返回0
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        int deleteBlog(Blog blog);

        /// <summary>
        /// 更新数据项，成功返回1，失败返回0
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        int updateBlog(Blog blog);

        /// <summary>
        /// 根据b_no获取单条数据，成功返回1，失败返回0
        /// </summary>
        /// <param name="b_no"></param>
        /// <returns></returns>
        DataSet getBlog(string b_no);

        /// <summary>
        /// num指定查询的数量，num为0查询全部结果
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        DataSet GetAllBlog(int num = 0);

        /// <summary>
        /// 点赞
        /// </summary>
        /// <param name="b_no"></param>
        /// <param name="f_id"></param>
        /// <returns></returns>
        int AddFavour(string b_no, string f_id);

        /// <summary>
        /// 取消点赞
        /// </summary>
        /// <param name="b_no"></param>
        /// <param name="f_id"></param>
        /// <returns></returns>
        int DelFavour(string b_no, string f_id);

        /// <summary>
        /// 判断是否点赞
        /// </summary>
        /// <param name="b_no"></param>
        /// <param name="f_id"></param>
        /// <returns></returns>
        bool IsFavour(string b_no, string f_id);
    }
}
