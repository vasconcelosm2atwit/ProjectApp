
namespace CodeCampApp
{
    partial class SideMenu
    {
        //
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.timeSlotBtn = new System.Windows.Forms.Button();
            this.speakerBtn = new System.Windows.Forms.Button();
            this.sessionBtn = new System.Windows.Forms.Button();
            this.roomBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentAndUp = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.MenuPanel.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MenuPanel.Controls.Add(this.timeSlotBtn);
            this.MenuPanel.Controls.Add(this.speakerBtn);
            this.MenuPanel.Controls.Add(this.sessionBtn);
            this.MenuPanel.Controls.Add(this.roomBtn);
            this.MenuPanel.Controls.Add(this.homeBtn);
            this.MenuPanel.Controls.Add(this.panelLogo);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(250, 721);
            this.MenuPanel.TabIndex = 1;
            // 
            // timeSlotBtn
            // 
            this.timeSlotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeSlotBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeSlotBtn.FlatAppearance.BorderSize = 0;
            this.timeSlotBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.timeSlotBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.timeSlotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeSlotBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSlotBtn.Location = new System.Drawing.Point(0, 366);
            this.timeSlotBtn.Name = "timeSlotBtn";
            this.timeSlotBtn.Size = new System.Drawing.Size(250, 70);
            this.timeSlotBtn.TabIndex = 6;
            this.timeSlotBtn.Text = "Time Slots";
            this.timeSlotBtn.UseVisualStyleBackColor = true;
            this.timeSlotBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // speakerBtn
            // 
            this.speakerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speakerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.speakerBtn.FlatAppearance.BorderSize = 0;
            this.speakerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.speakerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.speakerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speakerBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speakerBtn.Location = new System.Drawing.Point(0, 296);
            this.speakerBtn.Name = "speakerBtn";
            this.speakerBtn.Size = new System.Drawing.Size(250, 70);
            this.speakerBtn.TabIndex = 5;
            this.speakerBtn.Text = "Speakers";
            this.speakerBtn.UseVisualStyleBackColor = true;
            this.speakerBtn.Click += new System.EventHandler(this.SpeakerBtn_Click);
            // 
            // sessionBtn
            // 
            this.sessionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sessionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sessionBtn.FlatAppearance.BorderSize = 0;
            this.sessionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.sessionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.sessionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sessionBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionBtn.Location = new System.Drawing.Point(0, 226);
            this.sessionBtn.Name = "sessionBtn";
            this.sessionBtn.Size = new System.Drawing.Size(250, 70);
            this.sessionBtn.TabIndex = 4;
            this.sessionBtn.Text = "Sessions";
            this.sessionBtn.UseVisualStyleBackColor = true;
            this.sessionBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // roomBtn
            // 
            this.roomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomBtn.FlatAppearance.BorderSize = 0;
            this.roomBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.roomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.roomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBtn.Location = new System.Drawing.Point(0, 156);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Size = new System.Drawing.Size(250, 70);
            this.roomBtn.TabIndex = 3;
            this.roomBtn.Text = "Rooms";
            this.roomBtn.UseVisualStyleBackColor = true;
            this.roomBtn.Click += new System.EventHandler(this.RoomBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(0, 86);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(5);
            this.homeBtn.Size = new System.Drawing.Size(250, 70);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 86);
            this.panelLogo.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.lblCurrentAndUp);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(756, 721);
            this.panelChildForm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // lblCurrentAndUp
            // 
            this.lblCurrentAndUp.AutoSize = true;
            this.lblCurrentAndUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentAndUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAndUp.ForeColor = System.Drawing.Color.White;
            this.lblCurrentAndUp.Location = new System.Drawing.Point(290, 48);
            this.lblCurrentAndUp.Name = "lblCurrentAndUp";
            this.lblCurrentAndUp.Size = new System.Drawing.Size(0, 28);
            this.lblCurrentAndUp.TabIndex = 1;
            // 
            // SideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.MenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SideMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label lblCurrentAndUp;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button sessionBtn;
        private System.Windows.Forms.Button roomBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button timeSlotBtn;
        private System.Windows.Forms.Button speakerBtn;
    }
}

