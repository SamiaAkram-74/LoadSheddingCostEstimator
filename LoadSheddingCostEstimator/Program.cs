using System;
using System.Windows.Forms;
using LoadSheddingCostEstimator.Forms;

namespace LoadSheddingCostEstimator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
