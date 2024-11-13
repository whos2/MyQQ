using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Regist : Form
    {
        DB_Helper db = new DB_Helper(); //创建数据库操作对象
        public Frm_Regist()
        {
            InitializeComponent();
            guna2TextBoxNickName.TabIndex = 0;
            guna2TextBoxPwd.TabIndex = 1;
            guna2TextBoxConfirmPwd.TabIndex = 2;
        }

        private void guna2BtnRegist_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string str = $"insert into User_Table values('{guna2TextBoxNickName.Text}','{guna2TextBoxPwd.Text}',0,0,0)";
                
                db.ExecSQLResult(str);

                MessageBox.Show("注册成功！", "注册信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                Frm_Login fl = new Frm_Login();
                fl.Visible = true;
            }

        }

        private void guna2BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Login login = new Frm_Login();
            login.ShowDialog();
        }

        private void Frm_Regist_Resize(object sender, EventArgs e)
        {
            PublicClass.SetWindowRegion(this, 10);
            PublicClass.SetClassLong(this.Handle, PublicClass.GCL_STYLE, PublicClass.GetClassLong(this.Handle, PublicClass.GCL_STYLE) | PublicClass.CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }

        private void panelTopFrmRegist_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        private bool ValidateInput()
        {
            if(guna2TextBoxPwd.Text != guna2TextBoxConfirmPwd.Text)
            {
                MessageBox.Show("两次输入密码不一致，请重新输入", "注册信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        string guna2TextBoxNickNameInitMessage = "昵称";
        string guna2TextBoxPwdInitMessage = "密码";
        string guna2TextBoxConfirmPwdInitMessage = "确认密码";
        private void guna2TextBoxNickName_Click(object sender, EventArgs e)
        {
            if (guna2TextBoxNickName.Text == guna2TextBoxNickNameInitMessage)
            {
                guna2TextBoxNickName.Text = "";
            }
            if(guna2TextBoxPwd.Text == "")
            {
                guna2TextBoxPwd.Text = guna2TextBoxPwdInitMessage;
            }
            if(guna2TextBoxConfirmPwd.Text=="")
            {
                guna2TextBoxConfirmPwd.Text = guna2TextBoxConfirmPwdInitMessage;
            }
        }

        private void guna2TextBoxPwd_Click(object sender, EventArgs e)
        {
            if(guna2TextBoxPwd.Text== guna2TextBoxPwdInitMessage)
            {
                guna2TextBoxPwd.Text = "";
            }
            if(guna2TextBoxNickName.Text=="")
            {
                guna2TextBoxNickName.Text = guna2TextBoxNickNameInitMessage;
            }
            if(guna2TextBoxConfirmPwd.Text == "")
            {
                guna2TextBoxConfirmPwd.Text = guna2TextBoxConfirmPwdInitMessage;
            }
        }

        private void guna2TextBoxConfirmPwd_Click(object sender, EventArgs e)
        {
            if(guna2TextBoxConfirmPwd.Text== guna2TextBoxConfirmPwdInitMessage)
            {
                guna2TextBoxConfirmPwd.Text = "";
            }
            if (guna2TextBoxNickName.Text == "")
            {
                guna2TextBoxNickName.Text = guna2TextBoxNickNameInitMessage;
            }
            if (guna2TextBoxPwd.Text == "")
            {
                guna2TextBoxPwd.Text = guna2TextBoxPwdInitMessage;
            }
        }

        private void guna2TextBoxPwd_TextChanged(object sender, EventArgs e)
        {
            if(guna2TextBoxPwd.Text!= guna2TextBoxPwdInitMessage)
            {
                guna2TextBoxPwd.PasswordChar = '*';
            }
            else
            {
                guna2TextBoxPwd.PasswordChar = '\0';
            }
        }

        private void guna2TextBoxConfirmPwd_TextChanged(object sender, EventArgs e)
        {
            if(guna2TextBoxConfirmPwd.Text!= guna2TextBoxConfirmPwdInitMessage)
            {
                guna2TextBoxConfirmPwd.PasswordChar = '*';
            }
            else
            {
                guna2TextBoxConfirmPwd.PasswordChar = '\0';
            }
        }
    }
}
