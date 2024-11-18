namespace MyQQ
{
    partial class Frm_PersonalInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PersonalInfo));
            this.guna2CirclePictureBoxHead = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQQID = new System.Windows.Forms.Label();
            this.guna2ButtonEditPersonalInfo = new Guna.UI2.WinForms.Guna2Button();
            this.lblLikeAmount = new System.Windows.Forms.Label();
            this.guna2CirclePictureBoxFlag = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblFlag = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.guna2CirclePictureBoxSex = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.imageListSex = new System.Windows.Forms.ImageList(this.components);
            this.imageListFlag = new System.Windows.Forms.ImageList(this.components);
            this.imageListHead = new System.Windows.Forms.ImageList(this.components);
            this.lblBirthday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxSex)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBoxHead
            // 
            this.guna2CirclePictureBoxHead.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxHead.Image")));
            this.guna2CirclePictureBoxHead.ImageRotate = 0F;
            this.guna2CirclePictureBoxHead.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxHead.InitialImage")));
            this.guna2CirclePictureBoxHead.Location = new System.Drawing.Point(12, 13);
            this.guna2CirclePictureBoxHead.Name = "guna2CirclePictureBoxHead";
            this.guna2CirclePictureBoxHead.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxHead.Size = new System.Drawing.Size(65, 63);
            this.guna2CirclePictureBoxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBoxHead.TabIndex = 1;
            this.guna2CirclePictureBoxHead.TabStop = false;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNickName.Location = new System.Drawing.Point(108, 20);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(132, 27);
            this.lblNickName.TabIndex = 2;
            this.lblNickName.Text = "叫乌鸦的少年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(108, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "QQ";
            // 
            // lblQQID
            // 
            this.lblQQID.AutoSize = true;
            this.lblQQID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQQID.Location = new System.Drawing.Point(147, 51);
            this.lblQQID.Name = "lblQQID";
            this.lblQQID.Size = new System.Drawing.Size(99, 20);
            this.lblQQID.TabIndex = 2;
            this.lblQQID.Text = "2213666375";
            // 
            // guna2ButtonEditPersonalInfo
            // 
            this.guna2ButtonEditPersonalInfo.BorderRadius = 5;
            this.guna2ButtonEditPersonalInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEditPersonalInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEditPersonalInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonEditPersonalInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonEditPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonEditPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonEditPersonalInfo.Location = new System.Drawing.Point(63, 270);
            this.guna2ButtonEditPersonalInfo.Name = "guna2ButtonEditPersonalInfo";
            this.guna2ButtonEditPersonalInfo.Size = new System.Drawing.Size(246, 45);
            this.guna2ButtonEditPersonalInfo.TabIndex = 3;
            this.guna2ButtonEditPersonalInfo.Text = "编辑资料";
            this.guna2ButtonEditPersonalInfo.Click += new System.EventHandler(this.guna2ButtonEditPersonalInfo_Click);
            // 
            // lblLikeAmount
            // 
            this.lblLikeAmount.AutoSize = true;
            this.lblLikeAmount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLikeAmount.Location = new System.Drawing.Point(278, 45);
            this.lblLikeAmount.Name = "lblLikeAmount";
            this.lblLikeAmount.Size = new System.Drawing.Size(36, 20);
            this.lblLikeAmount.TabIndex = 5;
            this.lblLikeAmount.Text = "150";
            // 
            // guna2CirclePictureBoxFlag
            // 
            this.guna2CirclePictureBoxFlag.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBoxFlag.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBoxFlag.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxFlag.Image")));
            this.guna2CirclePictureBoxFlag.ImageRotate = 0F;
            this.guna2CirclePictureBoxFlag.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxFlag.InitialImage")));
            this.guna2CirclePictureBoxFlag.Location = new System.Drawing.Point(69, 99);
            this.guna2CirclePictureBoxFlag.Name = "guna2CirclePictureBoxFlag";
            this.guna2CirclePictureBoxFlag.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxFlag.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBoxFlag.TabIndex = 6;
            this.guna2CirclePictureBoxFlag.TabStop = false;
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFlag.Location = new System.Drawing.Point(147, 137);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(39, 20);
            this.lblFlag.TabIndex = 7;
            this.lblFlag.Text = "在线";
            // 
            // btnLike
            // 
            this.btnLike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLike.BackgroundImage")));
            this.btnLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.ForeColor = System.Drawing.Color.White;
            this.btnLike.Location = new System.Drawing.Point(279, 14);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(32, 36);
            this.btnLike.TabIndex = 8;
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // guna2CirclePictureBoxSex
            // 
            this.guna2CirclePictureBoxSex.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBoxSex.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBoxSex.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxSex.Image")));
            this.guna2CirclePictureBoxSex.ImageRotate = 0F;
            this.guna2CirclePictureBoxSex.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBoxSex.InitialImage")));
            this.guna2CirclePictureBoxSex.Location = new System.Drawing.Point(220, 6);
            this.guna2CirclePictureBoxSex.Name = "guna2CirclePictureBoxSex";
            this.guna2CirclePictureBoxSex.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxSex.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBoxSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBoxSex.TabIndex = 9;
            this.guna2CirclePictureBoxSex.TabStop = false;
            this.guna2CirclePictureBoxSex.UseTransparentBackground = true;
            // 
            // imageListSex
            // 
            this.imageListSex.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSex.ImageStream")));
            this.imageListSex.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSex.Images.SetKeyName(0, "男女-男.png");
            this.imageListSex.Images.SetKeyName(1, "男女-女-copy (1).png");
            // 
            // imageListFlag
            // 
            this.imageListFlag.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFlag.ImageStream")));
            this.imageListFlag.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFlag.Images.SetKeyName(0, "在线-不在线.png");
            this.imageListFlag.Images.SetKeyName(1, "在线-不在线 (1).png");
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
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBirthday.Location = new System.Drawing.Point(147, 72);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(93, 20);
            this.lblBirthday.TabIndex = 10;
            this.lblBirthday.Text = "2024/11/17";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(108, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "生日";
            // 
            // Frm_PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 327);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2CirclePictureBoxSex);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.guna2CirclePictureBoxFlag);
            this.Controls.Add(this.lblLikeAmount);
            this.Controls.Add(this.guna2ButtonEditPersonalInfo);
            this.Controls.Add(this.lblQQID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.guna2CirclePictureBoxHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PersonalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frm_PersonalInfo";
            this.Deactivate += new System.EventHandler(this.Frm_PersonalInfo_Deactivate);
            this.Load += new System.EventHandler(this.Frm_PersonalInfo_Load);
            this.Resize += new System.EventHandler(this.Frm_PersonalInfo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxSex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxHead;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQQID;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonEditPersonalInfo;
        private System.Windows.Forms.Label lblLikeAmount;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxFlag;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Button btnLike;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxSex;
        private System.Windows.Forms.ImageList imageListSex;
        private System.Windows.Forms.ImageList imageListFlag;
        private System.Windows.Forms.ImageList imageListHead;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label label3;
    }
}