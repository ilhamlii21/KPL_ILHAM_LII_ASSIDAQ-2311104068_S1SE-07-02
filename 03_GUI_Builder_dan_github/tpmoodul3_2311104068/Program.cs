using System;
using System.Windows.Forms;

namespace GUIExample
{
    public class MainForm : Form
    {
        private TextBox inputBox;
        private Button submitButton;
        private Label outputLabel;

        public MainForm()
        {
            this.Text = "GUI TP MODUL 3";
            this.Size = new System.Drawing.Size(400, 200);
            this.BackColor = System.Drawing.Color.White;

            inputBox = new TextBox();
            inputBox.Location = new System.Drawing.Point(50, 30);
            inputBox.Size = new System.Drawing.Size(200, 30);
            this.Controls.Add(inputBox);

            submitButton = new Button();
            submitButton.Text = "Submit";
            submitButton.Location = new System.Drawing.Point(260, 30);
            submitButton.Click += new EventHandler(SubmitButton_Click);
            this.Controls.Add(submitButton);

            outputLabel = new Label();
            outputLabel.Text = "Output";
            outputLabel.Location = new System.Drawing.Point(50, 80);
            outputLabel.Size = new System.Drawing.Size(300, 30);
            outputLabel.BackColor = System.Drawing.Color.AliceBlue;
            outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(outputLabel);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string inputText = inputBox.Text;
            outputLabel.Text = "Halo Selamat datang hoy " + inputText;
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
