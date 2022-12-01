using SaveLibrary;

namespace FileSaver
{
    public partial class Form1 : Form
    {
        Class1 C = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ñîõğàíèòüÊàêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C.save(textBox.Text);
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = C.open();
        }
    }
}