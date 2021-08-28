using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersionUpdater.Net.Helpers;
using VersionUpdater.Net.Helpers.Enums;

namespace VersionUpdater.Net.Sample
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            await Updater.ApplyVersionUpdaterAsync(p =>
            {
                p.GithubAuthenticationType = GithubAuthenticationType.Anonymous;
                p.Owner = "EmreSeverr";
                p.RepositoryName = "VersionUpdater.Net.Sample";
            }).ConfigureAwait(false);
            Application.Run(new FormVersion());
        }
    }
}
