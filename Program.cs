using System;
using System.Drawing;
using System.Windows.Forms;
//dlya git
namespace Forms
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form Form = new MyForm("Вопрос");
            Application.Run(Form);
        }

        public class MyForm : Form
        {
            public MyForm(string title)
            {
                Text = title;
                Height = 280;
                Width = 350;
                StartPosition = FormStartPosition.CenterScreen;


                Label label = CreateLabel(new Size(150, 30), new Point(130, 50), "Вы студент?");
                Button yesbutton = CreateButtonY(new Size(70, 50), new Point(80, 180), "Да");
                yesbutton.Click += (sender, e) => { MessageBox.Show("Принято"); Application.Exit(); };
                Button nobutton = CreateButtonN(new Size(70, 50), new Point(180, 180), "Нет");
                nobutton.Click += (sender, e) => { MessageBox.Show("До свидания"); Application.Exit(); };

            }
            private void SetCommonParameters(Control element, Size size, Point position, string title)
            {
                element.Size = size;
                element.Location = position;
                element.Text = title;
                Controls.Add(element);
            }
            private Button CreateButtonY( Size size, Point position, string title)
            {
                Button yesbutton = new Button();
                SetCommonParameters(yesbutton, size, position, title);
                return yesbutton;
            }
            private Button CreateButtonN( Size size, Point position, string title)
            {
                Button nobutton = new Button();
                SetCommonParameters(nobutton, size, position, title);
                return nobutton;
            }
            private Label CreateLabel(Size size, Point position, string title)
            {
                Label label = new Label();
                SetCommonParameters(label, size, position, title);
                return label;
            }

        } 
        }

    }