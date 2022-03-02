namespace SchoolTime
{
    partial class mainWindow
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
            this.closeApp = new System.Windows.Forms.Button();
            this.dayofweek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Orar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sesiuneprogress = new System.Windows.Forms.ProgressBar();
            this.SesiuneCounter = new System.Windows.Forms.Label();
            this.ora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.browser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeApp
            // 
            this.closeApp.BackColor = System.Drawing.Color.Crimson;
            this.closeApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeApp.Location = new System.Drawing.Point(418, 12);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(20, 20);
            this.closeApp.TabIndex = 0;
            this.closeApp.UseVisualStyleBackColor = false;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // dayofweek
            // 
            this.dayofweek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayofweek.AutoSize = true;
            this.dayofweek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayofweek.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofweek.ForeColor = System.Drawing.Color.Gold;
            this.dayofweek.Location = new System.Drawing.Point(125, 12);
            this.dayofweek.Name = "dayofweek";
            this.dayofweek.Size = new System.Drawing.Size(48, 27);
            this.dayofweek.TabIndex = 2;
            this.dayofweek.Text = "luni";
            this.dayofweek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dayofweek.Click += new System.EventHandler(this.dayofweek_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Astazi este";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Orar
            // 
            this.Orar.AutoSize = true;
            this.Orar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Orar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orar.ForeColor = System.Drawing.Color.White;
            this.Orar.Location = new System.Drawing.Point(3, 9);
            this.Orar.Name = "Orar";
            this.Orar.Size = new System.Drawing.Size(259, 20);
            this.Orar.TabIndex = 4;
            this.Orar.Text = "12-14    Geometrie Computationala";
            this.Orar.Click += new System.EventHandler(this.Orar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Orar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(17, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 272);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sesiuneprogress
            // 
            this.sesiuneprogress.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sesiuneprogress.ForeColor = System.Drawing.Color.Crimson;
            this.sesiuneprogress.Location = new System.Drawing.Point(17, 375);
            this.sesiuneprogress.Name = "sesiuneprogress";
            this.sesiuneprogress.Size = new System.Drawing.Size(100, 13);
            this.sesiuneprogress.TabIndex = 6;
            this.sesiuneprogress.Click += new System.EventHandler(this.sesiuneprogress_Click);
            // 
            // SesiuneCounter
            // 
            this.SesiuneCounter.AutoSize = true;
            this.SesiuneCounter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SesiuneCounter.ForeColor = System.Drawing.SystemColors.Control;
            this.SesiuneCounter.Location = new System.Drawing.Point(14, 355);
            this.SesiuneCounter.Name = "SesiuneCounter";
            this.SesiuneCounter.Size = new System.Drawing.Size(114, 17);
            this.SesiuneCounter.TabIndex = 8;
            this.SesiuneCounter.Text = "Sesiune in 14 zile";
            this.SesiuneCounter.Click += new System.EventHandler(this.SesiuneCounter_Click);
            // 
            // ora
            // 
            this.ora.AutoSize = true;
            this.ora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ora.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ora.ForeColor = System.Drawing.Color.Gold;
            this.ora.Location = new System.Drawing.Point(32, 54);
            this.ora.Name = "ora";
            this.ora.Size = new System.Drawing.Size(39, 23);
            this.ora.TabIndex = 5;
            this.ora.Text = "Ora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(189, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Materie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(366, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prof";
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(386, 365);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(52, 23);
            this.browser.TabIndex = 11;
            this.browser.Text = "News";
            this.browser.UseVisualStyleBackColor = true;
            this.browser.Click += new System.EventHandler(this.browser_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ora);
            this.Controls.Add(this.SesiuneCounter);
            this.Controls.Add(this.sesiuneprogress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayofweek);
            this.Controls.Add(this.closeApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeApp;
        private System.Windows.Forms.Label dayofweek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Orar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar sesiuneprogress;
        private System.Windows.Forms.Label SesiuneCounter;
        private System.Windows.Forms.Label ora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browser;
    }
}

