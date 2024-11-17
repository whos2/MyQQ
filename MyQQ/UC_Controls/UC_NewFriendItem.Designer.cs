namespace MyQQ.UC_Controls
{
    partial class UC_NewFriendItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NewFriendItem));
            this.lblNickNameAndID = new System.Windows.Forms.Label();
            this.guna2CirclePictureBoxHead = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.同意ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拒绝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListHead = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNickNameAndID
            // 
            this.lblNickNameAndID.AutoSize = true;
            this.lblNickNameAndID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNickNameAndID.Location = new System.Drawing.Point(50, 16);
            this.lblNickNameAndID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNickNameAndID.Name = "lblNickNameAndID";
            this.lblNickNameAndID.Size = new System.Drawing.Size(174, 21);
            this.lblNickNameAndID.TabIndex = 4;
            this.lblNickNameAndID.Text = "诗和远方(2213666375)";
            // 
            // guna2CirclePictureBoxHead
            // 
            this.guna2CirclePictureBoxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBoxHead.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxHead.Image")));
            this.guna2CirclePictureBoxHead.ImageRotate = 0F;
            this.guna2CirclePictureBoxHead.InitialImage = null;
            this.guna2CirclePictureBoxHead.Location = new System.Drawing.Point(4, 5);
            this.guna2CirclePictureBoxHead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CirclePictureBoxHead.Name = "guna2CirclePictureBoxHead";
            this.guna2CirclePictureBoxHead.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxHead.Size = new System.Drawing.Size(38, 40);
            this.guna2CirclePictureBoxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBoxHead.TabIndex = 3;
            this.guna2CirclePictureBoxHead.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.同意ToolStripMenuItem,
            this.拒绝ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // 同意ToolStripMenuItem
            // 
            this.同意ToolStripMenuItem.Name = "同意ToolStripMenuItem";
            this.同意ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.同意ToolStripMenuItem.Text = "同意";
            this.同意ToolStripMenuItem.Click += new System.EventHandler(this.同意ToolStripMenuItem_Click);
            // 
            // 拒绝ToolStripMenuItem
            // 
            this.拒绝ToolStripMenuItem.Name = "拒绝ToolStripMenuItem";
            this.拒绝ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.拒绝ToolStripMenuItem.Text = "拒绝";
            this.拒绝ToolStripMenuItem.Click += new System.EventHandler(this.拒绝ToolStripMenuItem_Click);
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
            // UC_NewFriendItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblNickNameAndID);
            this.Controls.Add(this.guna2CirclePictureBoxHead);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_NewFriendItem";
            this.Size = new System.Drawing.Size(222, 50);
            this.Load += new System.EventHandler(this.UC_NewFriendItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNickNameAndID;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxHead;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 同意ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拒绝ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListHead;
    }
}
