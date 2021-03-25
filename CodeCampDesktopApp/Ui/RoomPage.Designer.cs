
namespace CodeCampApp
{
    partial class RoomPage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.sectionText = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.roomNumberTxt = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 102);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubmitBtn);
            this.panel1.Controls.Add(this.sectionText);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.roomNumberTxt);
            this.panel1.Controls.Add(this.lblRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 540);
            this.panel1.TabIndex = 1;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(376, 149);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 11;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // sectionText
            // 
            this.sectionText.Location = new System.Drawing.Point(314, 100);
            this.sectionText.Name = "sectionText";
            this.sectionText.Size = new System.Drawing.Size(200, 22);
            this.sectionText.TabIndex = 3;
            this.sectionText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.sectionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sectionText_KeyPress);
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSection.Location = new System.Drawing.Point(210, 98);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(98, 23);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Capacity";
            this.lblSection.Click += new System.EventHandler(this.label1_Click);
            // 
            // roomNumberTxt
            // 
            this.roomNumberTxt.Location = new System.Drawing.Point(314, 47);
            this.roomNumberTxt.Name = "roomNumberTxt";
            this.roomNumberTxt.Size = new System.Drawing.Size(200, 22);
            this.roomNumberTxt.TabIndex = 1;
            this.roomNumberTxt.TextChanged += new System.EventHandler(this.roomNumberTxt_TextChanged);
            this.roomNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomNumberTxt_KeyPress);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRoom.Location = new System.Drawing.Point(199, 45);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(109, 23);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Room Name";
            // 
            // RoomPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(776, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomPage";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sectionText;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox roomNumberTxt;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button SubmitBtn;
    }
}