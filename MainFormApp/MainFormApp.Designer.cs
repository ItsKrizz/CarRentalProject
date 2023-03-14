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
            this.BtnCustomerService = new System.Windows.Forms.Button();
            this.BtnLocationService = new System.Windows.Forms.Button();
            this.BtnReservationService = new System.Windows.Forms.Button();
            this.BtnVehichleService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCustomerService
            // 
            this.BtnCustomerService.Location = new System.Drawing.Point(46, 51);
            this.BtnCustomerService.Name = "BtnCustomerService";
            this.BtnCustomerService.Size = new System.Drawing.Size(104, 54);
            this.BtnCustomerService.TabIndex = 0;
            this.BtnCustomerService.Text = "Customer service";
            this.BtnCustomerService.UseVisualStyleBackColor = true;
            this.BtnCustomerService.Click += new System.EventHandler(this.BtnCustomerService_Click);
            // 
            // BtnLocationService
            // 
            this.BtnLocationService.Location = new System.Drawing.Point(46, 121);
            this.BtnLocationService.Name = "BtnLocationService";
            this.BtnLocationService.Size = new System.Drawing.Size(104, 54);
            this.BtnLocationService.TabIndex = 1;
            this.BtnLocationService.Text = "Location service";
            this.BtnLocationService.UseVisualStyleBackColor = true;
            this.BtnLocationService.Click += new System.EventHandler(this.BtnLocationService_Click);
            // 
            // BtnReservationService
            // 
            this.BtnReservationService.Location = new System.Drawing.Point(46, 190);
            this.BtnReservationService.Name = "BtnReservationService";
            this.BtnReservationService.Size = new System.Drawing.Size(104, 54);
            this.BtnReservationService.TabIndex = 2;
            this.BtnReservationService.Text = "Reservation service";
            this.BtnReservationService.UseVisualStyleBackColor = true;
            this.BtnReservationService.Click += new System.EventHandler(this.BtnReservationService_Click);
            // 
            // BtnVehichleService
            // 
            this.BtnVehichleService.Location = new System.Drawing.Point(46, 261);
            this.BtnVehichleService.Name = "BtnVehichleService";
            this.BtnVehichleService.Size = new System.Drawing.Size(104, 54);
            this.BtnVehichleService.TabIndex = 3;
            this.BtnVehichleService.Text = "Vehichle service";
            this.BtnVehichleService.UseVisualStyleBackColor = true;
            this.BtnVehichleService.Click += new System.EventHandler(this.BtnVehichleService_Click);
            // 
            // MainFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 383);
            this.Controls.Add(this.BtnVehichleService);
            this.Controls.Add(this.BtnReservationService);
            this.Controls.Add(this.BtnLocationService);
            this.Controls.Add(this.BtnCustomerService);
            this.Name = "MainFormApp";
            this.Text = "Choose option";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCustomerService;
        private System.Windows.Forms.Button BtnLocationService;
        private System.Windows.Forms.Button BtnReservationService;
        private System.Windows.Forms.Button BtnVehichleService;
    }
}
