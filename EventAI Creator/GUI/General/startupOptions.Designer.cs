namespace EventAI_Creator.GUI.General
{
    partial class eAICreator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eAICreator));
            this.noDBconnection = new System.Windows.Forms.Button();
            this.connectbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mysqlgroupbox = new System.Windows.Forms.GroupBox();
            this.tboxmysqlpw = new System.Windows.Forms.TextBox();
            this.tboxmysqlsd2db = new System.Windows.Forms.TextBox();
            this.tboxmysqlwordldb = new System.Windows.Forms.TextBox();
            this.tboxmysqlname = new System.Windows.Forms.TextBox();
            this.tboxmysqlport = new System.Windows.Forms.TextBox();
            this.tboxmysqlhost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mysqlgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // noDBconnection
            // 
            this.noDBconnection.Location = new System.Drawing.Point(92, 227);
            this.noDBconnection.Name = "noDBconnection";
            this.noDBconnection.Size = new System.Drawing.Size(75, 22);
            this.noDBconnection.TabIndex = 0;
            this.noDBconnection.Text = "Work offline";
            this.noDBconnection.UseVisualStyleBackColor = true;
            this.noDBconnection.Click += new System.EventHandler(this.noDBconnection_Click);
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(11, 227);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(75, 22);
            this.connectbutton.TabIndex = 1;
            this.connectbutton.Text = "Connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to MangosR2 DB scripting tool. Please set your Database Settings";
            // 
            // mysqlgroupbox
            // 
            this.mysqlgroupbox.Controls.Add(this.tboxmysqlpw);
            this.mysqlgroupbox.Controls.Add(this.tboxmysqlsd2db);
            this.mysqlgroupbox.Controls.Add(this.tboxmysqlwordldb);
            this.mysqlgroupbox.Controls.Add(this.tboxmysqlname);
            this.mysqlgroupbox.Controls.Add(this.tboxmysqlport);
            this.mysqlgroupbox.Controls.Add(this.tboxmysqlhost);
            this.mysqlgroupbox.Controls.Add(this.label7);
            this.mysqlgroupbox.Controls.Add(this.label6);
            this.mysqlgroupbox.Controls.Add(this.label5);
            this.mysqlgroupbox.Controls.Add(this.label4);
            this.mysqlgroupbox.Controls.Add(this.label3);
            this.mysqlgroupbox.Controls.Add(this.label2);
            this.mysqlgroupbox.Location = new System.Drawing.Point(13, 30);
            this.mysqlgroupbox.Name = "mysqlgroupbox";
            this.mysqlgroupbox.Size = new System.Drawing.Size(360, 191);
            this.mysqlgroupbox.TabIndex = 3;
            this.mysqlgroupbox.TabStop = false;
            this.mysqlgroupbox.Text = "MySQL Connection Settings";
            // 
            // tboxmysqlpw
            // 
            this.tboxmysqlpw.Location = new System.Drawing.Point(154, 111);
            this.tboxmysqlpw.MaxLength = 255;
            this.tboxmysqlpw.Name = "tboxmysqlpw";
            this.tboxmysqlpw.PasswordChar = '*';
            this.tboxmysqlpw.Size = new System.Drawing.Size(200, 20);
            this.tboxmysqlpw.TabIndex = 4;
            // 
            // tboxmysqlsd2db
            // 
            this.tboxmysqlsd2db.Location = new System.Drawing.Point(154, 160);
            this.tboxmysqlsd2db.MaxLength = 255;
            this.tboxmysqlsd2db.Name = "tboxmysqlsd2db";
            this.tboxmysqlsd2db.Size = new System.Drawing.Size(200, 20);
            this.tboxmysqlsd2db.TabIndex = 5;
            // 
            // tboxmysqlwordldb
            // 
            this.tboxmysqlwordldb.Location = new System.Drawing.Point(154, 134);
            this.tboxmysqlwordldb.MaxLength = 255;
            this.tboxmysqlwordldb.Name = "tboxmysqlwordldb";
            this.tboxmysqlwordldb.Size = new System.Drawing.Size(200, 20);
            this.tboxmysqlwordldb.TabIndex = 5;
            // 
            // tboxmysqlname
            // 
            this.tboxmysqlname.Location = new System.Drawing.Point(154, 85);
            this.tboxmysqlname.MaxLength = 255;
            this.tboxmysqlname.Name = "tboxmysqlname";
            this.tboxmysqlname.Size = new System.Drawing.Size(200, 20);
            this.tboxmysqlname.TabIndex = 3;
            // 
            // tboxmysqlport
            // 
            this.tboxmysqlport.Location = new System.Drawing.Point(154, 59);
            this.tboxmysqlport.MaxLength = 255;
            this.tboxmysqlport.Name = "tboxmysqlport";
            this.tboxmysqlport.Size = new System.Drawing.Size(200, 20);
            this.tboxmysqlport.TabIndex = 2;
            // 
            // tboxmysqlhost
            // 
            this.tboxmysqlhost.Location = new System.Drawing.Point(154, 33);
            this.tboxmysqlhost.MaxLength = 255;
            this.tboxmysqlhost.Name = "tboxmysqlhost";
            this.tboxmysqlhost.Size = new System.Drawing.Size(200, 20);
            this.tboxmysqlhost.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ScriptDev2 DB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mangos World DB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hostname/IP-Address:";
            // 
            // eAICreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 260);
            this.Controls.Add(this.mysqlgroupbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.noDBconnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eAICreator";
            this.Text = "MangosR2 DB script development tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eAICreator_FormClosing);
            this.Load += new System.EventHandler(this.eAICreator_Load);
            this.mysqlgroupbox.ResumeLayout(false);
            this.mysqlgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noDBconnection;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox mysqlgroupbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxmysqlwordldb;
        private System.Windows.Forms.TextBox tboxmysqlname;
        private System.Windows.Forms.TextBox tboxmysqlport;
        private System.Windows.Forms.TextBox tboxmysqlhost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxmysqlpw;
        private System.Windows.Forms.TextBox tboxmysqlsd2db;
        private System.Windows.Forms.Label label7;
    }
}