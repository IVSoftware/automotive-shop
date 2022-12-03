
namespace automotive_shop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxLubeJob = new System.Windows.Forms.CheckBox();
            this.checkBoxOilChange = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalFees = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.textBoxLabor = new System.Windows.Forms.TextBox();
            this.textBoxAdditionalParts = new System.Windows.Forms.TextBox();
            this.textBoxStandardServiceCharge = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLubeJob);
            this.groupBox1.Controls.Add(this.checkBoxOilChange);
            this.groupBox1.Location = new System.Drawing.Point(27, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // checkBoxLubeJob
            // 
            this.checkBoxLubeJob.AutoSize = true;
            this.checkBoxLubeJob.Location = new System.Drawing.Point(21, 93);
            this.checkBoxLubeJob.Name = "checkBoxLubeJob";
            this.checkBoxLubeJob.Size = new System.Drawing.Size(109, 29);
            this.checkBoxLubeJob.TabIndex = 0;
            this.checkBoxLubeJob.TabStop = false;
            this.checkBoxLubeJob.Text = "Lube Job";
            this.checkBoxLubeJob.UseVisualStyleBackColor = true;
            // 
            // checkBoxOilChange
            // 
            this.checkBoxOilChange.AutoSize = true;
            this.checkBoxOilChange.Location = new System.Drawing.Point(21, 45);
            this.checkBoxOilChange.Name = "checkBoxOilChange";
            this.checkBoxOilChange.Size = new System.Drawing.Size(125, 29);
            this.checkBoxOilChange.TabIndex = 0;
            this.checkBoxOilChange.TabStop = false;
            this.checkBoxOilChange.Text = "Oil Change";
            this.checkBoxOilChange.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxTotalFees);
            this.groupBox2.Controls.Add(this.textBoxTax);
            this.groupBox2.Controls.Add(this.textBoxLabor);
            this.groupBox2.Controls.Add(this.textBoxAdditionalParts);
            this.groupBox2.Controls.Add(this.textBoxStandardServiceCharge);
            this.groupBox2.Location = new System.Drawing.Point(27, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 275);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tax (on Parts)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Labor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Additional Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Standard Service Charges";
            // 
            // textBoxTotalFees
            // 
            this.textBoxTotalFees.Location = new System.Drawing.Point(242, 202);
            this.textBoxTotalFees.Name = "textBoxTotalFees";
            this.textBoxTotalFees.ReadOnly = true;
            this.textBoxTotalFees.Size = new System.Drawing.Size(69, 31);
            this.textBoxTotalFees.TabIndex = 5;
            this.textBoxTotalFees.TabStop = false;
            this.textBoxTotalFees.Text = "0.00";
            this.textBoxTotalFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(242, 165);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(69, 31);
            this.textBoxTax.TabIndex = 6;
            this.textBoxTax.TabStop = false;
            this.textBoxTax.Text = "0.00";
            this.textBoxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLabor
            // 
            this.textBoxLabor.Location = new System.Drawing.Point(242, 128);
            this.textBoxLabor.Name = "textBoxLabor";
            this.textBoxLabor.Size = new System.Drawing.Size(69, 31);
            this.textBoxLabor.TabIndex = 2;
            this.textBoxLabor.Text = "0.00";
            this.textBoxLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAdditionalParts
            // 
            this.textBoxAdditionalParts.Location = new System.Drawing.Point(242, 91);
            this.textBoxAdditionalParts.Name = "textBoxAdditionalParts";
            this.textBoxAdditionalParts.Size = new System.Drawing.Size(69, 31);
            this.textBoxAdditionalParts.TabIndex = 1;
            this.textBoxAdditionalParts.Text = "0.00";
            this.textBoxAdditionalParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxStandardServiceCharge
            // 
            this.textBoxStandardServiceCharge.Location = new System.Drawing.Point(242, 54);
            this.textBoxStandardServiceCharge.Name = "textBoxStandardServiceCharge";
            this.textBoxStandardServiceCharge.ReadOnly = true;
            this.textBoxStandardServiceCharge.Size = new System.Drawing.Size(69, 31);
            this.textBoxStandardServiceCharge.TabIndex = 7;
            this.textBoxStandardServiceCharge.TabStop = false;
            this.textBoxStandardServiceCharge.Text = "0.00";
            this.textBoxStandardServiceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(337, 558);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 34);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 604);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Work Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxLubeJob;
        private System.Windows.Forms.CheckBox checkBoxOilChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalFees;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.TextBox textBoxLabor;
        private System.Windows.Forms.TextBox textBoxAdditionalParts;
        private System.Windows.Forms.TextBox textBoxStandardServiceCharge;
        private System.Windows.Forms.Button buttonClear;
    }
}

