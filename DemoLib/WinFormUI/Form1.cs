using DemoLibrary;

namespace WinFormUI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e) { }

    private void label1_Click_1(object sender, EventArgs e) { }

    private void firstNameText_Click(object sender, EventArgs e) { }

    private void lastNameText_Click(object sender, EventArgs e) { }

    private void combineName_Click(object sender, EventArgs e)
    {
        string fullName = PersonProcessor.JoinName(firstNameText.Text, lastNameText.Text);
        string msg = $"Your full name is {fullName}";
        MessageBox.Show(msg);
    }
}
