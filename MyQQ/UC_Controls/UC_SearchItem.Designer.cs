namespace MyQQ.UC_Controls
{
    partial class UC_SearchItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SearchItem));
            this.guna2CirclePictureBoxHead = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNickNameAndID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加好友ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListHead = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBoxHead
            // 
            this.guna2CirclePictureBoxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBoxHead.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxHead.Image")));
            this.guna2CirclePictureBoxHead.ImageRotate = 0F;
            this.guna2CirclePictureBoxHead.InitialImage = null;
            this.guna2CirclePictureBoxHead.Location = new System.Drawing.Point(3, 5);
            this.guna2CirclePictureBoxHead.Name = "guna2CirclePictureBoxHead";
            this.guna2CirclePictureBoxHead.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxHead.Size = new System.Drawing.Size(50, 50);
            this.guna2CirclePictureBoxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBoxHead.TabIndex = 1;
            this.guna2CirclePictureBoxHead.TabStop = false;
            // 
            // lblNickNameAndID
            // 
            this.lblNickNameAndID.AutoSize = true;
            this.lblNickNameAndID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNickNameAndID.Location = new System.Drawing.Point(64, 19);
            this.lblNickNameAndID.Name = "lblNickNameAndID";
            this.lblNickNameAndID.Size = new System.Drawing.Size(226, 27);
            this.lblNickNameAndID.TabIndex = 2;
            this.lblNickNameAndID.Text = "诗和远方(2213666375)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加好友ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // 添加好友ToolStripMenuItem
            // 
            this.添加好友ToolStripMenuItem.Name = "添加好友ToolStripMenuItem";
            this.添加好友ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.添加好友ToolStripMenuItem.Text = "添加好友";
            this.添加好友ToolStripMenuItem.Click += new System.EventHandler(this.添加好友ToolStripMenuItem_Click);
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
            // UC_SearchItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblNickNameAndID);
            this.Controls.Add(this.guna2CirclePictureBoxHead);
            this.Name = "UC_SearchItem";
            this.Size = new System.Drawing.Size(296, 62);
            this.Load += new System.EventHandler(this.UC_SearchItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxHead;
        private System.Windows.Forms.Label lblNickNameAndID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加好友ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListHead;
    }
}
