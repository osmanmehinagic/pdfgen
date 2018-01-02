namespace ReportGenerator.WinUI
{
    partial class GeneratorForm
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblNumberOfRows = new System.Windows.Forms.Label();
            this.tbNumberOfRows = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(12, 61);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(154, 27);
            this.btnGenerateReport.TabIndex = 0;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // lblNumberOfRows
            // 
            this.lblNumberOfRows.AutoSize = true;
            this.lblNumberOfRows.Location = new System.Drawing.Point(12, 26);
            this.lblNumberOfRows.Name = "lblNumberOfRows";
            this.lblNumberOfRows.Size = new System.Drawing.Size(85, 17);
            this.lblNumberOfRows.TabIndex = 1;
            this.lblNumberOfRows.Text = "Broj redova:";
            // 
            // tbNumberOfRows
            // 
            this.tbNumberOfRows.Location = new System.Drawing.Point(103, 23);
            this.tbNumberOfRows.Name = "tbNumberOfRows";
            this.tbNumberOfRows.Size = new System.Drawing.Size(90, 22);
            this.tbNumberOfRows.TabIndex = 2;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 253);
            this.Controls.Add(this.tbNumberOfRows);
            this.Controls.Add(this.lblNumberOfRows);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "Generator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblNumberOfRows;
        private System.Windows.Forms.TextBox tbNumberOfRows;
    }
}

