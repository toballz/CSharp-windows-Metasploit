namespace Windows_Metasploit
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
            this.listeningip = new System.Windows.Forms.TextBox();
            this.listeningport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartBuild = new System.Windows.Forms.Button();
            this.landingdir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.appname = new System.Windows.Forms.TextBox();
            this.movedfiledir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listeningip
            // 
            this.listeningip.Location = new System.Drawing.Point(126, 42);
            this.listeningip.Name = "listeningip";
            this.listeningip.Size = new System.Drawing.Size(260, 20);
            this.listeningip.TabIndex = 0;
            // 
            // listeningport
            // 
            this.listeningport.Location = new System.Drawing.Point(126, 68);
            this.listeningport.Name = "listeningport";
            this.listeningport.Size = new System.Drawing.Size(100, 20);
            this.listeningport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listening IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listening PORT";
            // 
            // StartBuild
            // 
            this.StartBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBuild.Location = new System.Drawing.Point(85, 131);
            this.StartBuild.Name = "StartBuild";
            this.StartBuild.Size = new System.Drawing.Size(224, 47);
            this.StartBuild.TabIndex = 4;
            this.StartBuild.Text = "Build";
            this.StartBuild.UseVisualStyleBackColor = true;
            this.StartBuild.Click += new System.EventHandler(this.StartBuild_Click);
            // 
            // landingdir
            // 
            this.landingdir.Location = new System.Drawing.Point(126, 94);
            this.landingdir.Name = "landingdir";
            this.landingdir.Size = new System.Drawing.Size(178, 20);
            this.landingdir.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose a Directory";
            // 
            // appname
            // 
            this.appname.Location = new System.Drawing.Point(126, 12);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(200, 20);
            this.appname.TabIndex = 7;
            // 
            // movedfiledir
            // 
            this.movedfiledir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movedfiledir.Location = new System.Drawing.Point(310, 90);
            this.movedfiledir.Name = "movedfiledir";
            this.movedfiledir.Size = new System.Drawing.Size(76, 26);
            this.movedfiledir.TabIndex = 8;
            this.movedfiledir.Text = "File";
            this.movedfiledir.UseVisualStyleBackColor = true;
            this.movedfiledir.Click += new System.EventHandler(this.movedfiledir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "App name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 190);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movedfiledir);
            this.Controls.Add(this.appname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.landingdir);
            this.Controls.Add(this.StartBuild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeningport);
            this.Controls.Add(this.listeningip);
            this.MaximumSize = new System.Drawing.Size(411, 229);
            this.MinimumSize = new System.Drawing.Size(411, 229);
            this.Name = "Form1";
            this.Text = "Windows Metasploit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listeningip;
        private System.Windows.Forms.TextBox listeningport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartBuild;
        private System.Windows.Forms.TextBox landingdir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox appname;
        private System.Windows.Forms.Button movedfiledir;
        private System.Windows.Forms.Label label4;
    }
}

