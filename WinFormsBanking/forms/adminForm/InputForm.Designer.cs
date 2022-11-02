namespace WinFormsBanking.forms.adminForm {
    partial class InputForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bOK = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(168, 89);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(94, 29);
            this.bOK.TabIndex = 0;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.Location = new System.Drawing.Point(45, 40);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(356, 31);
            this.tbInput.TabIndex = 1;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.Location = new System.Drawing.Point(47, 12);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(36, 20);
            this.lText.TabIndex = 2;
            this.lText.Text = "Text";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 139);
            this.Controls.Add(this.lText);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.bOK);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bOK;
        private TextBox tbInput;
        private Label lText;
    }
}