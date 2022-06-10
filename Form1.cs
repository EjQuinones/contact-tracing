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
            StreamWriter file = new StreamWriter(@"C:\Users\Ej Quinones\Desktop\TRACING - APP DEMO\Contact Tracing Demo.txt");
            
                file.Write("");
                file.WriteLine("Your Name :" + NameTextbox.Text);
                file.WriteLine("Your Gender :" + GenderTextbox.Text);
                file.WriteLine("Your Age :" + AgeTextbox.Text);
                file.WriteLine("Your Address :" + AddressTextbox.Text);
                file.WriteLine("Date today :" + DateTextbox.Text);
                file.Close(); 
        }
    }
}
    
