namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void f1()
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}

		private void f2(object sender)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}

		private void f3(System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}

		private void f4(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}
	}
}
