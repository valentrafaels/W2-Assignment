namespace W2_Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forName = new System.Windows.Forms.Label();
            this.forAge = new System.Windows.Forms.Label();
            this.forEmail = new System.Windows.Forms.Label();
            this.forPH = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxAge = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxPH = new System.Windows.Forms.TextBox();
            this.buttSubmit = new System.Windows.Forms.Button();
            this.buttClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forName
            // 
            this.forName.AutoSize = true;
            this.forName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.forName.Location = new System.Drawing.Point(27, 29);
            this.forName.Name = "forName";
            this.forName.Size = new System.Drawing.Size(75, 25);
            this.forName.TabIndex = 0;
            this.forName.Text = "Name :";
            // 
            // forAge
            // 
            this.forAge.AutoSize = true;
            this.forAge.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.forAge.Location = new System.Drawing.Point(27, 112);
            this.forAge.Name = "forAge";
            this.forAge.Size = new System.Drawing.Size(56, 25);
            this.forAge.TabIndex = 1;
            this.forAge.Text = "Age :";
            this.forAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // forEmail
            // 
            this.forEmail.AutoSize = true;
            this.forEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.forEmail.Location = new System.Drawing.Point(27, 193);
            this.forEmail.Name = "forEmail";
            this.forEmail.Size = new System.Drawing.Size(70, 25);
            this.forEmail.TabIndex = 2;
            this.forEmail.Text = "Email :";
            // 
            // forPH
            // 
            this.forPH.AutoSize = true;
            this.forPH.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.forPH.Location = new System.Drawing.Point(27, 275);
            this.forPH.Name = "forPH";
            this.forPH.Size = new System.Drawing.Size(152, 25);
            this.forPH.TabIndex = 3;
            this.forPH.Text = "Phone Number :";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(27, 67);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(100, 23);
            this.boxName.TabIndex = 4;
            // 
            // boxAge
            // 
            this.boxAge.Location = new System.Drawing.Point(27, 155);
            this.boxAge.Name = "boxAge";
            this.boxAge.Size = new System.Drawing.Size(100, 23);
            this.boxAge.TabIndex = 5;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(27, 238);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(100, 23);
            this.boxEmail.TabIndex = 6;
            // 
            // boxPH
            // 
            this.boxPH.Location = new System.Drawing.Point(27, 318);
            this.boxPH.Name = "boxPH";
            this.boxPH.Size = new System.Drawing.Size(100, 23);
            this.boxPH.TabIndex = 7;
            // 
            // buttSubmit
            // 
            this.buttSubmit.Location = new System.Drawing.Point(27, 365);
            this.buttSubmit.Name = "buttSubmit";
            this.buttSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttSubmit.TabIndex = 8;
            this.buttSubmit.Text = "Submit";
            this.buttSubmit.UseVisualStyleBackColor = true;
            this.buttSubmit.Click += new System.EventHandler(this.buttSubmit_Click);
            // 
            // buttClear
            // 
            this.buttClear.Location = new System.Drawing.Point(136, 365);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(75, 23);
            this.buttClear.TabIndex = 9;
            this.buttClear.Text = "Clear";
            this.buttClear.UseMnemonic = false;
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.buttSubmit);
            this.Controls.Add(this.boxPH);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxAge);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.forPH);
            this.Controls.Add(this.forEmail);
            this.Controls.Add(this.forAge);
            this.Controls.Add(this.forName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label forName;
        private Label forAge;
        private Label forEmail;
        private Label forPH;
        private TextBox boxName;
        private TextBox boxAge;
        private TextBox boxEmail;
        private TextBox boxPH;
        private Button buttSubmit;
        private Button buttClear;
    }
}