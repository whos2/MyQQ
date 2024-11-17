using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace MyQQ.UC_Controls
{
    public partial class UC_SearchItem : UserControl
    {
        DB_Helper db = new DB_Helper();

        private string nickAndID;
        private int headID;

        public string NickAndID
        {
            get { return nickAndID; }
            set { nickAndID = value; }
        }

        public int HeadID
        {
            get { return headID; }
            set { headID = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }



        public UC_SearchItem()
        {
            InitializeComponent();
            lblNickNameAndID.Text = nickAndID;
        }

        private void UC_SearchItem_Load(object sender, EventArgs e)
        {
            lblNickNameAndID.Text = nickAndID;
            guna2CirclePictureBoxHead.Image = imageListHead.Images[headID];
            //ContextMenuStrip contextMenuStrip = new ContextMenuStrip();//创建一个鼠标右击菜单
            //contextMenuStrip.Items.Add("添加");
            //string str = $"select Name,HeadID from User_Table where ID={id}";
            //SqlDataReader reader = db.GetSQLReader(str);
            //if(reader.Read())
            //{
            //    if(!(reader["HeadID"] is DBNull))
            //    {
            //        guna2CirclePictureBoxHead.Image = imageListHead.Images[Convert.ToInt32(reader["HeadID"])];
            //    }
            //    if (!(reader["Name"] is DBNull))
            //    {
            //        lblNickNameAndID.Text = reader["Name"].ToString() + "(" + id.ToString() + ")";
            //    }
            //}
            //reader.Close();
            //DB_Helper.connection.Close();
        }

        private void 添加好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            string pattern = @"\((\d+)\)";   //正则表达式，匹配括号内的数字
            Match match = Regex.Match(nickAndID, pattern);
            if (match.Success)
            {
                id = Convert.ToInt32(match.Groups[1].Value);   //获取选择的想要添加为好友的用户的id
            }
            if(id != 0)
            {
                string str = $"select HostID,FriendID,Agree from Friend_Table where HostID={PublicClass.loginID} and FriendID={id}";
                SqlDataReader reader = db.GetSQLReader(str);
                if(reader.Read())  //已经添加过好友
                {
                    int agree = Convert.ToInt32(reader["Agree"]);
                    if(agree == 1)  //该用户已经同意我的好友申请
                    {
                        //这种情况跳转到chat界面
                    }
                    else  //该用户还未同意我的好友申请
                    {
                        MessageBox.Show("在此之前已发送添加好友请求，等待对方同意");
                    }
                }
                else  //没有添加过好友
                {
                    MessageBox.Show("已发送添加好友请求，等待对方同意");
                    str = $"insert into Friend_Table values({PublicClass.loginID},{id},0,0)";
                    reader.Close();
                    db.ExecSQLResult(str);
                }
                reader.Close();
                DB_Helper.connection.Close();
            }
        }
    }
}
