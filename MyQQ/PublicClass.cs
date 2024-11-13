using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    class PublicClass
    {
        public static int loginID;

        #region  鼠标移动窗体位置
        public const int WM_SYSCOMMAND = 0x0112;//该变量表示将向Windows发送的消息类型
        public const int SC_MOVE = 0xF010;//该变量表示发送消息的附加消息
        public const int HTCAPTION = 0x0002;//该变量表示发送消息的附加消息

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwdn, int wMsg, int mParam, int lParam);//向指定的窗体发送Windows消息
        #endregion

        #region  设置窗体圆角
        /// <summary>
        /// 设置窗体的Region
        /// </summary>
        public static void SetWindowRegion(Form form,int radius)
        {
            GraphicsPath FormPath;
            Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);
            FormPath = GetRoundedRectPath(rect, radius);
            form.Region = new Region(FormPath);
        }

        /// <summary>
        /// 绘制圆角路径
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private static GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }
        #endregion

        #region 窗体边缘阴影效果
        public const int CS_DropSHADOW = 0x20000;
        public const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        #endregion

        #region 鼠标悬停显示提示信息
        public static void mouseHover(Guna2Button button, string msg)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;

            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(button, msg);
        }
        #endregion

        #region 设置文本框为选中及未选中时的控件状态
        public static void txtBoxSelected(TextBox tb,Guna2Button btn,string text)
        {
            if(tb.Text==text)
            {
                tb.Clear();
                tb.ForeColor = Color.Gray;
            }
            else
            {
                tb.ForeColor = Color.Black;
            }
            btn.Visible = true;
        }

        public static void txtBoxDisSelected(TextBox tb,Guna2Button btn, string text)
        {
            if(tb.Text==string.Empty)
            {
                tb.Text = text;
                tb.ForeColor = Color.Gray;
            }
            else
            {
                tb.ForeColor = Color.Black;
            }
            //btn.Visible = false;
        }
        #endregion

        #region 删除文本按钮被点击
        public static void btnDelPressed(TextBox tb,Guna2Button btn,string text)
        {
            tb.Focus();
            tb.Text = string.Empty;
            int index = tb.Text.Length / 2;
            tb.SelectionStart = index;
        }
        #endregion


        
    }
}
