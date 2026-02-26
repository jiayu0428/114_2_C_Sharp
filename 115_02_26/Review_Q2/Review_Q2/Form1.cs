namespace Review_Q2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            
            // 主容器和標題
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            
            // Form 設定
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Name = "Form1";
            this.Text = "汽車維修修服務";
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            
            // ===== 左側面板 =====
            GroupBox groupBoxEngineOil = new GroupBox();
            groupBoxEngineOil.Text = "機油和潤滑";
            groupBoxEngineOil.Location = new System.Drawing.Point(12, 12);
            groupBoxEngineOil.Size = new System.Drawing.Size(320, 120);
            groupBoxEngineOil.TabIndex = 0;
            
            CheckBox chk1 = new CheckBox();
            chk1.Text = "更換機油 (NT$780)";
            chk1.Location = new System.Drawing.Point(10, 25);
            chk1.Size = new System.Drawing.Size(300, 24);
            groupBoxEngineOil.Controls.Add(chk1);
            
            CheckBox chk2 = new CheckBox();
            chk2.Text = "潤滑保養 (NT$540)";
            chk2.Location = new System.Drawing.Point(10, 55);
            chk2.Size = new System.Drawing.Size(300, 24);
            groupBoxEngineOil.Controls.Add(chk2);
            
            this.Controls.Add(groupBoxEngineOil);
            
            // ===== 基礎服務 =====
            GroupBox groupBoxBasicServices = new GroupBox();
            groupBoxBasicServices.Text = "基礎服務";
            groupBoxBasicServices.Location = new System.Drawing.Point(12, 140);
            groupBoxBasicServices.Size = new System.Drawing.Size(320, 150);
            groupBoxBasicServices.TabIndex = 1;
            
            CheckBox chk3 = new CheckBox();
            chk3.Text = "檢修 (NT$450)";
            chk3.Location = new System.Drawing.Point(10, 25);
            chk3.Size = new System.Drawing.Size(300, 24);
            groupBoxBasicServices.Controls.Add(chk3);
            
            CheckBox chk4 = new CheckBox();
            chk4.Text = "電池污清器 (NT$3,000)";
            chk4.Location = new System.Drawing.Point(10, 55);
            chk4.Size = new System.Drawing.Size(300, 24);
            groupBoxBasicServices.Controls.Add(chk4);
            
            CheckBox chk5 = new CheckBox();
            chk5.Text = "輪胎檢位 (NT$600)";
            chk5.Location = new System.Drawing.Point(10, 85);
            chk5.Size = new System.Drawing.Size(300, 24);
            groupBoxBasicServices.Controls.Add(chk5);
            
            this.Controls.Add(groupBoxBasicServices);
            
            // ===== 右側面板 - 清洗服務 =====
            GroupBox groupBoxCleaningServices = new GroupBox();
            groupBoxCleaningServices.Text = "清洗服務";
            groupBoxCleaningServices.Location = new System.Drawing.Point(348, 12);
            groupBoxCleaningServices.Size = new System.Drawing.Size(320, 120);
            groupBoxCleaningServices.TabIndex = 2;
            
            CheckBox chk6 = new CheckBox();
            chk6.Text = "水冰清洗 (NT$900)";
            chk6.Location = new System.Drawing.Point(10, 25);
            chk6.Size = new System.Drawing.Size(300, 24);
            groupBoxCleaningServices.Controls.Add(chk6);
            
            CheckBox chk7 = new CheckBox();
            chk7.Text = "變速箱清洗 (NT$2,400)";
            chk7.Location = new System.Drawing.Point(10, 55);
            chk7.Size = new System.Drawing.Size(300, 24);
            groupBoxCleaningServices.Controls.Add(chk7);
            
            this.Controls.Add(groupBoxCleaningServices);
            
            // ===== 右側面板 - 零件和工時 =====
            GroupBox groupBoxParts = new GroupBox();
            groupBoxParts.Text = "零件和工時";
            groupBoxParts.Location = new System.Drawing.Point(348, 140);
            groupBoxParts.Size = new System.Drawing.Size(320, 150);
            groupBoxParts.TabIndex = 3;
            
            Label lblParts = new Label();
            lblParts.Text = "零件 (NT$)";
            lblParts.Location = new System.Drawing.Point(10, 25);
            lblParts.Size = new System.Drawing.Size(80, 24);
            groupBoxParts.Controls.Add(lblParts);
            
            TextBox txtParts = new TextBox();
            txtParts.Location = new System.Drawing.Point(100, 25);
            txtParts.Size = new System.Drawing.Size(200, 24);
            groupBoxParts.Controls.Add(txtParts);
            
            Label lblWorkHours = new Label();
            lblWorkHours.Text = "工資費 (小時)";
            lblWorkHours.Location = new System.Drawing.Point(10, 65);
            lblWorkHours.Size = new System.Drawing.Size(80, 24);
            groupBoxParts.Controls.Add(lblWorkHours);
            
            TextBox txtWorkHours = new TextBox();
            txtWorkHours.Location = new System.Drawing.Point(100, 65);
            txtWorkHours.Size = new System.Drawing.Size(200, 24);
            groupBoxParts.Controls.Add(txtWorkHours);
            
            Label lblHourlyRate = new Label();
            lblHourlyRate.Text = "時薪 (NT$/小時)";
            lblHourlyRate.Location = new System.Drawing.Point(10, 105);
            lblHourlyRate.Size = new System.Drawing.Size(80, 24);
            groupBoxParts.Controls.Add(lblHourlyRate);
            
            TextBox txtHourlyRate = new TextBox();
            txtHourlyRate.Location = new System.Drawing.Point(100, 105);
            txtHourlyRate.Size = new System.Drawing.Size(200, 24);
            groupBoxParts.Controls.Add(txtHourlyRate);
            
            this.Controls.Add(groupBoxParts);
            
            // ===== 費用摘要 =====
            GroupBox groupBoxSummary = new GroupBox();
            groupBoxSummary.Text = "費用摘要";
            groupBoxSummary.Location = new System.Drawing.Point(12, 300);
            groupBoxSummary.Size = new System.Drawing.Size(656, 150);
            groupBoxSummary.TabIndex = 4;
            
            Label lblServices = new Label();
            lblServices.Text = "服務和工資";
            lblServices.Location = new System.Drawing.Point(10, 25);
            lblServices.Size = new System.Drawing.Size(80, 24);
            groupBoxSummary.Controls.Add(lblServices);
            
            TextBox txtServices = new TextBox();
            txtServices.ReadOnly = true;
            txtServices.Location = new System.Drawing.Point(100, 25);
            txtServices.Size = new System.Drawing.Size(540, 24);
            groupBoxSummary.Controls.Add(txtServices);
            
            Label lblParts2 = new Label();
            lblParts2.Text = "零件";
            lblParts2.Location = new System.Drawing.Point(10, 60);
            lblParts2.Size = new System.Drawing.Size(80, 24);
            groupBoxSummary.Controls.Add(lblParts2);
            
            TextBox txtPartsDisplay = new TextBox();
            txtPartsDisplay.ReadOnly = true;
            txtPartsDisplay.Location = new System.Drawing.Point(100, 60);
            txtPartsDisplay.Size = new System.Drawing.Size(540, 24);
            groupBoxSummary.Controls.Add(txtPartsDisplay);
            
            Label lblTax = new Label();
            lblTax.Text = "稅金 (零件)";
            lblTax.Location = new System.Drawing.Point(10, 95);
            lblTax.Size = new System.Drawing.Size(80, 24);
            groupBoxSummary.Controls.Add(lblTax);
            
            TextBox txtTax = new TextBox();
            txtTax.ReadOnly = true;
            txtTax.Location = new System.Drawing.Point(100, 95);
            txtTax.Size = new System.Drawing.Size(540, 24);
            groupBoxSummary.Controls.Add(txtTax);
            
            this.Controls.Add(groupBoxSummary);
            
            // ===== 按鈕面板 =====
            Button btnCalculate = new Button();
            btnCalculate.Text = "計算總額";
            btnCalculate.Location = new System.Drawing.Point(117, 465);
            btnCalculate.Size = new System.Drawing.Size(100, 40);
            btnCalculate.TabIndex = 5;
            this.Controls.Add(btnCalculate);
            
            Button btnClear = new Button();
            btnClear.Text = "清除";
            btnClear.Location = new System.Drawing.Point(300, 465);
            btnClear.Size = new System.Drawing.Size(100, 40);
            btnClear.TabIndex = 6;
            this.Controls.Add(btnClear);
            
            Button btnExit = new Button();
            btnExit.Text = "離開";
            btnExit.Location = new System.Drawing.Point(483, 465);
            btnExit.Size = new System.Drawing.Size(100, 40);
            btnExit.TabIndex = 7;
            this.Controls.Add(btnExit);
            
            this.ResumeLayout(false);
        }

        #endregion
    }
}
