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

namespace MyQQ
{
    public partial class Frm_PersonalInfo : Form
    {
        DB_Helper db = new DB_Helper(); //新建操作数据库的对象

        public Frm_Main fm;

        private Frm_EditPersonalInfo epi = null;

        string name;
        string sex;
        int likeAmount;
        int flag;
        int headID;

        public Frm_PersonalInfo()
        {
            this.Deactivate += new EventHandler(this.Frm_PersonalInfo_Deactivate);

            InitializeComponent();
        }

        //显示个人信息
        public void ShowPersonalInfo()
        {
            string str = $"select Name,Sex,ID,Flag,LikeAmount,HeadID from User_Table where ID={PublicClass.loginID}";
            SqlDataReader reader = db.GetSQLReader(str);
            if(reader.Read())
            {
                if(!(reader["Sex"] is DBNull))
                {
                    sex = reader["Sex"].ToString();
                }
                if(!(reader["LikeAmount"] is DBNull))
                {
                    likeAmount = Convert.ToInt32(reader["LikeAmount"]);
                }
                if (!(reader["Flag"] is DBNull))
                {
                    flag = Convert.ToInt32(reader["Flag"]);
                }
                if(!(reader["HeadID"] is DBNull))
                {
                    headID = Convert.ToInt32(reader["HeadID"]);
                }
                if(!(reader["Name"] is DBNull))
                {
                    lblNickName.Text = reader["Name"].ToString();
                }
                if(!(reader["headID"] is DBNull))
                {
                    guna2CirclePictureBoxHead.Image = imageListHead.Images[Convert.ToInt32(reader["headID"])];
                }
            }

            reader.Close();
            DB_Helper.connection.Close();
            
            lblQQID.Text = PublicClass.loginID.ToString();
            try
            {
                if (sex == "男")
                    guna2CirclePictureBoxSex.Image = imageListSex.Images[0];
                else if (sex == "女")
                    guna2CirclePictureBoxSex.Image = imageListSex.Images[1];
                lblLikeAmount.Text = likeAmount.ToString();
                if (flag == 1) //在线
                {
                    guna2CirclePictureBoxFlag.Image = imageListFlag.Images[0];
                    lblFlag.Text = "在线";
                }
                else if (flag == 0) //不在线
                {
                    guna2CirclePictureBoxFlag.Image = imageListFlag.Images[1];
                    lblFlag.Text = "不在线";
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        //界面处于非激活状态，界面消失
        //实现的功能：当鼠标点击界面以外的区域时，界面关闭
        private void Frm_PersonalInfo_Deactivate(object sender, EventArgs e)
        {
            string str = $"update User_Table set LikeAmount='{likeAmount}' where ID={PublicClass.loginID}";
            db.ExecSQLResult(str);
            this.Hide();
        }

        private void guna2ButtonEditPersonalInfo_Click(object sender, EventArgs e)
        {
            //if(epi==null || epi.IsDisposed) //如果窗体不存在，创建一个窗体
            //{
            //    Frm_EditPersonalInfo epi = new Frm_EditPersonalInfo();
            //    epi.fpi = this; //新建信息编辑窗体，该窗体的fpi变量引用本窗体的实例
            //    epi.Show();
            //}
            //else
            //{
            //    epi.Activate(); //否则，将窗体激活，避免多次点击按钮创建多个窗体的情况
            //    epi.WindowState = FormWindowState.Normal;
            //    MessageBox.Show("窗体已经存在，激活");
            //}

            foreach (Form form in Application.OpenForms)
            {
                if(form is Frm_EditPersonalInfo)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Normal;
                    form.TopMost = true;
                    return;
                }
            }
            Frm_EditPersonalInfo epi = new Frm_EditPersonalInfo();
            epi.fpi = this; //新建信息编辑窗体，该窗体的fpi变量引用本窗体的实例
            epi.Show();

            //foreach (Form form in Application.OpenForms)
            //{
            //    if(!(form is Frm_EditPersonalInfo))
            //    {
            //        form.BackColor = Color.Gray;
            //    }
            //}
        }

        public void UpdateHead(int id)
        {
            //headID = id;
            guna2CirclePictureBoxHead.Image = imageListHead.Images[id];

            fm.UpdateHead(id);
        }

        private void Frm_PersonalInfo_Load(object sender, EventArgs e)
        {
            ShowPersonalInfo();

            Point nickName2ScreenPos = lblNickName.PointToScreen(new Point(0, 0)); //昵称控件相对于屏幕的坐标
            int nameX = nickName2ScreenPos.X; //昵称控件相对于屏幕的横坐标
            int nameY = nickName2ScreenPos.Y; //昵称控件相对于屏幕的纵坐标
            int startX = nameX + lblNickName.Width - 5; //性别控件相对于屏幕位置的X坐标
            int startY = nameY-15; //性别控件相对于屏幕位置的Y坐标

            Point sex2ScreenPos = new Point(startX, startY);
            Point sex2FormPos = this.PointToClient(sex2ScreenPos);

            guna2CirclePictureBoxSex.Location = sex2FormPos;

            //MessageBox.Show($"{startX},{startY}");

            string str = $"select LikeAmount from User_Table where ID={PublicClass.loginID}";  //初始化点赞数
            SqlDataReader reader = db.GetSQLReader(str);
            if(reader.Read())
            {
                if(!(reader["LikeAmount"] is DBNull))
                {
                    likeAmount = Convert.ToInt32(reader["LikeAmount"]);
                }
            }
            reader.Close();
            DB_Helper.connection.Close();
        }

        //点赞
        private void btnLike_Click(object sender, EventArgs e)
        {
            likeAmount += 1;
            lblLikeAmount.Text = likeAmount.ToString();
        }

        private void Frm_PersonalInfo_Resize(object sender, EventArgs e)
        {
            PublicClass.SetWindowRegion(this, 10);
            PublicClass.SetClassLong(this.Handle, PublicClass.GCL_STYLE, PublicClass.GetClassLong(this.Handle, PublicClass.GCL_STYLE) | PublicClass.CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }
    }
}
