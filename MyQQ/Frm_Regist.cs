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
        public Frm_Regist()
        {
            InitializeComponent();
        }

        private void guna2BtnRegist_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Login fl = new Frm_Login();
            fl.Visible = true;
        }

        private void guna2BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Login fl = new Frm_Login();
            fl.Visible = true;
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
    }
}
