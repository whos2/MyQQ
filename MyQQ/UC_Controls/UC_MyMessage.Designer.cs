namespace MyQQ.UC_Controls
{
    partial class UC_MyMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MyMessage));
            this.guna2TBMyMess = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBoxFriendHead = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxFriendHead)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TBMyMess
            // 
            this.guna2TBMyMess.BorderColor = System.Drawing.Color.SkyBlue;
            this.guna2TBMyMess.BorderRadius = 5;
            this.guna2TBMyMess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TBMyMess.DefaultText = "";
            this.guna2TBMyMess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TBMyMess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TBMyMess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TBMyMess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TBMyMess.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2TBMyMess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TBMyMess.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guna2TBMyMess.ForeColor = System.Drawing.Color.White;
            this.guna2TBMyMess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TBMyMess.Location = new System.Drawing.Point(450, 7);
            this.guna2TBMyMess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TBMyMess.Multiline = true;
            this.guna2TBMyMess.Name = "guna2TBMyMess";
            this.guna2TBMyMess.PasswordChar = '\0';
            this.guna2TBMyMess.PlaceholderText = "";
            this.guna2TBMyMess.ReadOnly = true;
            this.guna2TBMyMess.SelectedText = "";
            this.guna2TBMyMess.Size = new System.Drawing.Size(258, 72);
            this.guna2TBMyMess.TabIndex = 9;
            this.guna2TBMyMess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2CirclePictureBoxFriendHead
            // 
            this.guna2CirclePictureBoxFriendHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBoxFriendHead.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxFriendHead.Image")));
            this.guna2CirclePictureBoxFriendHead.ImageRotate = 0F;
            this.guna2CirclePictureBoxFriendHead.InitialImage = null;
            this.guna2CirclePictureBoxFriendHead.Location = new System.Drawing.Point(714, 5);
            this.guna2CirclePictureBoxFriendHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CirclePictureBoxFriendHead.Name = "guna2CirclePictureBoxFriendHead";
            this.guna2CirclePictureBoxFriendHead.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxFriendHead.Size = new System.Drawing.Size(51, 50);
            this.guna2CirclePictureBoxFriendHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBoxFriendHead.TabIndex = 8;
            this.guna2CirclePictureBoxFriendHead.TabStop = false;
            // 
            // UC_MyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2TBMyMess);
            this.Controls.Add(this.guna2CirclePictureBoxFriendHead);
            this.Name = "UC_MyMessage";
            this.Size = new System.Drawing.Size(772, 117);
            this.Load += new System.EventHandler(this.UC_MyMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxFriendHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TBMyMess;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxFriendHead;
    }
}
