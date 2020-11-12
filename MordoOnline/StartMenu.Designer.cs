namespace MordoOnline
{
    partial class StartMenu
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
            this.buttonDataBaseLeft = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonDataBaseRight = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDataBaseLeft
            // 
            this.buttonDataBaseLeft.AutoSize = true;
            this.buttonDataBaseLeft.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDataBaseLeft.FlatAppearance.BorderSize = 0;
            this.buttonDataBaseLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataBaseLeft.Location = new System.Drawing.Point(85, 84);
            this.buttonDataBaseLeft.Name = "buttonDataBaseLeft";
            this.buttonDataBaseLeft.Size = new System.Drawing.Size(103, 30);
            this.buttonDataBaseLeft.TabIndex = 0;
            this.buttonDataBaseLeft.Text = "База данных";
            this.buttonDataBaseLeft.UseVisualStyleBackColor = false;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Location = new System.Drawing.Point(85, 120);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(515, 324);
            this.panelInfo.TabIndex = 1;
            // 
            // buttonDataBaseRight
            // 
            this.buttonDataBaseRight.AutoSize = true;
            this.buttonDataBaseRight.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDataBaseRight.FlatAppearance.BorderSize = 0;
            this.buttonDataBaseRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataBaseRight.Location = new System.Drawing.Point(497, 84);
            this.buttonDataBaseRight.Name = "buttonDataBaseRight";
            this.buttonDataBaseRight.Size = new System.Drawing.Size(103, 30);
            this.buttonDataBaseRight.TabIndex = 0;
            this.buttonDataBaseRight.Text = "База данных";
            this.buttonDataBaseRight.UseVisualStyleBackColor = false;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.AutoSize = true;
            this.buttonRegistration.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRegistration.FlatAppearance.BorderSize = 0;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Location = new System.Drawing.Point(269, 84);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(146, 30);
            this.buttonRegistration.TabIndex = 0;
            this.buttonRegistration.Text = "Регистрация в игре";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(569, 523);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(103, 30);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Запуск";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel.Location = new System.Drawing.Point(12, 9);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(252, 16);
            this.linkLabel.TabIndex = 0;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Ссылка на сайт(пока на www.google.com)";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(166, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 565);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonDataBaseRight);
            this.Controls.Add(this.buttonDataBaseLeft);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mordo Online";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.Shown += new System.EventHandler(this.StartMenu_Shown);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDataBaseLeft;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button buttonDataBaseRight;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label label1;
    }
}

