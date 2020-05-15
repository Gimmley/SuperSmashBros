namespace SmashBrosMatchMaker
{
    partial class Rules
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
            this.bttConfirm = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblHumans = new System.Windows.Forms.Label();
            this.txtPlayers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGameType = new System.Windows.Forms.ComboBox();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.lblItems = new System.Windows.Forms.Label();
            this.txbItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttConfirm
            // 
            this.bttConfirm.Location = new System.Drawing.Point(129, 349);
            this.bttConfirm.Name = "bttConfirm";
            this.bttConfirm.Size = new System.Drawing.Size(84, 38);
            this.bttConfirm.TabIndex = 0;
            this.bttConfirm.Text = "Confirm";
            this.bttConfirm.UseVisualStyleBackColor = true;
            this.bttConfirm.Click += new System.EventHandler(this.bttConfirm_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(168, 315);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 1;
            this.lblError.Text = " ";
            // 
            // lblHumans
            // 
            this.lblHumans.AutoSize = true;
            this.lblHumans.Location = new System.Drawing.Point(40, 88);
            this.lblHumans.Name = "lblHumans";
            this.lblHumans.Size = new System.Drawing.Size(101, 13);
            this.lblHumans.TabIndex = 3;
            this.lblHumans.Text = "How Many Players?";
            // 
            // txtPlayers
            // 
            this.txtPlayers.Location = new System.Drawing.Point(206, 88);
            this.txtPlayers.Name = "txtPlayers";
            this.txtPlayers.Size = new System.Drawing.Size(121, 20);
            this.txtPlayers.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stock or Time Limit?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Are there items?";
            // 
            // cmbGameType
            // 
            this.cmbGameType.FormattingEnabled = true;
            this.cmbGameType.Items.AddRange(new object[] {
            "Stock",
            "Time Limit"});
            this.cmbGameType.Location = new System.Drawing.Point(206, 236);
            this.cmbGameType.Name = "cmbGameType";
            this.cmbGameType.Size = new System.Drawing.Size(121, 21);
            this.cmbGameType.TabIndex = 8;
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Location = new System.Drawing.Point(206, 190);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(43, 17);
            this.rdbYes.TabIndex = 9;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            this.rdbYes.CheckedChanged += new System.EventHandler(this.rdbYes_CheckedChanged);
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(288, 190);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 10;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(40, 285);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(89, 13);
            this.lblItems.TabIndex = 11;
            this.lblItems.Text = "Percent of items: ";
            this.lblItems.Visible = false;
            // 
            // txbItems
            // 
            this.txbItems.Location = new System.Drawing.Point(206, 285);
            this.txbItems.Name = "txbItems";
            this.txbItems.Size = new System.Drawing.Size(121, 20);
            this.txbItems.TabIndex = 12;
            this.txbItems.Visible = false;
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.txbItems);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.rdbYes);
            this.Controls.Add(this.cmbGameType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayers);
            this.Controls.Add(this.lblHumans);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.bttConfirm);
            this.Name = "Rules";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttConfirm;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblHumans;
        private System.Windows.Forms.TextBox txtPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGameType;
        private System.Windows.Forms.RadioButton rdbYes;
      private System.Windows.Forms.RadioButton rdbNo;
      private System.Windows.Forms.Label lblItems;
      private System.Windows.Forms.TextBox txbItems;
   }
}

