namespace MyQQ.UC_Controls
{
    partial class UC_FriendItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FriendItem));
            this.lblLastMessTime = new System.Windows.Forms.Label();
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBoxHead = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabelUreadMess = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imageListHead = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastMessTime
            // 
            this.lblLastMessTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastMessTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLastMessTime.ForeColor = System.Drawing.Color.Gray;
            this.lblLastMessTime.Location = new System.Drawing.Point(196, 12);
            this.lblLastMessTime.Name = "lblLastMessTime";
            this.lblLastMessTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastMessTime.Size = new System.Drawing.Size(99, 20);
            this.lblLastMessTime.TabIndex = 8;
            this.lblLastMessTime.Text = "2024/10/23";
            this.lblLastMessTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastMessTime.Click += new System.EventHandler(this.lblLastMessTime_Click);
            // 
            // lblLastMessage
            // 
            this.lblLastMessage.AutoSize = true;
            this.lblLastMessage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLastMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblLastMessage.Location = new System.Drawing.Point(61, 38);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(144, 20);
            this.lblLastMessage.TabIndex = 7;
            this.lblLastMessage.Text = "可能是太阳不会眨眼";
            this.lblLastMessage.Click += new System.EventHandler(this.lblLastMessage_Click);
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNickName.Location = new System.Drawing.Point(61, 8);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(92, 27);
            this.lblNickName.TabIndex = 6;
            this.lblNickName.Text = "诗和远方";
            this.lblNickName.Click += new System.EventHandler(this.lblNickName_Click);
            // 
            // guna2CirclePictureBoxHead
            // 
            this.guna2CirclePictureBoxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBoxHead.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxHead.Image")));
            this.guna2CirclePictureBoxHead.ImageRotate = 0F;
            this.guna2CirclePictureBoxHead.InitialImage = null;
            this.guna2CirclePictureBoxHead.Location = new System.Drawing.Point(1, 5);
            this.guna2CirclePictureBoxHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CirclePictureBoxHead.Name = "guna2CirclePictureBoxHead";
            this.guna2CirclePictureBoxHead.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxHead.Size = new System.Drawing.Size(51, 50);
            this.guna2CirclePictureBoxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBoxHead.TabIndex = 5;
            this.guna2CirclePictureBoxHead.TabStop = false;
            this.guna2CirclePictureBoxHead.Click += new System.EventHandler(this.guna2CirclePictureBoxHead_Click);
            // 
            // guna2HtmlLabelUreadMess
            // 
            this.guna2HtmlLabelUreadMess.AutoSize = false;
            this.guna2HtmlLabelUreadMess.BackColor = System.Drawing.Color.Red;
            this.guna2HtmlLabelUreadMess.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guna2HtmlLabelUreadMess.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabelUreadMess.Location = new System.Drawing.Point(232, 35);
            this.guna2HtmlLabelUreadMess.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabelUreadMess.Name = "guna2HtmlLabelUreadMess";
            this.guna2HtmlLabelUreadMess.Size = new System.Drawing.Size(36, 22);
            this.guna2HtmlLabelUreadMess.TabIndex = 9;
            this.guna2HtmlLabelUreadMess.Text = "123";
            this.guna2HtmlLabelUreadMess.Click += new System.EventHandler(this.guna2HtmlLabelUreadMess_Click);
            // 
            // imageListHead
            // 
            this.imageListHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListHead.ImageStream")));
            this.imageListHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListHead.Images.SetKeyName(0, "OIP-C.jpg");
            this.imageListHead.Images.SetKeyName(1, "u=734950038,2286741828&fm=253&gp=0.jpg");
            this.imageListHead.Images.SetKeyName(2, "u=1946511132,1507826697&fm=253&gp=0.jpg");
            this.imageListHead.Images.SetKeyName(3, "u=2411300999,2710627520&fm=253&gp=0.jpg");
            this.imageListHead.Images.SetKeyName(4, "u=2873350968,38029528&fm=253&gp=0.jpg");
            // 
            // UC_FriendItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2HtmlLabelUreadMess);
            this.Controls.Add(this.lblLastMessTime);
            this.Controls.Add(this.lblLastMessage);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.guna2CirclePictureBoxHead);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_FriendItem";
            this.Size = new System.Drawing.Size(296, 62);
            this.Load += new System.EventHandler(this.UC_FriendItem_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UC_FriendItem_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastMessTime;
        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblNickName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxHead;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelUreadMess;
        private System.Windows.Forms.ImageList imageListHead;
    }
}
