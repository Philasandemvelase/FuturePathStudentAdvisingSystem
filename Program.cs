using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem
{
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

            // Check the database once at start-up so setup problems show a clear message.
            // The app still opens if it fails, so UI work can continue without a database.
            string message;
            if (!DbConnectionFactory.TryTestConnection(out message))
            {
                MessageBox.Show(message, "Future Path - database not available",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            System.Diagnostics.Debug.WriteLine(message);

            Application.Run(new Presentation.frmMain());   // MDI parent: every screen opens inside it
        }
    }
}
