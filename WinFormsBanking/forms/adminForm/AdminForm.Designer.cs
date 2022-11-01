namespace WinFormsBanking.forms {
    partial class AdminForm {
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
            this.bRegisterClient = new System.Windows.Forms.Button();
            this.bShowAllClients = new System.Windows.Forms.Button();
            this.bAddCard = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWindowShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bRegisterClient
            // 
            this.bRegisterClient.Location = new System.Drawing.Point(202, 48);
            this.bRegisterClient.Name = "bRegisterClient";
            this.bRegisterClient.Size = new System.Drawing.Size(194, 72);
            this.bRegisterClient.TabIndex = 1;
            this.bRegisterClient.Text = "Register new client";
            this.bRegisterClient.UseVisualStyleBackColor = true;
            this.bRegisterClient.Click += new System.EventHandler(this.bRegisterClient_Click);
            // 
            // bShowAllClients
            // 
            this.bShowAllClients.Location = new System.Drawing.Point(202, 153);
            this.bShowAllClients.Name = "bShowAllClients";
            this.bShowAllClients.Size = new System.Drawing.Size(194, 72);
            this.bShowAllClients.TabIndex = 2;
            this.bShowAllClients.Text = "Show all clients";
            this.bShowAllClients.UseVisualStyleBackColor = true;
            this.bShowAllClients.Click += new System.EventHandler(this.bShowAllClients_Click);
            // 
            // bAddCard
            // 
            this.bAddCard.Location = new System.Drawing.Point(202, 256);
            this.bAddCard.Name = "bAddCard";
            this.bAddCard.Size = new System.Drawing.Size(194, 72);
            this.bAddCard.TabIndex = 3;
            this.bAddCard.Text = "Add card for client";
            this.bAddCard.UseVisualStyleBackColor = true;
            this.bAddCard.Click += new System.EventHandler(this.bAddCard_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(202, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 72);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(202, 465);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 72);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Name";
            // 
            // tbWindowShow
            // 
            this.tbWindowShow.Location = new System.Drawing.Point(468, 48);
            this.tbWindowShow.Multiline = true;
            this.tbWindowShow.Name = "tbWindowShow";
            this.tbWindowShow.Size = new System.Drawing.Size(452, 489);
            this.tbWindowShow.TabIndex = 6;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 577);
            this.Controls.Add(this.tbWindowShow);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bAddCard);
            this.Controls.Add(this.bShowAllClients);
            this.Controls.Add(this.bRegisterClient);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bRegisterClient;
        private Button bShowAllClients;
        private Button bAddCard;
        private Button button4;
        private Button button5;
        private Label label1;
        private TextBox tbWindowShow;
    }
}