using System;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public class MyForm : Form
    {
        public MyForm()
        {
            Text = "My First Form";
            Width = 800;
            Height = 600;

            var button = new Button();
            button.Text = "Click Me";
            button.Left = 50;
            button.Top = 50;

            button.Click += (sender, e) =>
            {
                MessageBox.Show("Hello!");
            };

            Controls.Add(button);
        }
    }
}