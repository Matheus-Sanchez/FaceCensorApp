namespace FaceCensorApp.WinForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        global::System.Windows.Forms.Application.EnableVisualStyles();
        global::System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
        global::System.Windows.Forms.Application.Run(new MainForm());
    }
}