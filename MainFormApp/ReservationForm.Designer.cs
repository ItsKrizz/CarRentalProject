namespace CarRental.FormApp
{
    partial class ReservationForm
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
            listBox1 = new System.Windows.Forms.ListBox();
            textBox1 = new System.Windows.Forms.TextBox();
            listBox2 = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            listBox3 = new System.Windows.Forms.ListBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            listBox4 = new System.Windows.Forms.ListBox();
            textBox3 = new System.Windows.Forms.TextBox();
            button4 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(11, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(431, 214);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(76, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new System.Drawing.Point(12, 289);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(157, 19);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(94, 258);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Get";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 240);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 15);
            label1.TabIndex = 4;
            label1.Text = "Get Reservation By ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(229, 326);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 15);
            label2.TabIndex = 8;
            label2.Text = "Get Reservation By Customer ID";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(328, 346);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Get";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new System.Drawing.Point(229, 375);
            listBox3.Name = "listBox3";
            listBox3.Size = new System.Drawing.Size(172, 19);
            listBox3.TabIndex = 6;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(229, 347);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(93, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 328);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(159, 15);
            label3.TabIndex = 12;
            label3.Text = "Get Reservation By Vehicle ID";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(129, 347);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Get";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new System.Drawing.Point(10, 375);
            listBox4.Name = "listBox4";
            listBox4.Size = new System.Drawing.Size(194, 19);
            listBox4.TabIndex = 10;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(10, 346);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(113, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(10, 409);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(426, 72);
            button4.TabIndex = 13;
            button4.Text = "Main Menu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.Location = new System.Drawing.Point(448, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(283, 261);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(184, 240);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(252, 68);
            label4.TabIndex = 15;
            label4.Text = "Add \r\nReservation➡️";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(442, 285);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 15);
            label5.TabIndex = 16;
            label5.Text = "Start Date";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(444, 314);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 15);
            label6.TabIndex = 17;
            label6.Text = "End Date";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(442, 340);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(60, 15);
            label7.TabIndex = 18;
            label7.Text = "Vehicle Id ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(442, 369);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 15);
            label8.TabIndex = 19;
            label8.Text = "Customer ID";
            label8.Click += label8_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(525, 279);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(525, 308);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            dateTimePicker2.TabIndex = 21;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(525, 337);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(200, 23);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(525, 366);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(200, 23);
            textBox5.TabIndex = 23;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(442, 409);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(283, 72);
            button5.TabIndex = 24;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(737, 493);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(listBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(listBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            MaximumSize = new System.Drawing.Size(753, 532);
            MinimumSize = new System.Drawing.Size(753, 532);
            Name = "ReservationForm";
            Text = "ReservationForm";
            Load += ReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
    }
}