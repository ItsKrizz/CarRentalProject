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
            SuspendLayout();
            // 
            // BtnCustomerService
            // 
            BtnCustomerService.Location = new System.Drawing.Point(46, 51);
            BtnCustomerService.Name = "BtnCustomerService";
            BtnCustomerService.Size = new System.Drawing.Size(104, 54);
            BtnCustomerService.TabIndex = 0;
            BtnCustomerService.Text = "Customer service";
            BtnCustomerService.UseVisualStyleBackColor = true;
            BtnCustomerService.Click += BtnCustomerService_Click;
            // 
            // BtnLocationService
            // 
            BtnLocationService.Location = new System.Drawing.Point(46, 121);
            BtnLocationService.Name = "BtnLocationService";
            BtnLocationService.Size = new System.Drawing.Size(104, 54);
            BtnLocationService.TabIndex = 1;
            BtnLocationService.Text = "Location service";
            BtnLocationService.UseVisualStyleBackColor = true;
            BtnLocationService.Click += BtnLocationService_Click;
            // 
            // BtnReservationService
            // 
            BtnReservationService.Location = new System.Drawing.Point(46, 190);
            BtnReservationService.Name = "BtnReservationService";
            BtnReservationService.Size = new System.Drawing.Size(104, 54);
            BtnReservationService.TabIndex = 2;
            BtnReservationService.Text = "Reservation service";
            BtnReservationService.UseVisualStyleBackColor = true;
            BtnReservationService.Click += BtnReservationService_Click;
            // 
            // BtnVehichleService
            // 
            BtnVehichleService.Location = new System.Drawing.Point(46, 261);
            BtnVehichleService.Name = "BtnVehichleService";
            BtnVehichleService.Size = new System.Drawing.Size(104, 54);
            BtnVehichleService.TabIndex = 3;
            BtnVehichleService.Text = "Vehichle service";
            BtnVehichleService.UseVisualStyleBackColor = true;
            BtnVehichleService.Click += BtnVehichleService_Click;
            // 
            // MainFormApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(202, 372);
            Controls.Add(BtnVehichleService);
            Controls.Add(BtnReservationService);
            Controls.Add(BtnLocationService);
            Controls.Add(BtnCustomerService);
            Name = "MainFormApp";
            Text = "Choose option";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button BtnCustomerService;
        private System.Windows.Forms.Button BtnLocationService;
        private System.Windows.Forms.Button BtnReservationService;
        private System.Windows.Forms.Button BtnVehichleService;
    }
}
