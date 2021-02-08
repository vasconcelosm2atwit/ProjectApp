
namespace WindowsFormsApp1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowAll = new FontAwesome.Sharp.IconButton();
            this.btnNewConference = new FontAwesome.Sharp.IconButton();
            this.btnIconHome = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.lblCurrentAndUp = new System.Windows.Forms.Label();
            this.allDataGrid = new System.Windows.Forms.DataGridView();
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 561);
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
            this.btnShowAll.Location = new System.Drawing.Point(2, 158);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(173, 54);
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
            this.btnNewConference.Location = new System.Drawing.Point(1, 98);
            this.btnNewConference.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewConference.Name = "btnNewConference";
            this.btnNewConference.Size = new System.Drawing.Size(172, 54);
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
            this.btnIconHome.Location = new System.Drawing.Point(-2, 39);
            this.btnIconHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnIconHome.Name = "btnIconHome";
            this.btnIconHome.Size = new System.Drawing.Size(177, 54);
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
            this.panelChildForm.Controls.Add(this.lblCurrentAndUp);
            this.panelChildForm.Controls.Add(this.allDataGrid);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(175, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(609, 561);
            this.panelChildForm.TabIndex = 2;
            // 
            // lblCurrentAndUp
            // 
            this.lblCurrentAndUp.AutoSize = true;
            this.lblCurrentAndUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentAndUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAndUp.ForeColor = System.Drawing.Color.White;
            this.lblCurrentAndUp.Location = new System.Drawing.Point(149, 46);
            this.lblCurrentAndUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentAndUp.Name = "lblCurrentAndUp";
            this.lblCurrentAndUp.Size = new System.Drawing.Size(292, 32);
            this.lblCurrentAndUp.TabIndex = 1;
            this.lblCurrentAndUp.Text = "Current Conferences";
            // 
            // allDataGrid
            // 
            this.allDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDataGrid.Location = new System.Drawing.Point(20, 107);
            this.allDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.allDataGrid.Name = "allDataGrid";
            this.allDataGrid.RowHeadersWidth = 51;
            this.allDataGrid.RowTemplate.Height = 24;
            this.allDataGrid.Size = new System.Drawing.Size(578, 340);
            this.allDataGrid.TabIndex = 0;
            this.allDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
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
    }
}

