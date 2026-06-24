using System.Windows.Forms;
using System.Drawing;

namespace MusicApplication
{
    public class MainForm : Form
    {
        private Label label1;
        private TextBox inputBox;
        private Button button;

        public MainForm()
        {
            label1 = new Label();
            label1.Text = "Hello World";
            label1.Location = new Point(20, 20);
            label1.AutoSize = true;

            inputBox = new TextBox();
            inputBox.Location = new Point(20, 60);

            button = new Button();
            button.Text = "Submit";
            button.Location = new Point(20, 100);

            button.Click += Button_Click;

            Controls.Add(label1);
            Controls.Add(inputBox);
            Controls.Add(button);
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            string command = inputBox.Text;

            if (command == "help")
            {
                label1.Text = "search, login, logout, play, view";
            }
            else
            {
                label1.Text = $"Unknown command: {command}";
            }
        }
    }
}