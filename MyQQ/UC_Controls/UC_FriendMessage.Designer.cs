namespace MyQQ.UC_Controls
{
    partial class UC_FriendMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FriendMessage));
            this.guna2CirclePictureBoxFriendHead = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2TBFriendMess = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxFriendHead)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBoxFriendHead
            // 
            this.guna2CirclePictureBoxFriendHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBoxFriendHead.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxFriendHead.Image")));
            this.guna2CirclePictureBoxFriendHead.ImageRotate = 0F;
            this.guna2CirclePictureBoxFriendHead.InitialImage = null;
            this.guna2CirclePictureBoxFriendHead.Location = new System.Drawing.Point(7, 6);
            this.guna2CirclePictureBoxFriendHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CirclePictureBoxFriendHead.Name = "guna2CirclePictureBoxFriendHead";
            this.guna2CirclePictureBoxFriendHead.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxFriendHead.Size = new System.Drawing.Size(51, 50);
            this.guna2CirclePictureBoxFriendHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBoxFriendHead.TabIndex = 6;
            this.guna2CirclePictureBoxFriendHead.TabStop = false;
            // 
            // guna2TBFriendMess
            // 
            this.guna2TBFriendMess.BorderColor = System.Drawing.Color.White;
            this.guna2TBFriendMess.BorderRadius = 5;
            this.guna2TBFriendMess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TBFriendMess.DefaultText = "";
            this.guna2TBFriendMess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TBFriendMess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TBFriendMess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TBFriendMess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TBFriendMess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TBFriendMess.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TBFriendMess.ForeColor = System.Drawing.Color.Black;
            this.guna2TBFriendMess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TBFriendMess.Location = new System.Drawing.Point(64, 8);
            this.guna2TBFriendMess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TBFriendMess.Name = "guna2TBFriendMess";
            this.guna2TBFriendMess.PasswordChar = '\0';
            this.guna2TBFriendMess.PlaceholderText = "";
            this.guna2TBFriendMess.ReadOnly = true;
            this.guna2TBFriendMess.SelectedText = "";
            this.guna2TBFriendMess.Size = new System.Drawing.Size(258, 48);
            this.guna2TBFriendMess.TabIndex = 7;
            // 
            // UC_FriendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2TBFriendMess);
            this.Controls.Add(this.guna2CirclePictureBoxFriendHead);
            this.Name = "UC_FriendMessage";
            this.Size = new System.Drawing.Size(799, 76);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxFriendHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxFriendHead;
        private Guna.UI2.WinForms.Guna2TextBox guna2TBFriendMess;
    }
}
