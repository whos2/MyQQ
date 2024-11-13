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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SearchItem));
            this.guna2CirclePictureBoxHead = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNickNameAndID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).BeginInit();
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
            // UC_SearchItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNickNameAndID);
            this.Controls.Add(this.guna2CirclePictureBoxHead);
            this.Name = "UC_SearchItem";
            this.Size = new System.Drawing.Size(296, 62);
            this.Load += new System.EventHandler(this.UC_SearchItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxHead;
        private System.Windows.Forms.Label lblNickNameAndID;
    }
}
