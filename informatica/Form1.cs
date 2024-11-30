namespace informatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("hello world");
        }

        public void contatore()
        { }
private void button1_Click(object sender, EventArgs e)
        {
            cassa1 = new Thread(contatore);

            for(int i=0; i<100;  i++)
            {

            }
        }
    }
}