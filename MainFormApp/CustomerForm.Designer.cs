namespace CarRental.FormApp
{
    partial class CustomerForm
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
            components = new System.ComponentModel.Container();
            listBox1 = new System.Windows.Forms.ListBox();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            listBox2 = new System.Windows.Forms.ListBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            imageList2 = new System.Windows.Forms.ImageList(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(12, 99);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(483, 364);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(209, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(227, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(268, 37);
            button1.TabIndex = 2;
            button1.Text = "Find By ID";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new System.Drawing.Point(12, 55);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(483, 34);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(505, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(649, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(505, 178);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 23);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(507, 142);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(505, 204);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 8;
            label2.Text = "E-Mail";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(650, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 15);
            label3.TabIndex = 9;
            label3.Text = "Phone Number";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(650, 177);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 23);
            button2.TabIndex = 10;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(535, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(189, 76);
            label4.TabIndex = 11;
            label4.Text = "Add \r\nCustomer";
            label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(505, 397);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(245, 66);
            button3.TabIndex = 12;
            button3.Text = "Main Menu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList2.ImageSize = new System.Drawing.Size(16, 16);
            imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cover_Image__21motoring_2_4;
            pictureBox1.Location = new System.Drawing.Point(505, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(245, 150);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(761, 475);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            MaximumSize = new System.Drawing.Size(777, 514);
            MinimumSize = new System.Drawing.Size(777, 514);
            Name = "CustomerForm";
            Text = "Customer Info";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}