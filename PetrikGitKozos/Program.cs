using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrikGitKozos
{
    class Program
    {
        static void Main(string[] args)
        {
            Color szin = Color.Aqua;
            string szoveg = "Meglepetés!";

            Form1 f = new Form1(szin, szoveg);
            System.Windows.Forms.Application.Run(f);
        }
    }
}
