using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCalc
{
    static class Program
    {
        /// <summary>
        /// This program is an AP Calculator for the game Mabinogi.
        /// 
        /// It takes the skill ratings from the form and calculates
        /// how much Ability Points (AP) are expended for each skill
        /// category.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
