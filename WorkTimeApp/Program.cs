using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartInfo());
        }
    }

    public static class FormCollection
    {
        private static List<Form> Forms = new List<Form>();

        public static Form GetOrSetForm<TForm>()
            where TForm : Form, new()
        {
            var cachedForm = Forms.FirstOrDefault(x => x.GetType() == typeof(TForm));

            if (cachedForm == null)
            {
                cachedForm = (Form)Activator.CreateInstance(typeof(TForm));
                Forms.Add(cachedForm);
                return cachedForm;
            }

            return cachedForm;
        }

    }
}
