namespace Registration
{
    partial class frmLab1
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
            btnCreate = new Button();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.GradientActiveCaption;
            btnCreate.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(118, 138);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(98, 33);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(64, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(225, 105);
            txtInput.TabIndex = 0;
            // 
            // frmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(358, 198);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Name = "frmLab1";
            Text = "frmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreate;
        private TextBox txtInput;
    }
}