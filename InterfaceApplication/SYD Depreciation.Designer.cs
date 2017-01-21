namespace InterfaceApplication
{
    partial class FrmSYDDepreciation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInitialCost = new System.Windows.Forms.TextBox();
            this.txtFinalCost = new System.Windows.Forms.TextBox();
            this.txtLifeAsset = new System.Windows.Forms.TextBox();
            this.txtSYDDepreciation = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Cost of Asset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final Cost of Asset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Life of Asset in Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SYD Depreciation";
            // 
            // txtInitialCost
            // 
            this.txtInitialCost.Location = new System.Drawing.Point(167, 13);
            this.txtInitialCost.Name = "txtInitialCost";
            this.txtInitialCost.Size = new System.Drawing.Size(126, 20);
            this.txtInitialCost.TabIndex = 4;
            // 
            // txtFinalCost
            // 
            this.txtFinalCost.Location = new System.Drawing.Point(167, 41);
            this.txtFinalCost.Name = "txtFinalCost";
            this.txtFinalCost.Size = new System.Drawing.Size(126, 20);
            this.txtFinalCost.TabIndex = 5;
            // 
            // txtLifeAsset
            // 
            this.txtLifeAsset.Location = new System.Drawing.Point(167, 72);
            this.txtLifeAsset.Name = "txtLifeAsset";
            this.txtLifeAsset.Size = new System.Drawing.Size(126, 20);
            this.txtLifeAsset.TabIndex = 6;
            // 
            // txtSYDDepreciation
            // 
            this.txtSYDDepreciation.Location = new System.Drawing.Point(38, 142);
            this.txtSYDDepreciation.Multiline = true;
            this.txtSYDDepreciation.Name = "txtSYDDepreciation";
            this.txtSYDDepreciation.Size = new System.Drawing.Size(314, 106);
            this.txtSYDDepreciation.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(133, 271);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(274, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmSYDDepreciation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 311);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSYDDepreciation);
            this.Controls.Add(this.txtLifeAsset);
            this.Controls.Add(this.txtFinalCost);
            this.Controls.Add(this.txtInitialCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSYDDepreciation";
            this.Text = "SYD Depreciation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInitialCost;
        private System.Windows.Forms.TextBox txtFinalCost;
        private System.Windows.Forms.TextBox txtLifeAsset;
        private System.Windows.Forms.TextBox txtSYDDepreciation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}