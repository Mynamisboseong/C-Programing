using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyButton.Text = "코드에서 변경!";
            MyButton.Width = 100;
            int width = 100;
            int height = 20;
            int margin = 6;
            MyButton.Width = width;
            MyButton.Height = height;
            MyButton.Location = new Point(margin, margin);

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(margin, (height + margin) * (i + 1) + margin);
                button.Text = "동적 생성" + i + "번째";
                button.Width = width;
                button.Height = height;
            }

        }

        private void MyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
