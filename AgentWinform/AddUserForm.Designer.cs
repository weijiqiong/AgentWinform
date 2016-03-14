namespace AgentWinform
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWeixinNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cbIsNoEdit = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAuthNo = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.dtAuthNow = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTaobaoName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMakePic = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofPhotoFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(234, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(236, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtWeixinNo
            // 
            this.txtWeixinNo.Location = new System.Drawing.Point(397, 140);
            this.txtWeixinNo.Name = "txtWeixinNo";
            this.txtWeixinNo.Size = new System.Drawing.Size(127, 21);
            this.txtWeixinNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(395, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "微信号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(234, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "身份证号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNameNo
            // 
            this.txtNameNo.Location = new System.Drawing.Point(236, 90);
            this.txtNameNo.MaxLength = 18;
            this.txtNameNo.Name = "txtNameNo";
            this.txtNameNo.Size = new System.Drawing.Size(247, 21);
            this.txtNameNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(234, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "代理级别";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(234, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "地区";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(234, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "授权有效日期";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(371, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "至";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Image = global::AgentWinform.Properties.Resources._20150518041311718_easyicon_net_128;
            this.pbPhoto.Location = new System.Drawing.Point(24, 14);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(145, 193);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 15;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Visible = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // cbArea
            // 
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(236, 196);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(127, 20);
            this.cbArea.TabIndex = 16;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // dtDateStart
            // 
            this.dtDateStart.Location = new System.Drawing.Point(236, 307);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(127, 21);
            this.dtDateStart.TabIndex = 17;
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.Location = new System.Drawing.Point(397, 307);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(127, 21);
            this.dtDateEnd.TabIndex = 18;
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Location = new System.Drawing.Point(236, 255);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(127, 20);
            this.cbLevel.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.cbIsNoEdit);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtAuthNo);
            this.panel1.Controls.Add(this.cbCity);
            this.panel1.Controls.Add(this.dtAuthNow);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTaobaoName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbLevel);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.dtDateEnd);
            this.panel1.Controls.Add(this.txtWeixinNo);
            this.panel1.Controls.Add(this.dtDateStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbArea);
            this.panel1.Controls.Add(this.txtNameNo);
            this.panel1.Controls.Add(this.pbPhoto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 399);
            this.panel1.TabIndex = 20;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(490, 90);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(34, 21);
            this.btnQuery.TabIndex = 29;
            this.btnQuery.Text = "查";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cbIsNoEdit
            // 
            this.cbIsNoEdit.AutoSize = true;
            this.cbIsNoEdit.Location = new System.Drawing.Point(452, 18);
            this.cbIsNoEdit.Name = "cbIsNoEdit";
            this.cbIsNoEdit.Size = new System.Drawing.Size(72, 16);
            this.cbIsNoEdit.TabIndex = 28;
            this.cbIsNoEdit.Text = "是否修改";
            this.cbIsNoEdit.UseVisualStyleBackColor = true;
            this.cbIsNoEdit.CheckedChanged += new System.EventHandler(this.cbIsNoEdit_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(395, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "编号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAuthNo
            // 
            this.txtAuthNo.Enabled = false;
            this.txtAuthNo.Location = new System.Drawing.Point(397, 40);
            this.txtAuthNo.Name = "txtAuthNo";
            this.txtAuthNo.Size = new System.Drawing.Size(127, 21);
            this.txtAuthNo.TabIndex = 26;
            this.txtAuthNo.Text = "自动生成";
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(397, 196);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(127, 20);
            this.cbCity.TabIndex = 25;
            // 
            // dtAuthNow
            // 
            this.dtAuthNow.Location = new System.Drawing.Point(397, 254);
            this.dtAuthNow.Name = "dtAuthNow";
            this.dtAuthNow.Size = new System.Drawing.Size(127, 21);
            this.dtAuthNow.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(395, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "授权日期";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(234, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "淘宝店名";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTaobaoName
            // 
            this.txtTaobaoName.Location = new System.Drawing.Point(236, 140);
            this.txtTaobaoName.Name = "txtTaobaoName";
            this.txtTaobaoName.Size = new System.Drawing.Size(127, 21);
            this.txtTaobaoName.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnMakePic);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 64);
            this.panel2.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(429, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnMakePic
            // 
            this.btnMakePic.Location = new System.Drawing.Point(236, 15);
            this.btnMakePic.Name = "btnMakePic";
            this.btnMakePic.Size = new System.Drawing.Size(127, 37);
            this.btnMakePic.TabIndex = 1;
            this.btnMakePic.Text = "保存并生成授权书";
            this.btnMakePic.UseVisualStyleBackColor = true;
            this.btnMakePic.Click += new System.EventHandler(this.btnMakePic_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(53, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 399);
            this.Controls.Add(this.panel1);
            this.Name = "AddUserForm";
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWeixinNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.DateTimePicker dtDateEnd;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMakePic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtAuthNow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTaobaoName;
        private System.Windows.Forms.OpenFileDialog ofPhotoFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAuthNo;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.CheckBox cbIsNoEdit;
        private System.Windows.Forms.Button btnQuery;

    }
}