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
    public partial class Frm_Head : Form
    {
        public Frm_EditPersonalInfo epi;
        public Frm_Head()
        {
            InitializeComponent();
        }

        private void Frm_Head_Load(object sender, EventArgs e)
        {
            for (int i =0;i<imageListHead.Images.Count;i++) //遍历imagelist中的图片
            {
                listViewHead.Items.Add(i.ToString()); 
                listViewHead.Items[i].ImageIndex = i;
            }
        }

        private void guna2ButtonConfirm_Click(object sender, EventArgs e)
        {
            if(listViewHead.SelectedItems.Count!=0)
            {
                int headID = listViewHead.SelectedItems[0].ImageIndex;//获取选择的图片的索引
                epi.ShowHead(headID);//调用页面编辑界面实例的方法，直接操作的是页面编辑界面的PictureBox
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择一个头像！", "图像选择器", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listViewHead_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int headID = listViewHead.SelectedItems[0].ImageIndex;
            epi.ShowHead(headID);
            this.Close();
        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}