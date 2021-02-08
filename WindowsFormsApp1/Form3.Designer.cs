
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.allDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // allDataGrid
            // 
            this.allDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allDataGrid.Location = new System.Drawing.Point(0, 0);
            this.allDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allDataGrid.Name = "allDataGrid";
            this.allDataGrid.RowHeadersWidth = 51;
            this.allDataGrid.Size = new System.Drawing.Size(771, 642);
            this.allDataGrid.TabIndex = 0;
            this.allDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allDataGrid_CellContentClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 642);
            this.Controls.Add(this.allDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allDataGrid;
    }
}