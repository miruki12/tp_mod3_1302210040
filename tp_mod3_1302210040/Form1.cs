namespace tp_mod3_1302210040
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputName = name.Text.Trim();
            string inputNim = nim.Text.Trim();

            if (string.IsNullOrEmpty(inputName) || string.IsNullOrEmpty(inputNim))
            {
                MessageBox.Show("Please fill in both Name and NIM fields.");
                return;
            }

            output.Text = $"halo {inputName} {inputNim}";
        }



       
    }
}