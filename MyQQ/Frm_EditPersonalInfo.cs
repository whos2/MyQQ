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
    public partial class Frm_EditPersonalInfo : Form
    {
        DB_Helper db = new DB_Helper();

        public Frm_PersonalInfo fpi;

        //string nickName;
        //string sex;
        //string birthday;
        //string originalPwd;
        //string newPwd;
        public Frm_EditPersonalInfo()
        {
            InitializeComponent();
        }

        public void ShowHead(int headID)
        {
            guna2CirclePictureBoxHead.Image = imageListHead.Images[headID];
            guna2CirclePictureBoxHead.Tag = headID;
        }

        private void guna2CirclePictureBoxHead_Click(object sender, EventArgs e)
        {
            Frm_Head fh = new Frm_Head(); //创建头像选择界面的对象
            fh.epi = this; //该对象的epi变量引用的是本界面（信息编辑界面）实例
            fh.Show();
        }

        //验证输入格式是否正确
        private bool ValidateInput()
        {
            if(guna2TextBoxNickName.Text=="")
            {
                MessageBox.Show("昵称不能为空！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if(guna2ComboBoxSex.Text=="")
            {
                MessageBox.Show("性别不能为空！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if(guna2DateTimePickerBirth.Text=="")
            {
                MessageBox.Show("生日不能为空！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if(guna2TextBoxOriginalPwd.Text=="")
                {
                    if(guna2TextBoxNewPwd.Text!="" || guna2TextBoxConfirmPwd.Text!="")
                    {
                        MessageBox.Show("修改密码请先输入原始密码！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    string str = $"select Pwd from User_Table where ID={PublicClass.loginID}";
                    SqlDataReader reader = db.GetSQLReader(str);
                    if (reader.Read())
                    {
                        string originalPwd = reader["Pwd"].ToString();
                        reader.Close();
                        DB_Helper.connection.Close();
                        if (originalPwd != guna2TextBoxOriginalPwd.Text)
                        {
                            MessageBox.Show("输入的原始密码有误，请重新输入！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    reader.Close();
                    DB_Helper.connection.Close();

                    if (guna2TextBoxNewPwd.Text != guna2TextBoxConfirmPwd.Text)
                    {
                        MessageBox.Show("两次输入的密码不一致，请重新输入！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            MessageBox.Show("保存成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        /// <summary>
        /// 将信息编辑界面获取到的信息更新到数据库中
        /// </summary>
        private void SaveInfoToDB()
        {
            string nickName = guna2TextBoxNickName.Text;
            string sex = guna2ComboBoxSex.Text;
            string newPwd = guna2TextBoxNewPwd.Text;
            //string birthday;
            guna2DateTimePickerBirth.Format = DateTimePickerFormat.Custom;
            string birthday = guna2DateTimePickerBirth.Text;
            if (ValidateInput())//如果输入的数据格式没有问题
            {
                string str;
                if (guna2TextBoxNewPwd.Text != "" || guna2TextBoxConfirmPwd.Text != "")
                {
                    if(guna2CirclePictureBoxHead.Tag==null)
                    {
                        str = $"update User_Table set Name='{nickName}',Sex='{sex}',Pwd='{newPwd}',Birthday='{birthday}' where ID={PublicClass.loginID}";
                        db.ExecSQLResult(str);
                    }
                    else
                    {
                        str = $"update User_Table set Name='{nickName}',Sex='{sex}',Pwd='{newPwd}',Birthday='{birthday}',HeadID='{guna2CirclePictureBoxHead.Tag}' where ID={PublicClass.loginID}";
                        db.ExecSQLResult(str);
                    }
                }
                else
                {
                    if(guna2CirclePictureBoxHead.Tag==null)
                    {
                        str = $"update User_Table set Name='{nickName}',Sex='{sex}',Birthday='{birthday}' where ID={PublicClass.loginID}";
                        db.ExecSQLResult(str);
                    }
                    else
                    {
                        str = $"update User_Table set Name='{nickName}',Sex='{sex}',Birthday='{birthday}',HeadID='{guna2CirclePictureBoxHead.Tag}' where ID={PublicClass.loginID}";
                        db.ExecSQLResult(str);
                    }
                }
                this.Close();
            }
        }

        /// <summary>
        /// 从数据库中加载数据，填充信息编辑页面
        /// </summary>
        private void LoadInfoFromDB()
        {
            string str = $"select Name,Sex,Birthday,HeadID from User_Table where ID={PublicClass.loginID}";
            SqlDataReader reader = db.GetSQLReader(str);
            if (reader.Read())
            {
                if (!(reader["HeadID"] is DBNull))
                    guna2CirclePictureBoxHead.Image = imageListHead.Images[Convert.ToInt32(reader["HeadID"])];
                if (!(reader["Birthday"] is DBNull))
                    guna2DateTimePickerBirth.Text = reader["Birthday"].ToString();
                if (!(reader["Sex"] is DBNull))
                    guna2ComboBoxSex.Text = reader["Sex"].ToString();
                if (!(reader["Name"] is DBNull))
                    guna2TextBoxNickName.Text = reader["Name"].ToString();
            }
            reader.Close();
            DB_Helper.connection.Close();
        }

        private void Frm_EditPersonalInfo_Load(object sender, EventArgs e)
        {
            LoadInfoFromDB();
        }

        private void guna2ButtonConfirm_Click(object sender, EventArgs e)
        {
            SaveInfoToDB();
            if(guna2CirclePictureBoxHead.Tag!=null)
            {
                fpi.UpdateHead(Convert.ToInt32(guna2CirclePictureBoxHead.Tag));
            }
        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
