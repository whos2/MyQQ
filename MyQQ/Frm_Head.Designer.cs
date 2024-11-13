namespace MyQQ
{
    partial class Frm_Head
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Head));
            this.imageListHead = new System.Windows.Forms.ImageList(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ButtonConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewHead = new System.Windows.Forms.ListView();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ButtonConfirm);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ButtonCancel);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 245);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(442, 43);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // guna2ButtonConfirm
            // 
            this.guna2ButtonConfirm.BorderRadius = 5;
            this.guna2ButtonConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonConfirm.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonConfirm.Location = new System.Drawing.Point(348, 4);
            this.guna2ButtonConfirm.Name = "guna2ButtonConfirm";
            this.guna2ButtonConfirm.Size = new System.Drawing.Size(80, 36);
            this.guna2ButtonConfirm.TabIndex = 0;
            this.guna2ButtonConfirm.Text = "确定";
            this.guna2ButtonConfirm.Click += new System.EventHandler(this.guna2ButtonConfirm_Click);
            // 
            // guna2ButtonCancel
            // 
            this.guna2ButtonCancel.BorderRadius = 5;
            this.guna2ButtonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonCancel.Location = new System.Drawing.Point(263, 4);
            this.guna2ButtonCancel.Name = "guna2ButtonCancel";
            this.guna2ButtonCancel.Size = new System.Drawing.Size(80, 36);
            this.guna2ButtonCancel.TabIndex = 0;
            this.guna2ButtonCancel.Text = "取消";
            this.guna2ButtonCancel.Click += new System.EventHandler(this.guna2ButtonCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Pink;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "选择头像";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 45);
            this.panel1.TabIndex = 13;
            // 
            // listViewHead
            // 
            this.listViewHead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewHead.HideSelection = false;
            this.listViewHead.Location = new System.Drawing.Point(0, 45);
            this.listViewHead.Name = "listViewHead";
            this.listViewHead.Size = new System.Drawing.Size(442, 204);
            this.listViewHead.TabIndex = 14;
            this.listViewHead.UseCompatibleStateImageBehavior = false;
            // 
            // Frm_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 288);
            this.Controls.Add(this.listViewHead);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Head";
            this.Text = "选择头像";
            this.Load += new System.EventHandler(this.Frm_Head_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListHead;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonConfirm;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewHead;
    }
}