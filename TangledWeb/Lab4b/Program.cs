
/*Purpose: Form that checks whether users inputed HTML code has balanced opening and closing tags
 * Date of submission :11/27/22
 * I, Jacob Robbins, 000371194 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 * For the user: Please use this application to parse and check if html tags are balanced on your webpage
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4b
{
    /// <summary>
    /// Class Program
    /// purpose: Controller for the Form app Form1
    /// </summary>
    internal static class Program
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
