namespace Quinones_contract_tracing
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
            this.NameButton1 = new System.Windows.Forms.Button();
            this.AgeButton2 = new System.Windows.Forms.Button();
            this.AddressButton = new System.Windows.Forms.Button();
            this.GenderButton = new System.Windows.Forms.Button();
            this.DateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameButton1
            // 
            this.NameButton1.Location = new System.Drawing.Point(12, 12);
            this.NameButton1.Name = "NameButton1";
            this.NameButton1.Size = new System.Drawing.Size(75, 33);
            this.NameButton1.TabIndex = 0;
            this.NameButton1.Text = "Name";
            this.NameButton1.UseVisualStyleBackColor = true;
            this.NameButton1.Click += new System.EventHandler(this.Namebutton_Click);
            // 
            // AgeButton2
            // 
            this.AgeButton2.Location = new System.Drawing.Point(180, 51);
            this.AgeButton2.Name = "AgeButton2";
            this.AgeButton2.Size = new System.Drawing.Size(75, 33);
            this.AgeButton2.TabIndex = 1;
            this.AgeButton2.Text = "Age";
            this.AgeButton2.UseVisualStyleBackColor = true;
            this.AgeButton2.Click += new System.EventHandler(this.AgeButton2_Click);
            // 
            // AddressButton
            // 
            this.AddressButton.Location = new System.Drawing.Point(12, 90);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(75, 33);
            this.AddressButton.TabIndex = 2;
            this.AddressButton.Text = " Address";
            this.AddressButton.UseVisualStyleBackColor = true;
            this.AddressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // GenderButton
            // 
            this.GenderButton.Location = new System.Drawing.Point(12, 51);
            this.GenderButton.Name = "GenderButton";
            this.GenderButton.Size = new System.Drawing.Size(75, 33);
            this.GenderButton.TabIndex = 3;
            this.GenderButton.Text = "Gender";
            this.GenderButton.UseVisualStyleBackColor = true;
            this.GenderButton.Click += new System.EventHandler(this.GenderButton_Click);
            // 
            // DateButton
            // 
            this.DateButton.Location = new System.Drawing.Point(784, 51);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(75, 33);
            this.DateButton.TabIndex = 4;
            this.DateButton.Text = "Date";
            this.DateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 457);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.GenderButton);
            this.Controls.Add(this.AddressButton);
            this.Controls.Add(this.AgeButton2);
            this.Controls.Add(this.NameButton1);
            this.Name = "Form1";
            this.Text = "Contract_Tracing ";
            this.ResumeLayout(false);

        }

        #endregion

        private Button NameButton1;
        private Button AgeButton2;
        private Button AddressButton;
        private Button GenderButton;
        private Button DateButton;
    }
}