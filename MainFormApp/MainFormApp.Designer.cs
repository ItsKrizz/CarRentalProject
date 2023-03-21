namespace MainFormApp
{
    partial class MainFormApp
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
            BtnCustomerService = new System.Windows.Forms.Button();
            BtnLocationService = new System.Windows.Forms.Button();
            BtnReservationService = new System.Windows.Forms.Button();
            BtnVehichleService = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnCustomerService
            // 
            BtnCustomerService.Location = new System.Drawing.Point(525, 12);
            BtnCustomerService.Name = "BtnCustomerService";
            BtnCustomerService.Size = new System.Drawing.Size(165, 123);
            BtnCustomerService.TabIndex = 0;
            BtnCustomerService.Text = "Customer service";
            BtnCustomerService.UseVisualStyleBackColor = true;
            BtnCustomerService.Click += BtnCustomerService_Click;
            // 
            // BtnLocationService
            // 
            BtnLocationService.Location = new System.Drawing.Point(354, 141);
            BtnLocationService.Name = "BtnLocationService";
            BtnLocationService.Size = new System.Drawing.Size(165, 123);
            BtnLocationService.TabIndex = 1;
            BtnLocationService.Text = "Location service";
            BtnLocationService.UseVisualStyleBackColor = true;
            BtnLocationService.Click += BtnLocationService_Click;
            // 
            // BtnReservationService
            // 
            BtnReservationService.Location = new System.Drawing.Point(354, 12);
            BtnReservationService.Name = "BtnReservationService";
            BtnReservationService.Size = new System.Drawing.Size(165, 123);
            BtnReservationService.TabIndex = 2;
            BtnReservationService.Text = "Reservation service";
            BtnReservationService.UseVisualStyleBackColor = true;
            BtnReservationService.Click += BtnReservationService_Click;
            // 
            // BtnVehichleService
            // 
            BtnVehichleService.Location = new System.Drawing.Point(525, 141);
            BtnVehichleService.Name = "BtnVehichleService";
            BtnVehichleService.Size = new System.Drawing.Size(165, 123);
            BtnVehichleService.TabIndex = 3;
            BtnVehichleService.Text = "Vehichle service";
            BtnVehichleService.UseVisualStyleBackColor = true;
            BtnVehichleService.Click += BtnVehichleService_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(242, 276);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(233, 84);
            label1.TabIndex = 4;
            label1.Text = "Car Rental\r\nSystem";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CarRental.FormApp.Properties.Resources.maxresdefault;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(336, 252);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MainFormApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(698, 369);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(BtnVehichleService);
            Controls.Add(BtnReservationService);
            Controls.Add(BtnLocationService);
            Controls.Add(BtnCustomerService);
            MaximumSize = new System.Drawing.Size(714, 408);
            MinimumSize = new System.Drawing.Size(714, 408);
            Name = "MainFormApp";
            Text = "Choose option";
            Load += MainFormApp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BtnCustomerService;
        private System.Windows.Forms.Button BtnLocationService;
        private System.Windows.Forms.Button BtnReservationService;
        private System.Windows.Forms.Button BtnVehichleService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
