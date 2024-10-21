using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQ
{
    class DB_Helper
    {
        static string conStr = @"Data Source=.;Initial Catalog=MyQQ;Integrated Security=True";
        SqlConnection connection = new SqlConnection(conStr);

        /// <summary>
        /// 执行sql语句，并返回查询到的结果的条数
        /// </summary>
        /// <param name="command">sql语句</param>
        /// <returns>查询到的记录数</returns>
        public int ExecSQLResult(string command)
        {
            SqlCommand com = new SqlCommand(command, connection); //创建sql命令对象
            if (connection.State == ConnectionState.Closed) //判断数据库连接是否关闭
                connection.Open(); //打开数据库连接
            int num = Convert.ToInt32(com.ExecuteScalar());  //执行sql命令
            connection.Close();  //关闭数据库连接
            return num;  //返回查询到的记录数
        }

        /// <summary>
        /// 执行sql命令，将结果填充到DataSet
        /// </summary>
        /// <param name="command">sql命令</param>
        /// <returns>填充后的DataSet</returns>
        public DataSet GetDataSet(string command)
        {
            //if (connection.State == ConnectionState.Closed)
            //    connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command, connection); //创建SqlDataAdapter对象，是数据源和DataSet之间的桥梁
            DataSet ds = new DataSet();  //创建数据集合
            da.Fill(ds); //将结果填充到数据集，fill方法会自动打开和关闭数据库连接
            //connection.Close();
            return ds;  //返回填充后的数据集
        }

        /// <summary>
        /// 执行sql查询命令，返回查询结果
        /// </summary>
        /// <param name="command">sql命令</param>
        /// <returns>读取到的结果</returns>
        public SqlDataReader GetSQLReader(string command)
        {
            SqlCommand com = new SqlCommand(command, connection); //创建sql命令对象
            if (connection.State == ConnectionState.Closed) //判断数据库连接是否关闭
                connection.Open();  //打开数据库连接
            SqlDataReader dr = com.ExecuteReader();  //执行查询操作
            connection.Close();  //关闭数据库连接
            return dr;  //返回查询结果
        }
    }
}
