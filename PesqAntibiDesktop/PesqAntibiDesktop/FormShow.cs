
using System.Windows.Forms;

namespace PesqAntibiDesktop
{
    
    public abstract class FormShow
    {
        public static void forceShowform(Form form, bool maximize=true)
        {
            // Weird trick so the form is always shown on top of the other windows
            form.WindowState = FormWindowState.Minimized;
            form.Show();
            if (maximize) form.WindowState = FormWindowState.Maximized;
            else form.WindowState = FormWindowState.Normal;
        }

    }
}
