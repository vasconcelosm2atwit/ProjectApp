
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowAll = new FontAwesome.Sharp.IconButton();
            this.btnNewConference = new FontAwesome.Sharp.IconButton();
            this.btnIconHome = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.lblBottomId = new System.Windows.Forms.Label();
            this.lblBottomSpeaker = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBottomRoom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_end = new System.Windows.Forms.RadioButton();
            this.radioButton_med = new System.Windows.Forms.RadioButton();
            this.radioButton_beg = new System.Windows.Forms.RadioButton();
            this.count_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BottonSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentAndUp = new System.Windows.Forms.Label();
            this.allDataGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnShowAll);
            this.panel2.Controls.Add(this.btnNewConference);
            this.panel2.Controls.Add(this.btnIconHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 708);
            this.panel2.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnShowAll.IconColor = System.Drawing.Color.Black;
            this.btnShowAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(3, 194);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(231, 66);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnNewConference
            // 
            this.btnNewConference.FlatAppearance.BorderSize = 0;
            this.btnNewConference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewConference.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNewConference.IconColor = System.Drawing.Color.Black;
            this.btnNewConference.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewConference.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewConference.Location = new System.Drawing.Point(1, 121);
            this.btnNewConference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewConference.Name = "btnNewConference";
            this.btnNewConference.Size = new System.Drawing.Size(229, 66);
            this.btnNewConference.TabIndex = 5;
            this.btnNewConference.Text = " New Conference";
            this.btnNewConference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewConference.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewConference.UseVisualStyleBackColor = true;
            this.btnNewConference.Click += new System.EventHandler(this.btnNewConference_Click);
            // 
            // btnIconHome
            // 
            this.btnIconHome.FlatAppearance.BorderSize = 0;
            this.btnIconHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnIconHome.IconColor = System.Drawing.Color.Black;
            this.btnIconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconHome.Location = new System.Drawing.Point(-3, 48);
            this.btnIconHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIconHome.Name = "btnIconHome";
            this.btnIconHome.Size = new System.Drawing.Size(236, 66);
            this.btnIconHome.TabIndex = 4;
            this.btnIconHome.Text = "Home";
            this.btnIconHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconHome.UseVisualStyleBackColor = true;
            this.btnIconHome.Click += new System.EventHandler(this.btnIconHome_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.BottomPanel);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.comboBox);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.lblCurrentAndUp);
            this.panelChildForm.Controls.Add(this.allDataGrid);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(233, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(845, 708);
            this.panelChildForm.TabIndex = 2;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.lblBottomId);
            this.BottomPanel.Controls.Add(this.lblBottomSpeaker);
            this.BottomPanel.Controls.Add(this.label7);
            this.BottomPanel.Controls.Add(this.label6);
            this.BottomPanel.Controls.Add(this.lblBottomRoom);
            this.BottomPanel.Controls.Add(this.label5);
            this.BottomPanel.Controls.Add(this.radioButton_end);
            this.BottomPanel.Controls.Add(this.radioButton_med);
            this.BottomPanel.Controls.Add(this.radioButton_beg);
            this.BottomPanel.Controls.Add(this.count_box);
            this.BottomPanel.Controls.Add(this.label4);
            this.BottomPanel.Controls.Add(this.BottonSubmit);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 456);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(845, 252);
            this.BottomPanel.TabIndex = 7;
            this.BottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BottomPanel_Paint);
            // 
            // lblBottomId
            // 
            this.lblBottomId.AutoSize = true;
            this.lblBottomId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBottomId.Location = new System.Drawing.Point(690, 92);
            this.lblBottomId.Name = "lblBottomId";
            this.lblBottomId.Size = new System.Drawing.Size(46, 17);
            this.lblBottomId.TabIndex = 12;
            this.lblBottomId.Text = "label8";
            // 
            // lblBottomSpeaker
            // 
            this.lblBottomSpeaker.AutoSize = true;
            this.lblBottomSpeaker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBottomSpeaker.Location = new System.Drawing.Point(522, 31);
            this.lblBottomSpeaker.Name = "lblBottomSpeaker";
            this.lblBottomSpeaker.Size = new System.Drawing.Size(61, 17);
            this.lblBottomSpeaker.TabIndex = 11;
            this.lblBottomSpeaker.Text = "Speaker";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(451, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Speaker:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(655, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Conference ID:";
            // 
            // lblBottomRoom
            // 
            this.lblBottomRoom.AutoSize = true;
            this.lblBottomRoom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBottomRoom.Location = new System.Drawing.Point(318, 31);
            this.lblBottomRoom.Name = "lblBottomRoom";
            this.lblBottomRoom.Size = new System.Drawing.Size(40, 17);
            this.lblBottomRoom.TabIndex = 8;
            this.lblBottomRoom.Text = "room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(263, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // radioButton_end
            // 
            this.radioButton_end.AutoSize = true;
            this.radioButton_end.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_end.Location = new System.Drawing.Point(461, 126);
            this.radioButton_end.Name = "radioButton_end";
            this.radioButton_end.Size = new System.Drawing.Size(54, 21);
            this.radioButton_end.TabIndex = 6;
            this.radioButton_end.TabStop = true;
            this.radioButton_end.Text = "End";
            this.radioButton_end.UseVisualStyleBackColor = true;
            // 
            // radioButton_med
            // 
            this.radioButton_med.AutoSize = true;
            this.radioButton_med.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_med.Location = new System.Drawing.Point(364, 126);
            this.radioButton_med.Name = "radioButton_med";
            this.radioButton_med.Size = new System.Drawing.Size(78, 21);
            this.radioButton_med.TabIndex = 5;
            this.radioButton_med.TabStop = true;
            this.radioButton_med.Text = "Medium";
            this.radioButton_med.UseVisualStyleBackColor = true;
            // 
            // radioButton_beg
            // 
            this.radioButton_beg.AutoSize = true;
            this.radioButton_beg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_beg.Location = new System.Drawing.Point(266, 126);
            this.radioButton_beg.Name = "radioButton_beg";
            this.radioButton_beg.Size = new System.Drawing.Size(92, 21);
            this.radioButton_beg.TabIndex = 4;
            this.radioButton_beg.TabStop = true;
            this.radioButton_beg.Text = "Beginning";
            this.radioButton_beg.UseVisualStyleBackColor = true;
            this.radioButton_beg.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // count_box
            // 
            this.count_box.Location = new System.Drawing.Point(355, 87);
            this.count_box.Name = "count_box";
            this.count_box.Size = new System.Drawing.Size(100, 22);
            this.count_box.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(292, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Count";
            // 
            // BottonSubmit
            // 
            this.BottonSubmit.Location = new System.Drawing.Point(367, 165);
            this.BottonSubmit.Name = "BottonSubmit";
            this.BottonSubmit.Size = new System.Drawing.Size(88, 41);
            this.BottonSubmit.TabIndex = 0;
            this.BottonSubmit.Text = "Submit";
            this.BottonSubmit.UseVisualStyleBackColor = true;
            this.BottonSubmit.Click += new System.EventHandler(this.BottonSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(349, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sessions";
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(278, 79);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(253, 35);
            this.comboBox.TabIndex = 4;
            this.comboBox.Text = "              SESSIONS";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
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
            // allDataGrid
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.allDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDataGrid.Location = new System.Drawing.Point(85, 203);
            this.allDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allDataGrid.Name = "allDataGrid";
            this.allDataGrid.RowHeadersWidth = 51;
            this.allDataGrid.RowTemplate.Height = 24;
            this.allDataGrid.Size = new System.Drawing.Size(672, 234);
            this.allDataGrid.TabIndex = 0;
            this.allDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1078, 708);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnIconHome;
        private FontAwesome.Sharp.IconButton btnNewConference;
        private FontAwesome.Sharp.IconButton btnShowAll;
        private System.Windows.Forms.Label lblCurrentAndUp;
        private System.Windows.Forms.DataGridView allDataGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button BottonSubmit;
        private System.Windows.Forms.RadioButton radioButton_beg;
        private System.Windows.Forms.TextBox count_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_end;
        private System.Windows.Forms.RadioButton radioButton_med;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBottomRoom;
        private System.Windows.Forms.Label lblBottomSpeaker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBottomId;
    }
}

