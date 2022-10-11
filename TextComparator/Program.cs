/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                                 *
 *  Copyright:   (c) 2022, Aioanei A., Burechita C., Sprinceana R, Chirila *
 *  Description: Text Comparator                                          *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextComparator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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
