namespace RatHealth
{
    partial class Rat_ID
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.ratid = new System.Windows.Forms.TextBox();
            this.save_ratID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(25, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rat ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(23, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(123, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 6;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // ratid
            // 
            this.ratid.Location = new System.Drawing.Point(123, 89);
            this.ratid.Name = "ratid";
            this.ratid.Size = new System.Drawing.Size(100, 20);
            this.ratid.TabIndex = 7;
            this.ratid.TextChanged += new System.EventHandler(this.ratid_TextChanged);
            // 
            // save_ratID
            // 
            this.save_ratID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.save_ratID.Cursor = System.Windows.Forms.Cursors.Default;
            this.save_ratID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_ratID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.save_ratID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_ratID.Location = new System.Drawing.Point(74, 137);
            this.save_ratID.Name = "save_ratID";
            this.save_ratID.Size = new System.Drawing.Size(133, 32);
            this.save_ratID.TabIndex = 11;
            this.save_ratID.Text = "SUBMIT";
            this.save_ratID.UseVisualStyleBackColor = false;
            this.save_ratID.Click += new System.EventHandler(this.save_ratID_Click);
            // 
            // Rat_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(280, 190);
            this.Controls.Add(this.save_ratID);
            this.Controls.Add(this.ratid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "Rat_ID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rat_ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox ratid;
        private System.Windows.Forms.Button save_ratID;

        
    }
}