/****************************************************************************\

 Projekt : MBLittleProfessor
 Sprache : C#
 Compiler: MS Visual Studio 2008
 Autor   : Manfred Becker
 E-Mail  : mani.becker@web.de
 Url     : https://github.com/ManiBecker/MBLittleProfessor
 Modul   : Program.cs
 Version : 1.00
 Datum   : 28.04.2023

\****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MBLittleProfessor
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
