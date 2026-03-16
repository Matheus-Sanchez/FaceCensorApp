namespace FaceCensorApp.WinForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        System.Windows.Forms.ApplicationConfiguration.Initialize();
        System.Windows.Forms.Application.Run(new Form1());
    }
}
