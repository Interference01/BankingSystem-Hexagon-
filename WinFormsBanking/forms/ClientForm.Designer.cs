namespace WinFormsBanking.forms {
    partial class ClientForm {
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
            this.lInfo = new System.Windows.Forms.Label();
            this.bShowBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(12, 9);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(35, 20);
            this.lInfo.TabIndex = 0;
            this.lInfo.Text = "Info";
            // 
            // bShowBalance
            // 
            this.bShowBalance.Location = new System.Drawing.Point(66, 57);
            this.bShowBalance.Name = "bShowBalance";
            this.bShowBalance.Size = new System.Drawing.Size(145, 52);
            this.bShowBalance.TabIndex = 1;
            this.bShowBalance.Text = "button1";
            this.bShowBalance.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 582);
            this.Controls.Add(this.bShowBalance);
            this.Controls.Add(this.lInfo);
            this.Name = "ClientForm";
            this.Text = "ClientPage";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lInfo;
        private Button bShowBalance;
    }
}