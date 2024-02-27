using System.Windows.Forms;

namespace roulett
{
    public partial class Form1 : Form
    {
        public string[] arrayOfVariats = 
        {
            "z",
            "r", "b", "r",
            "b", "r", "b",
            "r", "b", "r",
            "b", "b", "r",
            "b", "r", "b",
            "r", "b", "r",
            "r", "b", "r",
            "b", "r", "b",
            "r", "b", "r",
            "b", "b", "r",
            "b", "r", "b",
            "r", "b", "r",
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomRoll = rnd.Next(arrayOfVariats.Length);

            if (arrayOfVariats[randomRoll] == "r")
            {
                label1.Text = randomRoll + " - red";
                listBox1.Items.Add(randomRoll + " - red");
            }
            else if (arrayOfVariats[randomRoll] == "b")
            {
                label1.Text = randomRoll + " - black";
                listBox1.Items.Add(randomRoll + " - black");
            }
            else if (arrayOfVariats[randomRoll] == "z")
            {
                label1.Text = randomRoll + " - zero";
                listBox1.Items.Add(randomRoll + " - zero");
            }
            else
            {
                label1.Text = " error";
            }
        }
    }
}
