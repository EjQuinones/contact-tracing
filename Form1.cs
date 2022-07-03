
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Quinones_contract_tracing
{
    public partial class Form1 : Form
    {
        public object QrCodeGenerator { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (yearTextBox.Text == "2022")
                year2022();
            else if (yearTextBox.Text == "2023")
                year2023();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Respondbutton_Click(object sender, EventArgs e)
        {
            if (yearTextBox.Text == "2022")
                Readyear2022();
            else if (yearTextBox.Text == "2023")
                Readyear2023();
        }
        private void year2022()
        {
            string nameOfText = nameTextbox.Text;
            StreamWriter file = new StreamWriter(@"C:\Users\Ej Quinones\Desktop\TRACING - APP DEMO\2022\" + nameTextbox.Text + ".txt");
            file.Write("");
            file.WriteLine("Your Name :" + nameTextbox.Text);
            file.WriteLine("Your Gender :" + genderTextbox.Text);
            file.WriteLine("Your Age :" + ageTextbox.Text);
            file.WriteLine("Your Address :" + addressTextbox.Text);
            file.WriteLine("Date today :" + monthTextBox.Text + "/" + dayTextBox.Text + "/" + yearTextBox.Text);
            file.WriteLine("Temperature :" + temperatureTextbox.Text);
            file.WriteLine("Mother's Name :" + motherTextbox.Text);
            file.WriteLine("Mother's Occupation :" + motheroccupationTextbox.Text);
            file.WriteLine("Father's Name :" + fatherTextbox.Text);
            file.WriteLine("Father's Occupation :" + fatherOccupationTextbox.Text);
            file.Close();
        }
        private void year2023()
        {
            string nameOfText = nameTextbox.Text;
            StreamWriter file = new StreamWriter(@"C:\Users\Ej Quinones\Desktop\TRACING - APP DEMO\2023\" + nameTextbox.Text + ".txt");
            file.Write("");
            file.WriteLine("Your Name :" + nameTextbox.Text);
            file.WriteLine("Your Gender :" + genderTextbox.Text);
            file.WriteLine("Your Age :" + ageTextbox.Text);
            file.WriteLine("Your Address :" + addressTextbox.Text);
            file.WriteLine("Date today :" + monthTextBox.Text + "/" + dayTextBox.Text + "/" + yearTextBox.Text);
            file.WriteLine("Temperature :" + temperatureTextbox.Text);
            file.WriteLine("Mother's Name :" + motherTextbox.Text);
            file.WriteLine("Mother's Occupation :" + motheroccupationTextbox.Text);
            file.WriteLine("Father's Name :" + fatherTextbox.Text);
            file.WriteLine("Father's Occupation :" + fatherOccupationTextbox.Text);
            file.Close();
        }
        private void Readyear2022()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Ej Quinones\Desktop\TRACING - APP DEMO\2022\" + nameTextbox.Text + ".txt");
            Responded.Text = sr.ReadToEnd();
        }
        private void Readyear2023()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Ej Quinones\Desktop\2023\TRACING - APP DEMO\2023\" + nameTextbox.Text + ".txt");
            Responded.Text = sr.ReadToEnd();
        }

        private void DateTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Temperaturelabel7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                QrvideoComboBox1.Items.Add(filterInfo);
            QrvideoComboBox1.SelectedIndex = 0;
        }

        private ComboBox GetQrvideoComboBox1()
        {
            return QrvideoComboBox1;
        }

        private void CreateButton1_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[QrvideoComboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            qrPictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (qrPictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)qrPictureBox1.Image);
                if (result != null)
                {
                    QrTextBox1.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }
    }
}


    
