namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookToSearchFor = userInput_searchBook.Text;

            foreach (string item in listBox_allBooks.Items)
            {
                if(bookToSearchFor == item)
                {
                    MessageBox.Show(item.ToString());
                }
                else
                {
                    MessageBox.Show("Book not found");
                }
            }
        }
    }
}
