using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ.UC_Controls
{
    public partial class UC_FriendItem : UserControl
    {
        private int headID;

        //public delegate void ChangeFriendNameAndStateHandler();  //定义委托
        //public event ChangeFriendNameAndStateHandler ChangeFriendNameAndState;   //定义事件

        public class FriendItemID : EventArgs
        {
            private int friendID;

            public int FriendID
            {
                get { return friendID; }
                set { friendID = value; }
            }

            public FriendItemID(int id)
            {
                friendID = id;
            }
        }
        public delegate void FrmMainUpdateEventHandler(object sender, FriendItemID e);
        public event FrmMainUpdateEventHandler FrmMainUpdateEvent;

        public int HeadID
        {
            get { return headID; }
            set { headID = value; }
        }

        private string nick;

        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }



        public UC_FriendItem()
        {
            InitializeComponent();
        }

        private void UC_FriendItem_Load(object sender, EventArgs e)
        {
            guna2CirclePictureBoxHead.Image = imageListHead.Images[headID];
            lblNickName.Text = nick;
        }

        private void UC_FriendItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (FrmMainUpdateEvent != null)
            {
                FriendItemID ee = new FriendItemID(id);
                FrmMainUpdateEvent(this, ee);
            }
        }

        private void guna2CirclePictureBoxHead_Click(object sender, EventArgs e)
        {
            if (FrmMainUpdateEvent != null)
            {
                FriendItemID ee = new FriendItemID(id);
                FrmMainUpdateEvent(this, ee);
            }
        }

        private void lblNickName_Click(object sender, EventArgs e)
        {
            if (FrmMainUpdateEvent != null)
            {
                FriendItemID ee = new FriendItemID(id);
                FrmMainUpdateEvent(this, ee);
            }
        }

        private void lblLastMessage_Click(object sender, EventArgs e)
        {
            if (FrmMainUpdateEvent != null)
            {
                FriendItemID ee = new FriendItemID(id);
                FrmMainUpdateEvent(this, ee);
            }
        }

        private void lblLastMessTime_Click(object sender, EventArgs e)
        {
            if (FrmMainUpdateEvent != null)
            {
                FriendItemID ee = new FriendItemID(id);
                FrmMainUpdateEvent(this, ee);
            }
        }

        private void guna2HtmlLabelUreadMess_Click(object sender, EventArgs e)
        {
            if (FrmMainUpdateEvent != null)
            {
                FriendItemID ee = new FriendItemID(id);
                FrmMainUpdateEvent(this, ee);
            }
        }
    }

    
}
