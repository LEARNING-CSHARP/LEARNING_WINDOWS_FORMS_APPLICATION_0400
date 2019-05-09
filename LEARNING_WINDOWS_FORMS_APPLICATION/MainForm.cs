namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void F1()
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}

		private void F2(object sender)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}

		private void F3(System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}

		private void F4(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}
	}
}
