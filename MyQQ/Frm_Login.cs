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
            guna2BtnLogin.Enabled = false;
            txtID.TabIndex = 0;
            txtPassword.TabIndex = 1;
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
            this.Hide();
            regist.ShowDialog();
        }

        /// <summary>
        /// 验证输入值是否合法
        /// </summary>
        /// <returns>合法返回值true，不合法返回值false</returns>
        private bool ValidateInput()
        {
            //if (txtID.Text == "")
            //{
            //    MessageBox.Show("请输入QQ号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}
            //else if (long.TryParse(txtID.Text, out long a) == false && txtID.Text != txtIDInitMessage)
            //{
            //    MessageBox.Show("输入QQ号只能包含数字", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}
            if (long.TryParse(txtID.Text, out long a))
            {
                if (a > 2147483647)
                {
                    MessageBox.Show("输入QQ号过长", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            if(txtID.Text==txtIDInitMessage)
            {
                return false;
            }
            //else if (txtPassword.Text == "")
            //{
            //    MessageBox.Show("请输入QQ密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}

            guna2BtnLogin.Enabled = false;
            if (txtID.Text!=txtIDInitMessage&&txtPassword.Text!=txtPasswordInitMessage)
            {
                guna2BtnLogin.Enabled = true;
            }
            return true;
        }

        //登录
        private void guna2BtnLogin_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                string str = $"select count(*) from User_Table where ID={int.Parse(txtID.Text)} and Pwd='{txtPassword.Text}'";
                PublicClass.loginID = int.Parse(txtID.Text);
                int num = db.ExecSQLResult(str);
                if (num == 1)
                {
                    if(cbRememberPwd.Checked)
                    {
                        str = $"update User_Table set RememberPwd=1,Flag=1 where ID={PublicClass.loginID}"; //设置为在线状态
                        db.ExecSQLResult(str);
                    }
                    else
                    {
                        str = $"update User_Table set RememberPwd=0,Flag=1 where ID={PublicClass.loginID}";
                        db.ExecSQLResult(str);
                    }

                    if(cbAutoLogin.Checked)
                    {
                        str = $"update User_Table set AutoLogin=1,Flag=1 where ID={PublicClass.loginID}";
                        db.ExecSQLResult(str);
                    }

                    str = $"select HeadID from User_Table where ID={PublicClass.loginID}";
                    SqlDataReader reader = db.GetSQLReader(str);
                    if(reader.Read())
                    {
                        if(!(reader["HeadID"] is DBNull))
                        {
                            guna2CirclePictureBoxHead.Image = imageListHead.Images[Convert.ToInt32(reader["HeadID"])];
                            guna2CirclePictureBoxHead.Refresh();
                        }
                    }
                    reader.Close();
                    DB_Helper.connection.Close();

                    //DateTime nowTime = DateTime.Now;
                    //int waitTime = 1;
                    //int interval = 0;
                    //while (interval < waitTime)
                    //{
                    //    TimeSpan spand = DateTime.Now - nowTime;
                    //    interval = spand.Seconds;
                    //}

                    //UC_Logining logining = new UC_Logining();
                    //logining.Show();
                    //Form f1 = new Form();
                    //f1.Show();
                    //f1.TopMost = true;
                    //Label label = new Label();
                    //label.Text = "登录中......";
                    //label.BackColor = Color.White;
                    //label.Size = new Size(1000, 200);
                    //label.Location = new Point((f1.Width - label.Width) / 2, (f1.Height - label.Height) / 2);
                    //f1.Controls.Add(label);
                    //f1.Size = new Size(label.Width + 20, label.Height + 20);
                    //f1.StartPosition = FormStartPosition.CenterScreen;

                    System.Threading.Thread.Sleep(1000);  //延时1s，显示图片替换效果
                    //f1.Dispose();
                    this.Hide();
                    //logining.Dispose();
                    Frm_Main m = new Frm_Main();
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("您输入的QQ号或QQ密码有误，请重新输入", "登录信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //鼠标悬停时的文本提示效果
        private void guna2BtnMin_MouseHover(object sender, EventArgs e)
        {
            string msg = "最小化";
            PublicClass.mouseHover(guna2BtnMin, msg);
        }

        //鼠标悬停时的文本提示效果
        private void guna2BtnCancel_MouseHover(object sender, EventArgs e)
        {
            string msg = "关闭";
            PublicClass.mouseHover(guna2BtnCancel, msg);
        }

        //设置窗体圆角和窗体边缘阴影
        private void Frm_Login_Resize(object sender, EventArgs e)
        {
            PublicClass.SetWindowRegion(this, 10);
            PublicClass.SetClassLong(this.Handle, PublicClass.GCL_STYLE, PublicClass.GetClassLong(this.Handle, PublicClass.GCL_STYLE) | PublicClass.CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }

        //设置鼠标移动窗体效果
        private void panelTopFrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        string txtIDInitMessage = "输入QQ号";
        string txtPasswordInitMessage = "输入QQ密码";

        //选中txtID文本框
        private void txtID_Click(object sender, EventArgs e)
        {
            guna2QQPasswordBtnDel.Visible = false;
            PublicClass.txtBoxSelected(txtID, guna2QQIDBtnDel, txtIDInitMessage);
        }
        
        //离开txtID文本框
        private void txtID_Leave(object sender, EventArgs e)
        {
            //if (txtID.Text != string.Empty)
            PublicClass.txtBoxDisSelected(txtID, guna2QQIDBtnDel, txtIDInitMessage);
            //if(guna2QQIDBtnDel.Visible==false)
            //    txtID.Text = txtIDInitMessage;
        }

        //点击txtPassword文本框
        private void txtPassword_Click(object sender, EventArgs e)
        {
            guna2QQIDBtnDel.Visible = false;
            PublicClass.txtBoxSelected(txtPassword, guna2QQPasswordBtnDel,txtPasswordInitMessage);
        }

        //离开txtPassword文本框
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            //if (txtPassword.Text != string.Empty)
                PublicClass.txtBoxDisSelected(txtPassword, guna2QQPasswordBtnDel, txtPasswordInitMessage);
            //if(guna2QQPasswordBtnDel.Visible==false)
            //    txtPassword.Text = txtPasswordInitMessage;
        }

        //鼠标点击窗体空白区域
        private void Frm_Login_MouseClick(object sender, MouseEventArgs e)
        {
            guna2QQIDBtnDel.Visible = false;
            guna2QQPasswordBtnDel.Visible = false;
            this.ActiveControl = null; //将窗体内的控件全部设置为未激活状态
        }

        //点击IDBtnDel按钮
        private void guna2QQIDBtnDel_Click(object sender, EventArgs e)
        {
            PublicClass.btnDelPressed(txtID, guna2QQIDBtnDel, txtIDInitMessage);
        }

        //点击PasswowdBtnDel按钮
        private void guna2QQPasswordBtnDel_Click(object sender, EventArgs e)
        {
            PublicClass.btnDelPressed(txtPassword, guna2QQPasswordBtnDel, txtPasswordInitMessage);
        }

        //txtID文本内容改变
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            //guna2QQPasswordBtnDel.Visible = false;
            txtID.ForeColor = Color.Black;
            if (txtID.Text != ""  && ValidateInput())//&& txtID.Text != txtIDInitMessage)
            {
                string str = "select Pwd,RememberPwd,AutoLogin from User_Table where ID=" + Convert.ToInt32(txtID.Text.Trim()) + "";
                DataSet ds = db.GetDataSet(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if(Convert.ToInt32(ds.Tables[0].Rows[0][1])==1)
                    {
                        cbRememberPwd.Checked = true;
                        txtPassword.Text = ds.Tables[0].Rows[0][0].ToString();
                        if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)
                        {
                            cbRememberPwd.Checked = true;
                            cbAutoLogin.Checked = true;
                            txtPassword.Text = ds.Tables[0].Rows[0][0].ToString();
                            txtPassword.Refresh();
                            guna2BtnLogin_Click(sender, e);
                        }
                    }
                    
                    else
                    {
                        cbRememberPwd.Checked = false;
                        cbAutoLogin.Checked = false;
                        txtPassword.Text = txtPasswordInitMessage;
                    }
                }
            }
        }

        //txtPassword文本内容改变
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //guna2QQIDBtnDel.Visible = false;
            txtPassword.ForeColor = Color.Black;
            if(txtPassword.Text!=txtPasswordInitMessage)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
            if (txtPassword.Text!="")//&&txtPassword.Text!=txtPasswordInitMessage)
            {
                ValidateInput();
            }
        }

        //判断是否在txtID文本框按下回车键
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\r') || (e.KeyChar == '\b'))//判断输入的是否为数字、回车、退格
                e.Handled = false;//如果是的话，按键事件不会被阻止，按键将被正常处理
            else
                e.Handled = true;//否则，按键事件被阻止
        }

        //判断是否在txtPassword文本框按下回车键
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')//判断输入的是否为回车
                guna2BtnLogin_Click(sender, e);//如果是的话，调用登录按键的函数
        }
    }
}
