namespace Project_2_1
{
    partial class Form1
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
            this.addbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.dltbtnbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(12, 30);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(314, 52);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add Data";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.viewbtn.Location = new System.Drawing.Point(12, 88);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(314, 57);
            this.viewbtn.TabIndex = 0;
            this.viewbtn.Text = "View Data";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // dltbtnbtn
            // 
            this.dltbtnbtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.dltbtnbtn.Location = new System.Drawing.Point(12, 151);
            this.dltbtnbtn.Name = "dltbtnbtn";
            this.dltbtnbtn.Size = new System.Drawing.Size(314, 58);
            this.dltbtnbtn.TabIndex = 0;
            this.dltbtnbtn.Text = "Delete or Modify Data";
            this.dltbtnbtn.UseVisualStyleBackColor = true;
            this.dltbtnbtn.Click += new System.EventHandler(this.dltbtnbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.button1.Location = new System.Drawing.Point(12, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dltbtnbtn);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.addbtn);
            this.Name = "Form1";
            this.Text = "COST COUNTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button dltbtnbtn;
        private System.Windows.Forms.Button button1;
    }
}

