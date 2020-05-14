namespace SmashBrosMatchMaker.forms
{
   partial class Choose_Winner
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
            this.cmbWinner = new System.Windows.Forms.ComboBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbWinner
            // 
            this.cmbWinner.FormattingEnabled = true;
            this.cmbWinner.Location = new System.Drawing.Point(79, 119);
            this.cmbWinner.Name = "cmbWinner";
            this.cmbWinner.Size = new System.Drawing.Size(121, 21);
            this.cmbWinner.TabIndex = 14;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(26, 122);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(47, 13);
            this.lblPlayer1.TabIndex = 13;
            this.lblPlayer1.Text = "Winner: ";            
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "View Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Choose_Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbWinner);
            this.Controls.Add(this.lblPlayer1);
            this.Name = "Choose_Winner";
            this.Text = "Choose_Winner";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox cmbWinner;
      private System.Windows.Forms.Label lblPlayer1;
      private System.Windows.Forms.Button button1;
   }
}