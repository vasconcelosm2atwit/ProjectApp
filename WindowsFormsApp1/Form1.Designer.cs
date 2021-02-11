
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowAll = new FontAwesome.Sharp.IconButton();
            this.btnNewConference = new FontAwesome.Sharp.IconButton();
            this.btnIconHome = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentAndUp = new System.Windows.Forms.Label();
            this.allDataGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelChildForm.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(233, 602);
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
            this.panelChildForm.Controls.Add(this.label3);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.comboBox);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.lblCurrentAndUp);
            this.panelChildForm.Controls.Add(this.allDataGrid);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(233, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(857, 602);
            this.panelChildForm.TabIndex = 2;
            // 
            // comboBox
            // 
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
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDataGrid.Location = new System.Drawing.Point(181, 203);
            this.allDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allDataGrid.Name = "allDataGrid";
            this.allDataGrid.RowHeadersWidth = 51;
            this.allDataGrid.RowTemplate.Height = 24;
            this.allDataGrid.Size = new System.Drawing.Size(456, 163);
            this.allDataGrid.TabIndex = 0;
            this.allDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(132, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 602);
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
        private System.Windows.Forms.Label label3;
    }
}

