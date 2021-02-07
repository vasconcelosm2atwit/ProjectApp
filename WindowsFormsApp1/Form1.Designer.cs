
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnIconHome = new FontAwesome.Sharp.IconButton();
            this.btnIconAdd = new FontAwesome.Sharp.IconButton();
            this.btnIconShow = new FontAwesome.Sharp.IconButton();
            this.allDataGrid = new System.Windows.Forms.DataGridView();
            this.lblCurrentAndUp = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnIconShow);
            this.panel2.Controls.Add(this.btnIconAdd);
            this.panel2.Controls.Add(this.btnIconHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 690);
            this.panel2.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.lblCurrentAndUp);
            this.panelChildForm.Controls.Add(this.allDataGrid);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(233, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(812, 690);
            this.panelChildForm.TabIndex = 2;
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
            this.btnIconHome.Name = "btnIconHome";
            this.btnIconHome.Size = new System.Drawing.Size(236, 67);
            this.btnIconHome.TabIndex = 4;
            this.btnIconHome.Text = "Home";
            this.btnIconHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconHome.UseVisualStyleBackColor = true;
            this.btnIconHome.Click += new System.EventHandler(this.btnIconHome_Click);
            // 
            // btnIconAdd
            // 
            this.btnIconAdd.FlatAppearance.BorderSize = 0;
            this.btnIconAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnIconAdd.IconColor = System.Drawing.Color.Black;
            this.btnIconAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconAdd.Location = new System.Drawing.Point(1, 121);
            this.btnIconAdd.Name = "btnIconAdd";
            this.btnIconAdd.Size = new System.Drawing.Size(229, 67);
            this.btnIconAdd.TabIndex = 5;
            this.btnIconAdd.Text = " New Conference";
            this.btnIconAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconAdd.UseVisualStyleBackColor = true;
            this.btnIconAdd.Click += new System.EventHandler(this.btnIconAdd_Click);
            // 
            // btnIconShow
            // 
            this.btnIconShow.FlatAppearance.BorderSize = 0;
            this.btnIconShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconShow.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnIconShow.IconColor = System.Drawing.Color.Black;
            this.btnIconShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconShow.Location = new System.Drawing.Point(2, 194);
            this.btnIconShow.Name = "btnIconShow";
            this.btnIconShow.Size = new System.Drawing.Size(231, 67);
            this.btnIconShow.TabIndex = 6;
            this.btnIconShow.Text = "Show All";
            this.btnIconShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIconShow.UseVisualStyleBackColor = true;
            // 
            // allDataGrid
            // 
            this.allDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDataGrid.Location = new System.Drawing.Point(106, 132);
            this.allDataGrid.Name = "allDataGrid";
            this.allDataGrid.RowHeadersWidth = 51;
            this.allDataGrid.RowTemplate.Height = 24;
            this.allDataGrid.Size = new System.Drawing.Size(576, 419);
            this.allDataGrid.TabIndex = 0;
            this.allDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblCurrentAndUp
            // 
            this.lblCurrentAndUp.AutoSize = true;
            this.lblCurrentAndUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentAndUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAndUp.ForeColor = System.Drawing.Color.White;
            this.lblCurrentAndUp.Location = new System.Drawing.Point(90, 55);
            this.lblCurrentAndUp.Name = "lblCurrentAndUp";
            this.lblCurrentAndUp.Size = new System.Drawing.Size(616, 39);
            this.lblCurrentAndUp.TabIndex = 1;
            this.lblCurrentAndUp.Text = "Current and Upcoming Conferences";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private FontAwesome.Sharp.IconButton btnIconAdd;
        private FontAwesome.Sharp.IconButton btnIconShow;
        private System.Windows.Forms.Label lblCurrentAndUp;
        private System.Windows.Forms.DataGridView allDataGrid;
    }
}

