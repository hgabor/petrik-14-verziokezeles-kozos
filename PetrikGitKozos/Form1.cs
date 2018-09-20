using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrikGitKozos
{
    public partial class Form1 : Form
    {
        public Form1(Color hoverColor, string popupText)
        {
            InitializeComponent();

            var originalColor = clickMeButton.BackColor;
            clickMeButton.MouseEnter += (sender, args) => {
                clickMeButton.BackColor = hoverColor;
            };
            clickMeButton.MouseLeave += (sender, args) =>
            {
                clickMeButton.BackColor = originalColor;
            };

            clickMeButton.Click += (sender, args) =>
            {
                MessageBox.Show(popupText);
            };
        }
    }
}
