namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new WindowsFormsApplication2.MainContent();
            this.userControl14 = new WindowsFormsApplication2.UserControl1();
            this.userControl15 = new WindowsFormsApplication2.UserControl1();
            this.userControl12 = new WindowsFormsApplication2.UserControl1();
            this.userControl13 = new WindowsFormsApplication2.UserControl1();
            this.userControl11 = new WindowsFormsApplication2.UserControl1();
            this.button1 = new WindowsFormsApplication2.UserControl1();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(151, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(821, 513);
            this.button2.TabIndex = 6;
            this.button2.Load += new System.EventHandler(this.button2_Load);
            // 
            // userControl14
            // 
            this.userControl14.AccessibleDescription = "asd";
            this.userControl14.AccessibleName = "ASD";
            this.userControl14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl14.BackgroundImage")));
            this.userControl14.Location = new System.Drawing.Point(2, 289);
            this.userControl14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.userControl14.Name = "userControl14";
            this.userControl14.Size = new System.Drawing.Size(143, 37);
            this.userControl14.TabIndex = 5;
            // 
            // userControl15
            // 
            this.userControl15.AccessibleDescription = "asd";
            this.userControl15.AccessibleName = "ASD";
            this.userControl15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl15.BackgroundImage")));
            this.userControl15.Location = new System.Drawing.Point(2, 251);
            this.userControl15.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.userControl15.Name = "userControl15";
            this.userControl15.Size = new System.Drawing.Size(143, 37);
            this.userControl15.TabIndex = 4;
            // 
            // userControl12
            // 
            this.userControl12.AccessibleDescription = "asd";
            this.userControl12.AccessibleName = "ASD";
            this.userControl12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl12.BackgroundImage")));
            this.userControl12.Location = new System.Drawing.Point(2, 213);
            this.userControl12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(143, 37);
            this.userControl12.TabIndex = 3;
            // 
            // userControl13
            // 
            this.userControl13.AccessibleDescription = "asd";
            this.userControl13.AccessibleName = "ASD";
            this.userControl13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl13.BackgroundImage")));
            this.userControl13.Location = new System.Drawing.Point(2, 175);
            this.userControl13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(143, 37);
            this.userControl13.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.AccessibleDescription = "asd";
            this.userControl11.AccessibleName = "ASD";
            this.userControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl11.BackgroundImage")));
            this.userControl11.Location = new System.Drawing.Point(2, 137);
            this.userControl11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(143, 37);
            this.userControl11.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "asd";
            this.button1.AccessibleName = "ASD";
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(2, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 37);
            this.button1.TabIndex = 0;
            this.button1.Load += new System.EventHandler(this.button1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userControl14);
            this.Controls.Add(this.userControl15);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 button1;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
        private UserControl1 userControl14;
        private UserControl1 userControl15;
        private MainContent button2;
    }
}

