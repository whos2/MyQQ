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
    public partial class UC_NewFriendItem : UserControl
    {
        DB_Helper db = new DB_Helper();

        private string nickAndID;

        public string NickAndID
        {
            get { return nickAndID; }
            set { nickAndID = value; }
        }

        private int headID;

        public int HeadID
        {
            get { return headID; }
            set { headID = value; }
        }


        public UC_NewFriendItem()
        {
            InitializeComponent();
        }

        private void UC_NewFriendItem_Load(object sender, EventArgs e)
        {
            lblNickNameAndID.Text = nickAndID;
            guna2CirclePictureBoxHead.Image = imageListHead.Images[Convert.ToInt32(headID)];
        }

        int id = 0;
        string pattern = @"\((\d+)\)";   //正则表达式，匹配括号内的数字

        private void 同意ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Match match = Regex.Match(nickAndID, pattern);
            if (match.Success)
            {
                id = Convert.ToInt32(match.Groups[1].Value);   //获取该用户的id
            }
            if(id != 0)
            {
                MessageBox.Show($"您已同意添加'{nickAndID}'为好友");
                string str = $"update Friend_Table set Agree=1,Refuse=0 where HostID={id} and FriendID={PublicClass.loginID}";  //用户同意了好友申请
                db.ExecSQLResult(str);
                this.Dispose();
            }
        }

        private void 拒绝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Match match = Regex.Match(nickAndID, pattern);
            if (match.Success)
            {
                id = Convert.ToInt32(match.Groups[1].Value);   //获取该用户的id
            }
            if (id != 0)
            {
                MessageBox.Show($"您已拒绝添加'{nickAndID}'为好友");
                string str = $"update Friend_Table set Agree=0,Refuse=1 where HostID={id} and FriendID={PublicClass.loginID}";  //用户同意了好友申请
                db.ExecSQLResult(str);
                this.Dispose();
            }
        }
    }
}
