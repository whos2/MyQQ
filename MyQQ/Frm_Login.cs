using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MyQQ.UC_Controls;

namespace MyQQ
{
    public partial class Frm_Login : Form
    {
        DB_Helper db = new DB_Helper(); //创建数据库操作对象
        public Frm_Login()
        {
            InitializeComponent();

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.BackColor = Color.FromArgb(253, 238, 249);

            guna2QQIDBtnDel.Visible = false;
            guna2QQPasswordBtnDel.Visible = false;
        }
        
        //最小化窗体
        private void guna2BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //关闭程序
        private void guna2BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //注册
        private void guna2BtnRegist_Click(object sender, EventArgs e)
        {
            Frm_Regist regist = new Frm_Regist();
            regist.Show();
            this.Visible = false;
        }

        //登录
        private void guna2BtnLogin_Click(object sender, EventArgs e)
        {
            string str = $"select count(*) from table_User where ID={int.Parse(txtID.Text)} and Pwd={txtPassword.Text}";
            int num = db.ExecSQLResult(str);
            if (num == 1)
                MessageBox.Show("查询到了");
            else
                MessageBox.Show("没有查询到");
        }
        
        private void guna2BtnMin_MouseHover(object sender, EventArgs e)
        {
            string msg = "最小化";
            PublicClass.mouseHover(guna2BtnMin, msg);
        }

        private void guna2BtnCancel_MouseHover(object sender, EventArgs e)
        {
            string msg = "关闭";
            PublicClass.mouseHover(guna2BtnCancel, msg);
        }

        private void Frm_Login_Resize(object sender, EventArgs e)
        {
            PublicClass.SetWindowRegion(this, 10);
            PublicClass.SetClassLong(this.Handle, PublicClass.GCL_STYLE, PublicClass.GetClassLong(this.Handle, PublicClass.GCL_STYLE) | PublicClass.CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }

        private void panelTopFrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        string txtIDInitMessage = "输入QQ号";
        string txtPasswordInitMessage = "输入QQ密码";
        private void txtID_Click(object sender, EventArgs e)
        {
            guna2QQPasswordBtnDel.Visible = false;
            PublicClass.txtBoxSelected(txtID, guna2QQIDBtnDel, txtIDInitMessage);
        }
        
        private void txtID_Leave(object sender, EventArgs e)
        {
            //if (txtID.Text != string.Empty)
                PublicClass.txtBoxDisSelected(txtID, guna2QQIDBtnDel, txtIDInitMessage);
            //if(guna2QQIDBtnDel.Visible==false)
            //    txtID.Text = txtIDInitMessage;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            guna2QQIDBtnDel.Visible = false;
            PublicClass.txtBoxSelected(txtPassword, guna2QQPasswordBtnDel,txtPasswordInitMessage);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            //if (txtPassword.Text != string.Empty)
                PublicClass.txtBoxDisSelected(txtPassword, guna2QQPasswordBtnDel, txtPasswordInitMessage);
            //if(guna2QQPasswordBtnDel.Visible==false)
            //    txtPassword.Text = txtPasswordInitMessage;
        }

        private void Frm_Login_MouseClick(object sender, MouseEventArgs e)
        {
            guna2QQIDBtnDel.Visible = false;
            guna2QQPasswordBtnDel.Visible = false;
            this.ActiveControl = null; //将窗体内的控件全部设置为未激活状态
        }

        private void guna2QQIDBtnDel_Click(object sender, EventArgs e)
        {
            PublicClass.btnDelPressed(txtID, guna2QQIDBtnDel, txtIDInitMessage);

        }

        private void guna2QQPasswordBtnDel_Click(object sender, EventArgs e)
        {
            PublicClass.btnDelPressed(txtPassword, guna2QQPasswordBtnDel, txtPasswordInitMessage);
        }
    }
}
