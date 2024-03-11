namespace L2Ex4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            holongar = new RadioButton();
            regina = new RadioButton();
            groupBox1 = new GroupBox();
            salahor = new RadioButton();
            rege = new RadioButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(742, 406);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(734, 368);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(227, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 338);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(22, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(734, 368);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(holongar);
            groupBox2.Controls.Add(regina);
            groupBox2.Location = new Point(389, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // holongar
            // 
            holongar.AutoSize = true;
            holongar.Location = new Point(3, 64);
            holongar.Name = "holongar";
            holongar.Size = new Size(109, 29);
            holongar.TabIndex = 1;
            holongar.TabStop = true;
            holongar.Text = "holongar";
            holongar.UseVisualStyleBackColor = true;
            holongar.CheckedChanged += holongar_CheckedChanged;
            // 
            // regina
            // 
            regina.AutoSize = true;
            regina.Location = new Point(3, 27);
            regina.Name = "regina";
            regina.Size = new Size(86, 29);
            regina.TabIndex = 0;
            regina.TabStop = true;
            regina.Text = "regina";
            regina.UseVisualStyleBackColor = true;
            regina.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(salahor);
            groupBox1.Controls.Add(rege);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // salahor
            // 
            salahor.AutoSize = true;
            salahor.Location = new Point(6, 76);
            salahor.Name = "salahor";
            salahor.Size = new Size(94, 29);
            salahor.TabIndex = 1;
            salahor.TabStop = true;
            salahor.Text = "salahor";
            salahor.UseVisualStyleBackColor = true;
            salahor.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rege
            // 
            rege.AutoSize = true;
            rege.Location = new Point(3, 27);
            rege.Name = "rege";
            rege.Size = new Size(72, 29);
            rege.TabIndex = 0;
            rege.TabStop = true;
            rege.Text = "rege";
            rege.TextAlign = ContentAlignment.MiddleCenter;
            rege.UseVisualStyleBackColor = true;
            rege.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox listBox1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton salahor;
        private RadioButton rege;
        private GroupBox groupBox2;
        private RadioButton holongar;
        private RadioButton regina;
    }
}
