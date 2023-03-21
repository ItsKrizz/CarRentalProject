namespace CarRental.FormApp
{
    partial class VehichleForm
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            listBox2 = new System.Windows.Forms.ListBox();
            button2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sunset_Tate_Quote;
            pictureBox1.Location = new System.Drawing.Point(451, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(244, 229);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 253);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = " Delete Vehicle By ID";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(118, 270);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new System.Drawing.Point(12, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(433, 229);
            listBox2.TabIndex = 4;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(118, 336);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Get";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 318);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Get Vehicle By Id";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(370, 358);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(359, 251);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Add Vehicle";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(294, 275);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 15);
            label4.TabIndex = 13;
            label4.Text = "Make";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(294, 304);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 15);
            label5.TabIndex = 14;
            label5.Text = "Model";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(294, 329);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(29, 15);
            label6.TabIndex = 15;
            label6.Text = "Year";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(12, 395);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(433, 43);
            button4.TabIndex = 16;
            button4.Text = "Main Menu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(473, 293);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(199, 88);
            label7.TabIndex = 17;
            label7.Text = "Top G\r\nVehicles";
            label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(12, 336);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(345, 272);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 20;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(345, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 23);
            textBox4.TabIndex = 21;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(345, 329);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(100, 23);
            textBox5.TabIndex = 22;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(12, 365);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(181, 19);
            listBox1.TabIndex = 23;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // VehichleForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(703, 450);
            Controls.Add(listBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximumSize = new System.Drawing.Size(719, 489);
            MinimumSize = new System.Drawing.Size(719, 489);
            Name = "VehichleForm";
            Text = "VehichleForm";
            Load += VehichleForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListBox listBox1;
    }
}