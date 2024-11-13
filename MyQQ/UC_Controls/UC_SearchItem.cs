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
    public partial class UC_SearchItem : UserControl
    {
        private string nickAndID;

        public string NickAndID
        {
            get { return nickAndID; }
            set { nickAndID = value; }
        }

        public UC_SearchItem()
        {
            InitializeComponent();
            //lblNickNameAndID.Text = nickAndID;
        }

        private void UC_SearchItem_Load(object sender, EventArgs e)
        {
            lblNickNameAndID.Text = nickAndID;
        }
    }
}
