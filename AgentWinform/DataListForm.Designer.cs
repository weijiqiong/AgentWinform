namespace AgentWinform
{
    partial class DataListForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtAuthEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeixinNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtAuthStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameNo = new System.Windows.Forms.TextBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinxinNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaobaoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthPhotoPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 129);
            this.panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(224, 99);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 35;
            this.btnExport.Text = "数据导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(117, 99);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 35;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtAuthEnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWeixinNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtAuthStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNameNo);
            this.groupBox1.Controls.Add(this.cbArea);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 93);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "姓名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Location = new System.Drawing.Point(645, 54);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(127, 20);
            this.cbLevel.TabIndex = 33;
            this.cbLevel.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(583, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "代理级别";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(52, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 21);
            this.txtName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "授权有效日期";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtAuthEnd
            // 
            this.dtAuthEnd.Location = new System.Drawing.Point(261, 54);
            this.dtAuthEnd.Name = "dtAuthEnd";
            this.dtAuthEnd.Size = new System.Drawing.Size(127, 21);
            this.dtAuthEnd.TabIndex = 32;
            this.dtAuthEnd.Value = new System.DateTime(2088, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(401, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "地区";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // txtWeixinNo
            // 
            this.txtWeixinNo.Location = new System.Drawing.Point(256, 17);
            this.txtWeixinNo.Name = "txtWeixinNo";
            this.txtWeixinNo.Size = new System.Drawing.Size(127, 21);
            this.txtWeixinNo.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(235, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "至";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtAuthStart
            // 
            this.dtAuthStart.Location = new System.Drawing.Point(100, 54);
            this.dtAuthStart.Name = "dtAuthStart";
            this.dtAuthStart.Size = new System.Drawing.Size(127, 21);
            this.dtAuthStart.TabIndex = 31;
            this.dtAuthStart.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(417, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "身份证号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(206, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "微信号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNameNo
            // 
            this.txtNameNo.Location = new System.Drawing.Point(481, 17);
            this.txtNameNo.Name = "txtNameNo";
            this.txtNameNo.Size = new System.Drawing.Size(288, 21);
            this.txtNameNo.TabIndex = 24;
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(441, 54);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(127, 20);
            this.cbArea.TabIndex = 30;
            this.cbArea.Visible = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(14, 99);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "新增";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 298);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            this.dataGridViewList.AllowUserToOrderColumns = true;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.AuthNo,
            this.UserName,
            this.WinxinNo,
            this.TaobaoName,
            this.AuthDate,
            this.colAuthPhotoPath,
            this.ColEdit,
            this.colDel});
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.RowTemplate.Height = 23;
            this.dataGridViewList.Size = new System.Drawing.Size(915, 298);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellContentClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // AuthNo
            // 
            this.AuthNo.DataPropertyName = "AuthNo";
            this.AuthNo.HeaderText = "授权书编号";
            this.AuthNo.Name = "AuthNo";
            this.AuthNo.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "姓名";
            this.UserName.Name = "UserName";
            // 
            // WinxinNo
            // 
            this.WinxinNo.DataPropertyName = "WeixinNo";
            this.WinxinNo.HeaderText = "微信号";
            this.WinxinNo.Name = "WinxinNo";
            // 
            // TaobaoName
            // 
            this.TaobaoName.DataPropertyName = "TaobaoName";
            this.TaobaoName.HeaderText = "淘宝店名";
            this.TaobaoName.Name = "TaobaoName";
            this.TaobaoName.ReadOnly = true;
            // 
            // AuthDate
            // 
            this.AuthDate.DataPropertyName = "AuthNow";
            this.AuthDate.HeaderText = "授权日期";
            this.AuthDate.Name = "AuthDate";
            this.AuthDate.ReadOnly = true;
            // 
            // colAuthPhotoPath
            // 
            this.colAuthPhotoPath.DataPropertyName = "AuthPhotoPath";
            this.colAuthPhotoPath.HeaderText = "授权书";
            this.colAuthPhotoPath.Name = "colAuthPhotoPath";
            this.colAuthPhotoPath.ReadOnly = true;
            // 
            // ColEdit
            // 
            this.ColEdit.HeaderText = "";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.Text = "编辑";
            this.ColEdit.UseColumnTextForButtonValue = true;
            // 
            // colDel
            // 
            this.colDel.HeaderText = "";
            this.colDel.Name = "colDel";
            this.colDel.Text = "删除";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(330, 100);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 36;
            this.btnImport.Text = "数据导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // DataListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DataListForm";
            this.Text = "代理授权书管理系统";
            this.Load += new System.EventHandler(this.DataListForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtAuthEnd;
        private System.Windows.Forms.TextBox txtWeixinNo;
        private System.Windows.Forms.DateTimePicker dtAuthStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinxinNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaobaoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthPhotoPath;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}

