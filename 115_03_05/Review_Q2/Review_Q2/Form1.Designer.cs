using System.Windows.Forms;

namespace Review_Q2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 控制項宣告（有意義的名稱）
        private GroupBox grpOilAndLube;
        private CheckBox chkChangeOil;
        private CheckBox chkLubeJob;

        private GroupBox grpCleaning;
        private CheckBox chkRadiatorFlush;
        private CheckBox chkTransmissionFlush;

        private GroupBox grpOtherServices;
        private CheckBox chkInspection;
        private CheckBox chkReplaceMuffler;
        private CheckBox chkTireRotation;

        private GroupBox grpPartsAndLabor;
        private Label lblParts;
        private TextBox txtParts;
        private Label lblLaborHours;
        private TextBox txtLaborHours;

        private GroupBox grpSummary;
        private Label lblServiceLabor;
        private TextBox txtServiceLabor;
        private Label lblPartsCost;
        private TextBox txtPartsCost;
        private Label lblPartsTax;
        private TextBox txtPartsTax;
        private Label lblTotalCost;
        private TextBox txtTotalCost;

        private Button btnCalculateTotal;
        private Button btnClear;
        private Button btnExit;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOilAndLube = new System.Windows.Forms.GroupBox();
            this.chkChangeOil = new System.Windows.Forms.CheckBox();
            this.chkLubeJob = new System.Windows.Forms.CheckBox();
            this.grpCleaning = new System.Windows.Forms.GroupBox();
            this.chkRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.chkTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.grpOtherServices = new System.Windows.Forms.GroupBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.chkReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.chkTireRotation = new System.Windows.Forms.CheckBox();
            this.grpPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.lblLaborHours = new System.Windows.Forms.Label();
            this.txtLaborHours = new System.Windows.Forms.TextBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblServiceLabor = new System.Windows.Forms.Label();
            this.txtServiceLabor = new System.Windows.Forms.TextBox();
            this.lblPartsCost = new System.Windows.Forms.Label();
            this.txtPartsCost = new System.Windows.Forms.TextBox();
            this.lblPartsTax = new System.Windows.Forms.Label();
            this.txtPartsTax = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOilAndLube.SuspendLayout();
            this.grpCleaning.SuspendLayout();
            this.grpOtherServices.SuspendLayout();
            this.grpPartsAndLabor.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOilAndLube
            // 
            this.grpOilAndLube.Controls.Add(this.chkChangeOil);
            this.grpOilAndLube.Controls.Add(this.chkLubeJob);
            this.grpOilAndLube.Location = new System.Drawing.Point(12, 12);
            this.grpOilAndLube.Name = "grpOilAndLube";
            this.grpOilAndLube.Size = new System.Drawing.Size(200, 80);
            this.grpOilAndLube.TabIndex = 0;
            this.grpOilAndLube.TabStop = false;
            this.grpOilAndLube.Text = "機油和潤滑";
            // 
            // chkChangeOil
            // 
            this.chkChangeOil.AutoSize = true;
            this.chkChangeOil.Location = new System.Drawing.Point(12, 22);
            this.chkChangeOil.Name = "chkChangeOil";
            this.chkChangeOil.Size = new System.Drawing.Size(177, 22);
            this.chkChangeOil.TabIndex = 0;
            this.chkChangeOil.Text = "更換機油 (NT$780)";
            // 
            // chkLubeJob
            // 
            this.chkLubeJob.AutoSize = true;
            this.chkLubeJob.Location = new System.Drawing.Point(12, 46);
            this.chkLubeJob.Name = "chkLubeJob";
            this.chkLubeJob.Size = new System.Drawing.Size(177, 22);
            this.chkLubeJob.TabIndex = 1;
            this.chkLubeJob.Text = "潤滑保養 (NT$540)";
            // 
            // grpCleaning
            // 
            this.grpCleaning.Controls.Add(this.chkRadiatorFlush);
            this.grpCleaning.Controls.Add(this.chkTransmissionFlush);
            this.grpCleaning.Location = new System.Drawing.Point(220, 12);
            this.grpCleaning.Name = "grpCleaning";
            this.grpCleaning.Size = new System.Drawing.Size(241, 82);
            this.grpCleaning.TabIndex = 1;
            this.grpCleaning.TabStop = false;
            this.grpCleaning.Text = "清洗服務";
            // 
            // chkRadiatorFlush
            // 
            this.chkRadiatorFlush.AutoSize = true;
            this.chkRadiatorFlush.Location = new System.Drawing.Point(12, 22);
            this.chkRadiatorFlush.Name = "chkRadiatorFlush";
            this.chkRadiatorFlush.Size = new System.Drawing.Size(177, 22);
            this.chkRadiatorFlush.TabIndex = 0;
            this.chkRadiatorFlush.Text = "水箱清洗 (NT$900)";
            // 
            // chkTransmissionFlush
            // 
            this.chkTransmissionFlush.AutoSize = true;
            this.chkTransmissionFlush.Location = new System.Drawing.Point(12, 46);
            this.chkTransmissionFlush.Name = "chkTransmissionFlush";
            this.chkTransmissionFlush.Size = new System.Drawing.Size(207, 22);
            this.chkTransmissionFlush.TabIndex = 1;
            this.chkTransmissionFlush.Text = "變速箱清洗 (NT$2,400)";
            // 
            // grpOtherServices
            // 
            this.grpOtherServices.Controls.Add(this.chkInspection);
            this.grpOtherServices.Controls.Add(this.chkReplaceMuffler);
            this.grpOtherServices.Controls.Add(this.chkTireRotation);
            this.grpOtherServices.Location = new System.Drawing.Point(12, 100);
            this.grpOtherServices.Name = "grpOtherServices";
            this.grpOtherServices.Size = new System.Drawing.Size(214, 114);
            this.grpOtherServices.TabIndex = 2;
            this.grpOtherServices.TabStop = false;
            this.grpOtherServices.Text = "其他服務";
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(12, 22);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(141, 22);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "檢驗 (NT$450)";
            // 
            // chkReplaceMuffler
            // 
            this.chkReplaceMuffler.AutoSize = true;
            this.chkReplaceMuffler.Location = new System.Drawing.Point(12, 46);
            this.chkReplaceMuffler.Name = "chkReplaceMuffler";
            this.chkReplaceMuffler.Size = new System.Drawing.Size(207, 22);
            this.chkReplaceMuffler.TabIndex = 1;
            this.chkReplaceMuffler.Text = "更換消音器 (NT$3,000)";
            // 
            // chkTireRotation
            // 
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(12, 70);
            this.chkTireRotation.Name = "chkTireRotation";
            this.chkTireRotation.Size = new System.Drawing.Size(177, 22);
            this.chkTireRotation.TabIndex = 2;
            this.chkTireRotation.Text = "輪胎換位 (NT$600)";
            // 
            // grpPartsAndLabor
            // 
            this.grpPartsAndLabor.Controls.Add(this.lblParts);
            this.grpPartsAndLabor.Controls.Add(this.txtParts);
            this.grpPartsAndLabor.Controls.Add(this.lblLaborHours);
            this.grpPartsAndLabor.Controls.Add(this.txtLaborHours);
            this.grpPartsAndLabor.Location = new System.Drawing.Point(220, 100);
            this.grpPartsAndLabor.Name = "grpPartsAndLabor";
            this.grpPartsAndLabor.Size = new System.Drawing.Size(241, 92);
            this.grpPartsAndLabor.TabIndex = 3;
            this.grpPartsAndLabor.TabStop = false;
            this.grpPartsAndLabor.Text = "零件和工時";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(12, 28);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(91, 18);
            this.lblParts.TabIndex = 0;
            this.lblParts.Text = "零件 (NT$)";
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(129, 24);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(90, 29);
            this.txtParts.TabIndex = 1;
            // 
            // lblLaborHours
            // 
            this.lblLaborHours.AutoSize = true;
            this.lblLaborHours.Location = new System.Drawing.Point(12, 62);
            this.lblLaborHours.Name = "lblLaborHours";
            this.lblLaborHours.Size = new System.Drawing.Size(115, 18);
            this.lblLaborHours.TabIndex = 2;
            this.lblLaborHours.Text = "工時數 (小時)";
            // 
            // txtLaborHours
            // 
            this.txtLaborHours.Location = new System.Drawing.Point(149, 59);
            this.txtLaborHours.Name = "txtLaborHours";
            this.txtLaborHours.Size = new System.Drawing.Size(70, 29);
            this.txtLaborHours.TabIndex = 3;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblServiceLabor);
            this.grpSummary.Controls.Add(this.txtServiceLabor);
            this.grpSummary.Controls.Add(this.lblPartsCost);
            this.grpSummary.Controls.Add(this.txtPartsCost);
            this.grpSummary.Controls.Add(this.lblPartsTax);
            this.grpSummary.Controls.Add(this.txtPartsTax);
            this.grpSummary.Controls.Add(this.lblTotalCost);
            this.grpSummary.Controls.Add(this.txtTotalCost);
            this.grpSummary.Location = new System.Drawing.Point(12, 220);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(449, 90);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "費用摘要";
            // 
            // lblServiceLabor
            // 
            this.lblServiceLabor.AutoSize = true;
            this.lblServiceLabor.Location = new System.Drawing.Point(12, 22);
            this.lblServiceLabor.Name = "lblServiceLabor";
            this.lblServiceLabor.Size = new System.Drawing.Size(98, 18);
            this.lblServiceLabor.TabIndex = 0;
            this.lblServiceLabor.Text = "服務與工資";
            // 
            // txtServiceLabor
            // 
            this.txtServiceLabor.Location = new System.Drawing.Point(120, 18);
            this.txtServiceLabor.Name = "txtServiceLabor";
            this.txtServiceLabor.ReadOnly = true;
            this.txtServiceLabor.Size = new System.Drawing.Size(130, 29);
            this.txtServiceLabor.TabIndex = 1;
            // 
            // lblPartsCost
            // 
            this.lblPartsCost.AutoSize = true;
            this.lblPartsCost.Location = new System.Drawing.Point(12, 46);
            this.lblPartsCost.Name = "lblPartsCost";
            this.lblPartsCost.Size = new System.Drawing.Size(44, 18);
            this.lblPartsCost.TabIndex = 2;
            this.lblPartsCost.Text = "零件";
            // 
            // txtPartsCost
            // 
            this.txtPartsCost.Location = new System.Drawing.Point(120, 42);
            this.txtPartsCost.Name = "txtPartsCost";
            this.txtPartsCost.ReadOnly = true;
            this.txtPartsCost.Size = new System.Drawing.Size(130, 29);
            this.txtPartsCost.TabIndex = 3;
            // 
            // lblPartsTax
            // 
            this.lblPartsTax.AutoSize = true;
            this.lblPartsTax.Location = new System.Drawing.Point(260, 22);
            this.lblPartsTax.Name = "lblPartsTax";
            this.lblPartsTax.Size = new System.Drawing.Size(97, 18);
            this.lblPartsTax.TabIndex = 4;
            this.lblPartsTax.Text = "稅金 (零件)";
            // 
            // txtPartsTax
            // 
            this.txtPartsTax.Location = new System.Drawing.Point(357, 19);
            this.txtPartsTax.Name = "txtPartsTax";
            this.txtPartsTax.ReadOnly = true;
            this.txtPartsTax.Size = new System.Drawing.Size(70, 29);
            this.txtPartsTax.TabIndex = 5;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(260, 46);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(62, 18);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "總費用";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(357, 42);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(70, 29);
            this.txtTotalCost.TabIndex = 7;
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(40, 320);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(100, 30);
            this.btnCalculateTotal.TabIndex = 5;
            this.btnCalculateTotal.Text = "計算總額";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(160, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清除";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(280, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "離開";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(475, 361);
            this.Controls.Add(this.grpOilAndLube);
            this.Controls.Add(this.grpCleaning);
            this.Controls.Add(this.grpOtherServices);
            this.Controls.Add(this.grpPartsAndLabor);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "汽車維修服務";
            this.grpOilAndLube.ResumeLayout(false);
            this.grpOilAndLube.PerformLayout();
            this.grpCleaning.ResumeLayout(false);
            this.grpCleaning.PerformLayout();
            this.grpOtherServices.ResumeLayout(false);
            this.grpOtherServices.PerformLayout();
            this.grpPartsAndLabor.ResumeLayout(false);
            this.grpPartsAndLabor.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

