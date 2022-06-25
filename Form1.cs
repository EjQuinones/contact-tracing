namespace Quinones_contract_tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object MessageShow { get; private set; }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (DateTextbox.Text == "2022")
                year2022();
            else if (DateTextbox.Text == "2023")
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
           
        }
        private void year2022()
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Ej Quinones\Desktop\TRACING - APP DEMO\2022\Contact Tracing Demo.txt");
            file.Write("");
            file.WriteLine("Your Name :" + NameTextbox.Text);
            file.WriteLine("Your Gender :" + GenderTextbox.Text);
            file.WriteLine("Your Age :" + AgeTextbox.Text);
            file.WriteLine("Your Address :" + AddressTextbox.Text);
            file.WriteLine("Date today :" + DateTextbox.Text);
            file.WriteLine("Temperature :" + TemperatureTextbox.Text);
            file.WriteLine("Mother's Name :" + MotherTextbox.Text);
            file.WriteLine("Mother's Occupation :" + MotherOccupationTextbox.Text);
            file.WriteLine("Father's Name :" + FatherTextbox.Text);
            file.WriteLine("Father's Occupation :" + FatherOccupationTextbox.Text);
            file.Close();
        }
        private void year2023()
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Ej Quinones\Desktop\TRACING - APP DEMO\2023\Contact Tracing Demo.txt");
            file.Write("");
            file.WriteLine("Your Name :" + NameTextbox.Text);
            file.WriteLine("Your Gender :" + GenderTextbox.Text);
            file.WriteLine("Your Age :" + AgeTextbox.Text);
            file.WriteLine("Your Address :" + AddressTextbox.Text);
            file.WriteLine("Date today :" + DateTextbox.Text);
            file.WriteLine("Temperature :" + TemperatureTextbox.Text);
            file.WriteLine("Mother's Name :" + MotherTextbox.Text);
            file.WriteLine("Mother's Occupation :" + MotherOccupationTextbox.Text);
            file.WriteLine("Father's Name :" + FatherTextbox.Text);
            file.WriteLine("Father's Occupation :" + FatherOccupationTextbox.Text);
            file.Close();
        }
        private void Readyear2022()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Ej Quinones\Desktop\TRACING - APP DEMO\2022\Contact Tracing Demo.txt");
            Responded.Text = sr.ReadToEnd();
        }
        private void Readyear2023()
        {    
            StreamReader sr = new StreamReader(@"C:\Users\Ej Quinones\Desktop\2023\TRACING - APP DEMO\2023\Contact Tracing Demo.txt");
            Responded.Text = sr.ReadToEnd();
        }
    }
} 

    
