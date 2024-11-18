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
    public partial class UC_MyMessage : UserControl
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public UC_MyMessage()
        {
            InitializeComponent();
        }

        private void UC_MyMessage_Load(object sender, EventArgs e)
        {
            guna2TBMyMess.Text = message;
            Size fontSize = TextRenderer.MeasureText(guna2TBMyMess.Text, guna2TBMyMess.Font); //测量输入内容占空间的大小
            int width = fontSize.Width;         //获取消息需要占的宽度
            int height = fontSize.Height;       //获取消息需要占的高度
            guna2TBMyMess.Width = width + 15;   //文本框相对于文本内容需要稍微大一些
            guna2TBMyMess.Height = height + 20;
            Size textBox = new Size(guna2TBMyMess.Width, guna2TBMyMess.Height);
            //this.Width = textBox.Width;
            this.Height = textBox.Height + 10;   //用户控件相对于文本框需要稍微大一些


            // 设置文本框和头像的相对位置
            Point head = guna2CirclePictureBoxFriendHead.PointToScreen(new Point(0, 0)); //头像控件相对于屏幕左上角的坐标
            int headX = head.X; //头像控件相对于屏幕的横坐标
            int headY = head.Y; //头像控件相对于屏幕的纵坐标
            int startX = headX - guna2TBMyMess.Width - 10; //文本框控件相对于屏幕位置的X坐标
            int startY = headY + 3; //性别控件相对于屏幕位置的Y坐标
            Point font2ScreenPos = new Point(startX, startY);
            Point font2FormPos = this.PointToClient(font2ScreenPos);
            guna2TBMyMess.Location = font2FormPos;
        }
    }
}
