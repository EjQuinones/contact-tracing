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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.genderTextbox = new System.Windows.Forms.TextBox();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.genderLabel3 = new System.Windows.Forms.Label();
            this.ageLabel4 = new System.Windows.Forms.Label();
            this.addressLabel5 = new System.Windows.Forms.Label();
            this.dateLabel6 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.temperaturelabel7 = new System.Windows.Forms.Label();
            this.temperatureTextbox = new System.Windows.Forms.TextBox();
            this.motherLabel8 = new System.Windows.Forms.Label();
            this.motherTextbox = new System.Windows.Forms.TextBox();
            this.fatherLabel9 = new System.Windows.Forms.Label();
            this.motheroccupationTextbox = new System.Windows.Forms.TextBox();
            this.motheroccupationlabel8 = new System.Windows.Forms.Label();
            this.fatherTextbox = new System.Windows.Forms.TextBox();
            this.fatherOccupationLabel10 = new System.Windows.Forms.Label();
            this.fatherOccupationTextbox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.Responded = new System.Windows.Forms.RichTextBox();
            this.respondbutton = new System.Windows.Forms.Button();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.qrLabel2 = new System.Windows.Forms.Label();
            this.qrPictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.QrvideoComboBox1 = new System.Windows.Forms.ComboBox();
            this.QrTextBox1 = new System.Windows.Forms.TextBox();
            this.CreateButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contract - Tracing";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(88, 91);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(334, 23);
            this.nameTextbox.TabIndex = 7;
            this.nameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // genderTextbox
            // 
            this.genderTextbox.Location = new System.Drawing.Point(112, 127);
            this.genderTextbox.Name = "genderTextbox";
            this.genderTextbox.Size = new System.Drawing.Size(100, 23);
            this.genderTextbox.TabIndex = 8;
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(312, 128);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(100, 23);
            this.ageTextbox.TabIndex = 9;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(124, 163);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(429, 23);
            this.addressTextbox.TabIndex = 10;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(88, 330);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(18, 23);
            this.monthTextBox.TabIndex = 12;
            this.monthTextBox.TextChanged += new System.EventHandler(this.DateTextbox_TextChanged);
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel2.Location = new System.Drawing.Point(12, 90);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(70, 24);
            this.nameLabel2.TabIndex = 13;
            this.nameLabel2.Text = "Name:";
            // 
            // genderLabel3
            // 
            this.genderLabel3.AutoSize = true;
            this.genderLabel3.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderLabel3.Location = new System.Drawing.Point(12, 127);
            this.genderLabel3.Name = "genderLabel3";
            this.genderLabel3.Size = new System.Drawing.Size(94, 24);
            this.genderLabel3.TabIndex = 14;
            this.genderLabel3.Text = "Gender:";
            // 
            // ageLabel4
            // 
            this.ageLabel4.AutoSize = true;
            this.ageLabel4.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLabel4.Location = new System.Drawing.Point(248, 126);
            this.ageLabel4.Name = "ageLabel4";
            this.ageLabel4.Size = new System.Drawing.Size(58, 24);
            this.ageLabel4.TabIndex = 15;
            this.ageLabel4.Text = "Age:";
            // 
            // addressLabel5
            // 
            this.addressLabel5.AutoSize = true;
            this.addressLabel5.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel5.Location = new System.Drawing.Point(12, 162);
            this.addressLabel5.Name = "addressLabel5";
            this.addressLabel5.Size = new System.Drawing.Size(106, 24);
            this.addressLabel5.TabIndex = 16;
            this.addressLabel5.Text = "Address:";
            // 
            // dateLabel6
            // 
            this.dateLabel6.AutoSize = true;
            this.dateLabel6.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel6.Location = new System.Drawing.Point(12, 329);
            this.dateLabel6.Name = "dateLabel6";
            this.dateLabel6.Size = new System.Drawing.Size(70, 24);
            this.dateLabel6.TabIndex = 17;
            this.dateLabel6.Text = "Date:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(380, 512);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(141, 45);
            this.submitButton.TabIndex = 19;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // temperaturelabel7
            // 
            this.temperaturelabel7.AutoSize = true;
            this.temperaturelabel7.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temperaturelabel7.Location = new System.Drawing.Point(12, 361);
            this.temperaturelabel7.Name = "temperaturelabel7";
            this.temperaturelabel7.Size = new System.Drawing.Size(154, 24);
            this.temperaturelabel7.TabIndex = 20;
            this.temperaturelabel7.Text = "Temperature:";
            this.temperaturelabel7.Click += new System.EventHandler(this.Temperaturelabel7_Click);
            // 
            // temperatureTextbox
            // 
            this.temperatureTextbox.Location = new System.Drawing.Point(172, 362);
            this.temperatureTextbox.Name = "temperatureTextbox";
            this.temperatureTextbox.Size = new System.Drawing.Size(100, 23);
            this.temperatureTextbox.TabIndex = 21;
            this.temperatureTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // motherLabel8
            // 
            this.motherLabel8.AutoSize = true;
            this.motherLabel8.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motherLabel8.Location = new System.Drawing.Point(12, 192);
            this.motherLabel8.Name = "motherLabel8";
            this.motherLabel8.Size = new System.Drawing.Size(178, 24);
            this.motherLabel8.TabIndex = 22;
            this.motherLabel8.Text = "Mother\'s Name:";
            // 
            // motherTextbox
            // 
            this.motherTextbox.Location = new System.Drawing.Point(196, 193);
            this.motherTextbox.Name = "motherTextbox";
            this.motherTextbox.Size = new System.Drawing.Size(268, 23);
            this.motherTextbox.TabIndex = 23;
            // 
            // fatherLabel9
            // 
            this.fatherLabel9.AutoSize = true;
            this.fatherLabel9.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fatherLabel9.Location = new System.Drawing.Point(12, 263);
            this.fatherLabel9.Name = "fatherLabel9";
            this.fatherLabel9.Size = new System.Drawing.Size(178, 24);
            this.fatherLabel9.TabIndex = 24;
            this.fatherLabel9.Text = "Father\'s Name:";
            // 
            // motheroccupationTextbox
            // 
            this.motheroccupationTextbox.Location = new System.Drawing.Point(160, 228);
            this.motheroccupationTextbox.Name = "motheroccupationTextbox";
            this.motheroccupationTextbox.Size = new System.Drawing.Size(266, 23);
            this.motheroccupationTextbox.TabIndex = 25;
            // 
            // motheroccupationlabel8
            // 
            this.motheroccupationlabel8.AutoSize = true;
            this.motheroccupationlabel8.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motheroccupationlabel8.Location = new System.Drawing.Point(12, 227);
            this.motheroccupationlabel8.Name = "motheroccupationlabel8";
            this.motheroccupationlabel8.Size = new System.Drawing.Size(142, 24);
            this.motheroccupationlabel8.TabIndex = 26;
            this.motheroccupationlabel8.Text = "Occupation:";
            // 
            // fatherTextbox
            // 
            this.fatherTextbox.Location = new System.Drawing.Point(196, 263);
            this.fatherTextbox.Name = "fatherTextbox";
            this.fatherTextbox.Size = new System.Drawing.Size(268, 23);
            this.fatherTextbox.TabIndex = 27;
            // 
            // fatherOccupationLabel10
            // 
            this.fatherOccupationLabel10.AutoSize = true;
            this.fatherOccupationLabel10.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fatherOccupationLabel10.Location = new System.Drawing.Point(12, 296);
            this.fatherOccupationLabel10.Name = "fatherOccupationLabel10";
            this.fatherOccupationLabel10.Size = new System.Drawing.Size(142, 24);
            this.fatherOccupationLabel10.TabIndex = 28;
            this.fatherOccupationLabel10.Text = "Occupation:";
            // 
            // fatherOccupationTextbox
            // 
            this.fatherOccupationTextbox.Location = new System.Drawing.Point(160, 297);
            this.fatherOccupationTextbox.Name = "fatherOccupationTextbox";
            this.fatherOccupationTextbox.Size = new System.Drawing.Size(274, 23);
            this.fatherOccupationTextbox.TabIndex = 29;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(873, 534);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 30;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Responded
            // 
            this.Responded.Location = new System.Drawing.Point(278, 326);
            this.Responded.Name = "Responded";
            this.Responded.Size = new System.Drawing.Size(287, 180);
            this.Responded.TabIndex = 32;
            this.Responded.Text = "";
            // 
            // respondbutton
            // 
            this.respondbutton.Location = new System.Drawing.Point(12, 36);
            this.respondbutton.Name = "respondbutton";
            this.respondbutton.Size = new System.Drawing.Size(94, 30);
            this.respondbutton.TabIndex = 33;
            this.respondbutton.Text = "Record";
            this.respondbutton.UseVisualStyleBackColor = true;
            this.respondbutton.Click += new System.EventHandler(this.Respondbutton_Click);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(112, 330);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(19, 23);
            this.dayTextBox.TabIndex = 34;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(136, 330);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(54, 23);
            this.yearTextBox.TabIndex = 35;
            // 
            // qrLabel2
            // 
            this.qrLabel2.AutoSize = true;
            this.qrLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qrLabel2.Location = new System.Drawing.Point(736, 41);
            this.qrLabel2.Name = "qrLabel2";
            this.qrLabel2.Size = new System.Drawing.Size(82, 25);
            this.qrLabel2.TabIndex = 36;
            this.qrLabel2.Text = "Qr Code";
            // 
            // qrPictureBox1
            // 
            this.qrPictureBox1.BackColor = System.Drawing.Color.White;
            this.qrPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qrPictureBox1.Location = new System.Drawing.Point(571, 98);
            this.qrPictureBox1.Name = "qrPictureBox1";
            this.qrPictureBox1.Size = new System.Drawing.Size(377, 273);
            this.qrPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.qrPictureBox1.TabIndex = 40;
            this.qrPictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QrvideoComboBox1
            // 
            this.QrvideoComboBox1.FormattingEnabled = true;
            this.QrvideoComboBox1.Location = new System.Drawing.Point(628, 69);
            this.QrvideoComboBox1.Name = "QrvideoComboBox1";
            this.QrvideoComboBox1.Size = new System.Drawing.Size(276, 23);
            this.QrvideoComboBox1.TabIndex = 41;
            // 
            // QrTextBox1
            // 
            this.QrTextBox1.Location = new System.Drawing.Point(616, 377);
            this.QrTextBox1.Multiline = true;
            this.QrTextBox1.Name = "QrTextBox1";
            this.QrTextBox1.Size = new System.Drawing.Size(311, 82);
            this.QrTextBox1.TabIndex = 42;
            // 
            // CreateButton1
            // 
            this.CreateButton1.Location = new System.Drawing.Point(729, 465);
            this.CreateButton1.Name = "CreateButton1";
            this.CreateButton1.Size = new System.Drawing.Size(89, 32);
            this.CreateButton1.TabIndex = 43;
            this.CreateButton1.Text = "Create";
            this.CreateButton1.UseVisualStyleBackColor = true;
            this.CreateButton1.Click += new System.EventHandler(this.CreateButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 569);
            this.Controls.Add(this.CreateButton1);
            this.Controls.Add(this.QrTextBox1);
            this.Controls.Add(this.QrvideoComboBox1);
            this.Controls.Add(this.qrPictureBox1);
            this.Controls.Add(this.qrLabel2);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.respondbutton);
            this.Controls.Add(this.Responded);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fatherOccupationTextbox);
            this.Controls.Add(this.fatherOccupationLabel10);
            this.Controls.Add(this.fatherTextbox);
            this.Controls.Add(this.motheroccupationlabel8);
            this.Controls.Add(this.motheroccupationTextbox);
            this.Controls.Add(this.fatherLabel9);
            this.Controls.Add(this.motherTextbox);
            this.Controls.Add(this.motherLabel8);
            this.Controls.Add(this.temperatureTextbox);
            this.Controls.Add(this.temperaturelabel7);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dateLabel6);
            this.Controls.Add(this.addressLabel5);
            this.Controls.Add(this.ageLabel4);
            this.Controls.Add(this.genderLabel3);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.genderTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Contract_Tracing ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.qrPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void NewMethod()
        {
            this.qrPictureBox1.Click += new System.EventHandler(this.qrPictureBox1_Click);
        }

        #endregion
        private Label label1;
        private TextBox nameTextbox;
        private TextBox genderTextbox;
        private TextBox ageTextbox;
        private TextBox addressTextbox;
        private TextBox monthTextBox;
        private Label nameLabel2;
        private Label genderLabel3;
        private Label ageLabel4;
        private Label addressLabel5;
        private Label dateLabel6;
        private Button submitButton;
        private Label temperaturelabel7;
        private TextBox temperatureTextbox;
        private Label motherLabel8;
        private TextBox motherTextbox;
        private Label fatherLabel9;
        private TextBox motheroccupationTextbox;
        private Label motheroccupationlabel8;
        private TextBox fatherTextbox;
        private Label fatherOccupationLabel10;
        private TextBox fatherOccupationTextbox;
        private Button exitButton;
        private RichTextBox Responded;
        private Button respondbutton;
        private TextBox dayTextBox;
        private TextBox yearTextBox;
        private Label qrLabel2;
        private PictureBox qrPictureBox1;
        private System.Windows.Forms.Timer timer1;
        private ComboBox QrvideoComboBox1;
        private FormClosingEventHandler Form1_FormClosing;
        private EventHandler Form1_Load;
        private EventHandler qrPictureBox1_Click;
        private TextBox QrTextBox1;
        private Button CreateButton1;
    }
}