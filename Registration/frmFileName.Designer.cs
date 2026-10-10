namespace Registration
{
    partial class frmFileName
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
            label1 = new Label();
            btnOkay = new Button();
            txtFileName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 1;
            label1.Text = "Enter File Name";
            // 
            // btnOkay
            // 
            btnOkay.BackColor = SystemColors.GradientActiveCaption;
            btnOkay.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOkay.Location = new Point(134, 116);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(94, 34);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(23, 64);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(314, 32);
            txtFileName.TabIndex = 0;
            // 
            // frmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(368, 184);
            Controls.Add(btnOkay);
            Controls.Add(label1);
            Controls.Add(txtFileName);
            Name = "frmFileName";
            Text = "frmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnOkay;
        private TextBox txtFileName;
    }
}