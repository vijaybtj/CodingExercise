namespace WinFormUI
{
    partial class UpdateSecurityQuestions
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
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.cmbQuestion3 = new System.Windows.Forms.ComboBox();
            this.cmbQuestion2 = new System.Windows.Forms.ComboBox();
            this.cmbQuestion1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.ForeColor = System.Drawing.Color.Red;
            this.btnDecline.Location = new System.Drawing.Point(639, 190);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(110, 37);
            this.btnDecline.TabIndex = 15;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(549, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3.Location = new System.Drawing.Point(618, 146);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(131, 29);
            this.txtAnswer3.TabIndex = 13;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(618, 97);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(131, 29);
            this.txtAnswer2.TabIndex = 11;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(618, 47);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(131, 29);
            this.txtAnswer1.TabIndex = 9;
            this.txtAnswer1.TextChanged += new System.EventHandler(this.txtAnswer1_TextChanged);
            // 
            // cmbQuestion3
            // 
            this.cmbQuestion3.DropDownHeight = 140;
            this.cmbQuestion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestion3.FormattingEnabled = true;
            this.cmbQuestion3.IntegralHeight = false;
            this.cmbQuestion3.ItemHeight = 24;
            this.cmbQuestion3.Location = new System.Drawing.Point(3, 143);
            this.cmbQuestion3.Name = "cmbQuestion3";
            this.cmbQuestion3.Size = new System.Drawing.Size(609, 32);
            this.cmbQuestion3.TabIndex = 12;
            // 
            // cmbQuestion2
            // 
            this.cmbQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestion2.FormattingEnabled = true;
            this.cmbQuestion2.Location = new System.Drawing.Point(3, 94);
            this.cmbQuestion2.Name = "cmbQuestion2";
            this.cmbQuestion2.Size = new System.Drawing.Size(609, 32);
            this.cmbQuestion2.TabIndex = 10;
            // 
            // cmbQuestion1
            // 
            this.cmbQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestion1.FormattingEnabled = true;
            this.cmbQuestion1.Location = new System.Drawing.Point(3, 44);
            this.cmbQuestion1.Name = "cmbQuestion1";
            this.cmbQuestion1.Size = new System.Drawing.Size(609, 32);
            this.cmbQuestion1.TabIndex = 8;
            // 
            // UpdateSecurityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 244);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.cmbQuestion3);
            this.Controls.Add(this.cmbQuestion2);
            this.Controls.Add(this.cmbQuestion1);
            this.Name = "UpdateSecurityQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Security Questions";
            this.Load += new System.EventHandler(this.UpdateSecurityQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.ComboBox cmbQuestion3;
        private System.Windows.Forms.ComboBox cmbQuestion2;
        private System.Windows.Forms.ComboBox cmbQuestion1;
    }
}