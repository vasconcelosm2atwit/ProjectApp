
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnSubmitForm = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.speakerText = new System.Windows.Forms.TextBox();
            this.lblSpeaker = new System.Windows.Forms.Label();
            this.sectionText = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.roomNumberTxt = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSubmitForm);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.speakerText);
            this.panel1.Controls.Add(this.lblSpeaker);
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
            // btnSubmitForm
            // 
            this.btnSubmitForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(79)))));
            this.btnSubmitForm.FlatAppearance.BorderSize = 0;
            this.btnSubmitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitForm.ForeColor = System.Drawing.Color.White;
            this.btnSubmitForm.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnSubmitForm.IconColor = System.Drawing.Color.White;
            this.btnSubmitForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmitForm.Location = new System.Drawing.Point(314, 319);
            this.btnSubmitForm.Name = "btnSubmitForm";
            this.btnSubmitForm.Size = new System.Drawing.Size(200, 51);
            this.btnSubmitForm.TabIndex = 8;
            this.btnSubmitForm.Text = "Submit";
            this.btnSubmitForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmitForm.UseVisualStyleBackColor = false;
            this.btnSubmitForm.Click += new System.EventHandler(this.btnSubmitForm_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDate.Location = new System.Drawing.Point(254, 254);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 23);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // speakerText
            // 
            this.speakerText.Location = new System.Drawing.Point(314, 205);
            this.speakerText.Name = "speakerText";
            this.speakerText.Size = new System.Drawing.Size(200, 22);
            this.speakerText.TabIndex = 5;
            // 
            // lblSpeaker
            // 
            this.lblSpeaker.AutoSize = true;
            this.lblSpeaker.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeaker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSpeaker.Location = new System.Drawing.Point(221, 203);
            this.lblSpeaker.Name = "lblSpeaker";
            this.lblSpeaker.Size = new System.Drawing.Size(87, 23);
            this.lblSpeaker.TabIndex = 4;
            this.lblSpeaker.Text = "Speaker";
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
            this.lblSection.Location = new System.Drawing.Point(188, 98);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(120, 23);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Start Time";
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
            this.lblRoom.Location = new System.Drawing.Point(177, 45);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(131, 23);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Room Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(210, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "End Time";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(776, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
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
        private FontAwesome.Sharp.IconButton btnSubmitForm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox speakerText;
        private System.Windows.Forms.Label lblSpeaker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}