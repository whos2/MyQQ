using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQQ.UC_Controls;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        private float x; //当前窗体的宽度
        private float y; //当前窗体的高度
        
        DB_Helper db = new DB_Helper();//创建数据操作类的对象

        string name; //用户的昵称
        int headID;  //用户头像图片的ID
        int flag; //用户在线或者不在线

        public Frm_Main()
        {
            InitializeComponent();

            guna2TextBoxSearch.ForeColor = Color.Gray;

            //将水平的滚动条去掉，只保留垂直滚动条
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.AutoScroll = true;

            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Resize += new System.EventHandler(this.Frm_Main_Resize);
        }

        /// <summary>
        ///从数据库加载主界面的个人信息 
        /// </summary>
        private void LoadPersonalInfo()
        {
            string str = $"select Name,HeadID,Flag from User_Table where ID={PublicClass.loginID}";
            SqlDataReader reader = db.GetSQLReader(str);
            if (reader.Read()) //如果读取到了信息
            {
                name = reader["Name"].ToString();
                if (reader["HeadID"] is DBNull)
                    headID = 1;
                else
                    headID = Convert.ToInt32(reader["HeadID"]);
                if (reader["Flag"] is DBNull)
                    flag = 0;
                else
                    flag = Convert.ToInt32(reader["Flag"]);
            }
            reader.Close(); //关闭读取器
            DB_Helper.connection.Close(); //关闭数据库连接

            //lblNickName.Text = name;
            guna2CirclePictureBoxHead.Image = imageListHead.Images[headID];
            guna2CirclePictureBoxFlag.Image = imageListFlag.Images[flag]; //flag=1在线状态 flag=0离线状态
        }

        //主界面被加载时记录初始状态
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            x = this.Width;
            y = this.Height;
            SetTag(this);//将窗体的初始状态记录下来

            LoadPersonalInfo();
        }

        //将获取到的控件信息存储到控件的tag属性中
        private void SetTag(Control cons)//传入窗体
        {
            foreach (Control con in cons.Controls)//获取窗体的控件
            {
                //将每个控件的信息存到控件的Tag属性中 宽度 高度 左边距 顶边距 字体大小
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)//如果控件还有子控件，递归
                {
                    SetTag(con);
                }
            }
        }

        //设置控件大小
        private void SetControls(float ratioX, float ratioY, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的属性
            foreach (Control con in cons.Controls)
            {
                try
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                    float a = System.Convert.ToSingle(mytag[0]) * ratioX;//宽度
                    con.Width = (int)a;
                    a = System.Convert.ToSingle(mytag[1]) * ratioY;//高度
                    con.Height = (int)a;
                    a = System.Convert.ToSingle(mytag[2]) * ratioX;//左边距
                    con.Left = (int)a;
                    a = System.Convert.ToSingle(mytag[3]) * ratioY;//顶边距
                    con.Top = (int)a;
                    Single fontSize = System.Convert.ToSingle(mytag[4]) * ratioX;//字体大小
                    con.Font = new Font(con.Font.Name, fontSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)//递归设置控件的子控件
                    {
                        SetControls(ratioX, ratioY, con);
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(con.Name);
                }
            }
        }

        // 当主界面的大小改变时
        private void Frm_Main_Resize(object sender, EventArgs e)
        {
            float ratioX = this.Width / x;
            float ratioY = this.Height / y;
            SetControls(ratioX, ratioY, this);
            PublicClass.SetWindowRegion(this, 10);
            PublicClass.SetClassLong(this.Handle, PublicClass.GCL_STYLE, PublicClass.GetClassLong(this.Handle, PublicClass.GCL_STYLE) | PublicClass.CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }

        // 移动主界面在屏幕中的位置
        private void panelTopFrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        // 最小化主界面
        private void guna2BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // 最大化主界面以及正常化主界面
        private void guna2ButtonMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        // 关闭主界面
        private void guna2BtnCancel_Click(object sender, EventArgs e)
        {
            string str = $"update User_Table set Flag=0 where ID={PublicClass.loginID}"; //设置为离线状态
            db.ExecSQLResult(str);
            this.Dispose();
            Frm_Login login = new Frm_Login();
            login.ShowDialog();
        }

        private void guna2CirclePictureBoxHead_Click(object sender, EventArgs e)
        {
            Point point = guna2CirclePictureBoxHead.PointToScreen(new Point(0, 0)); //头像控件相对于屏幕的坐标
            int headX = point.X; //头像控件的横坐标
            int headY = point.Y; //头像控件的纵坐标

            int startX = headX + guna2CirclePictureBoxHead.Width+5; //子窗体位置的X坐标
            int startY = headY;// + guna2CirclePictureBoxHead.Height; //子窗体位置的Y坐标
            Frm_PersonalInfo pi = new Frm_PersonalInfo();
            pi.Location = new System.Drawing.Point(startX,startY); //子窗体的位置
            pi.fm = this; //将pi对象的fm引用变量指向本窗体的实例
            pi.Show();
        }

        public void UpdateHead(int headID)
        {
            guna2CirclePictureBoxHead.Image = imageListHead.Images[headID];
            //MessageBox.Show("主界面的图片更新了");
        }

        /// <summary>
        /// 实现的效果是：当点击改窗体时，弹出来的个人信息窗体会消失
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Main_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left) 
            {
                Application.OpenForms["Frm_PersonalInfo"].Dispose(); //将该小窗体销毁
            }
        }

        //根据用户输入的昵称或者QQ号从数据库中找匹配信息
        private void SearchCustomFromDB()
        {
            //flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.Controls.Clear();
            string mes = guna2TextBoxSearch.Text;    //搜索框中的文本
            string str = $"select ID,Name,HeadID from User_Table where ID like '%{mes}%' or Name like '%{mes}%'";

            //UserControl uc = new UC_SearchList();  //创建引用变量，该变量引用自定义用户控件，用来显示搜索框搜索出来的结果
            //flowLayoutPanel.Controls.Add(uc); //将控件添加到显示列表

            if(mes!="")
            {
                SqlDataReader reader = db.GetSQLReader(str); //创建阅读器对象
                try
                {
                    while (reader.Read())
                    {
                        UC_SearchItem uc = new UC_SearchItem(); //创建搜索结果对象
                        if (!(reader["Name"] is DBNull) || !(reader["ID"] is DBNull))
                        {
                            uc.NickAndID = reader["Name"].ToString()+"("+reader["ID"].ToString()+")";
                        }

                        flowLayoutPanel.Controls.Add(uc);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    reader.Close();
                    DB_Helper.connection.Close();
                    //flowLayoutPanel.Controls.Clear();
                }
            }
        }

        private void guna2TextBoxSearch_Click(object sender, EventArgs e)
        {
            if(guna2TextBoxSearch.Text=="搜索")
            {
                guna2TextBoxSearch.Text = "";
                guna2TextBoxSearch.ForeColor = Color.Black;
            }
        }

        private void guna2TextBoxSearch_Leave(object sender, EventArgs e)
        {
            guna2TextBoxSearch.Text = "搜索";
            guna2TextBoxSearch.ForeColor = Color.Gray;
        }

        private void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchCustomFromDB();
        }
    }
}
