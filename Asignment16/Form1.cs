using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Asignment16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, System.EventArgs e)
        {
            Regex regName = new Regex("^[a-z]*$");
            Regex regAge= new Regex("^\\d\\d$");
            Regex regPhone= new Regex("^\\d{11}$");
            string name = TXTName.Text.Trim();
            string age= TXTAge.Text.Trim();
            string phone= TXTPhone.Text.Trim();
            if (regName.IsMatch(name)&&regAge.IsMatch(age)&&regPhone.IsMatch(phone))
            {
                MessageBox.Show("Welcome "+name+", your age is: "+age+", and your phone is: "+phone);
            }
        }
    }
}
g