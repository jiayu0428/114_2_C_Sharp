namespace Q2_1
{
    partial class Form4
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 540);
            this.Name = "Form4";
            this.Text = "修改員工資料";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("新細明體", 28F);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "修改員工資料";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblID.Location = new System.Drawing.Point(40, 96);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(120, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "員工編號：";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtID.Location = new System.Drawing.Point(210, 92);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(420, 34);
            this.txtID.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnQuery.Location = new System.Drawing.Point(330, 140);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 36);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblName.Location = new System.Drawing.Point(40, 200);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtName.Location = new System.Drawing.Point(210, 196);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(420, 34);
            this.txtName.TabIndex = 5;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblDept.Location = new System.Drawing.Point(40, 250);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(72, 25);
            this.lblDept.TabIndex = 6;
            this.lblDept.Text = "部門：";
            // 
            // txtDept
            // 
            this.txtDept.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtDept.Location = new System.Drawing.Point(210, 246);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(420, 34);
            this.txtDept.TabIndex = 7;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblJob.Location = new System.Drawing.Point(40, 300);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(72, 25);
            this.lblJob.TabIndex = 8;
            this.lblJob.Text = "職稱：";
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtJob.Location = new System.Drawing.Point(210, 296);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(420, 34);
            this.txtJob.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnSave.Location = new System.Drawing.Point(260, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnClose.Location = new System.Drawing.Point(380, 350);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "離開";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelOutput
            // 
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutput.Location = new System.Drawing.Point(30, 410);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(700, 100);
            this.panelOutput.TabIndex = 12;
            // 
            // Add controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelOutput);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelOutput;
    }
}