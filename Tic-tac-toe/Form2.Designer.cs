namespace Tic_tac_toe
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblNotify = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCloseForm2 = new System.Windows.Forms.Button();
            
            this.SuspendLayout();
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.Location = new System.Drawing.Point(12, 9);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(122, 25);
            this.lblNotify.TabIndex = 0;
            this.lblNotify.Text = "Thông tin : ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(254, 333);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnCloseForm2
            // 
            this.btnCloseForm2.BackColor = System.Drawing.Color.Lime;
            this.btnCloseForm2.FlatAppearance.BorderSize = 0;
            this.btnCloseForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm2.ForeColor = System.Drawing.Color.Black;
            this.btnCloseForm2.Location = new System.Drawing.Point(189, 387);
            this.btnCloseForm2.Name = "btnCloseForm2";
            this.btnCloseForm2.Size = new System.Drawing.Size(82, 31);
            this.btnCloseForm2.TabIndex = 12;
            this.btnCloseForm2.Text = "Đóng";
            this.btnCloseForm2.UseVisualStyleBackColor = false;
            this.btnCloseForm2.Click += new System.EventHandler(this.btnCloseForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(283, 430);
            this.Controls.Add(this.btnCloseForm2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNotify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCloseForm2;
        
    }
}