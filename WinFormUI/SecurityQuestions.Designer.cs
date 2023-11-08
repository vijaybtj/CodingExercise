namespace WinFormUI
{
    partial class SecurityQuestions
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
            this.cmbQuestion1 = new System.Windows.Forms.ComboBox();
            this.cmbQuestion2 = new System.Windows.Forms.ComboBox();
            this.cmbQuestion3 = new System.Windows.Forms.ComboBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbQuestion1
            // 
            this.cmbQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestion1.FormattingEnabled = true;
            this.cmbQuestion1.Location = new System.Drawing.Point(21, 31);
            this.cmbQuestion1.Name = "cmbQuestion1";
            this.cmbQuestion1.Size = new System.Drawing.Size(609, 32);
            this.cmbQuestion1.TabIndex = 0;
            this.cmbQuestion1.SelectedIndexChanged += new System.EventHandler(this.cmbQuestion1_SelectedIndexChanged);
            // 
            // cmbQuestion2
            // 
            this.cmbQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestion2.FormattingEnabled = true;
            this.cmbQuestion2.Location = new System.Drawing.Point(21, 81);
            this.cmbQuestion2.Name = "cmbQuestion2";
            this.cmbQuestion2.Size = new System.Drawing.Size(609, 32);
            this.cmbQuestion2.TabIndex = 2;
            this.cmbQuestion2.SelectedIndexChanged += new System.EventHandler(this.cmbQuestion2_SelectedIndexChanged);
            // 
            // cmbQuestion3
            // 
            this.cmbQuestion3.DropDownHeight = 140;
            this.cmbQuestion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestion3.FormattingEnabled = true;
            this.cmbQuestion3.IntegralHeight = false;
            this.cmbQuestion3.ItemHeight = 24;
            this.cmbQuestion3.Location = new System.Drawing.Point(21, 130);
            this.cmbQuestion3.Name = "cmbQuestion3";
            this.cmbQuestion3.Size = new System.Drawing.Size(609, 32);
            this.cmbQuestion3.TabIndex = 4;
            this.cmbQuestion3.SelectedIndexChanged += new System.EventHandler(this.cmbQuestion3_SelectedIndexChanged);
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(636, 34);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(131, 29);
            this.txtAnswer1.TabIndex = 1;
            this.txtAnswer1.TextChanged += new System.EventHandler(this.txtAnswer1_TextChanged);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(636, 84);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(131, 29);
            this.txtAnswer2.TabIndex = 3;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3.Location = new System.Drawing.Point(636, 133);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(131, 29);
            this.txtAnswer3.TabIndex = 5;
            this.txtAnswer3.TextChanged += new System.EventHandler(this.txtAnswer3_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(576, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.ForeColor = System.Drawing.Color.Red;
            this.btnDecline.Location = new System.Drawing.Point(657, 177);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(110, 37);
            this.btnDecline.TabIndex = 7;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // SecurityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 226);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.cmbQuestion3);
            this.Controls.Add(this.cmbQuestion2);
            this.Controls.Add(this.cmbQuestion1);
            this.Name = "SecurityQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Security Questions";
            this.Load += new System.EventHandler(this.SecurityQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbQuestion1;
        private System.Windows.Forms.ComboBox cmbQuestion2;
        private System.Windows.Forms.ComboBox cmbQuestion3;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDecline;
    }
}