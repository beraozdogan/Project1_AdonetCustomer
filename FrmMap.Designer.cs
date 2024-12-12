namespace Project1_AdonetCustomer
{
    partial class FrmMap
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
            this.btnOpenCity = new System.Windows.Forms.Button();
            this.btnOpenCustomerForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCity
            // 
            this.btnOpenCity.Location = new System.Drawing.Point(29, 42);
            this.btnOpenCity.Name = "btnOpenCity";
            this.btnOpenCity.Size = new System.Drawing.Size(118, 44);
            this.btnOpenCity.TabIndex = 0;
            this.btnOpenCity.Text = "Şehir İşlemleri";
            this.btnOpenCity.UseVisualStyleBackColor = true;
            this.btnOpenCity.Click += new System.EventHandler(this.btnOpenCity_Click);
            // 
            // btnOpenCustomerForm
            // 
            this.btnOpenCustomerForm.Location = new System.Drawing.Point(29, 118);
            this.btnOpenCustomerForm.Name = "btnOpenCustomerForm";
            this.btnOpenCustomerForm.Size = new System.Drawing.Size(118, 44);
            this.btnOpenCustomerForm.TabIndex = 1;
            this.btnOpenCustomerForm.Text = "Müşteri İşlemleri";
            this.btnOpenCustomerForm.UseVisualStyleBackColor = true;
            this.btnOpenCustomerForm.Click += new System.EventHandler(this.btnOpenCustomerForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(29, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 274);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenCustomerForm);
            this.Controls.Add(this.btnOpenCity);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCity;
        private System.Windows.Forms.Button btnOpenCustomerForm;
        private System.Windows.Forms.Button btnExit;
    }
}