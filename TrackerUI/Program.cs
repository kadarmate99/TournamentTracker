using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TrackerLibrary.DataAccess;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            HostApplicationBuilder builder = Host.CreateApplicationBuilder();

            // Register data connections
            //builder.Services.AddSingleton<IDataConnection, SqlConnector>();
            builder.Services.AddSingleton<IDataConnection, TextConnector>();

            // Register forms
            builder.Services.AddTransient<CreatePrizeForm>();
            builder.Services.AddTransient<CreateTeamForm>();
            builder.Services.AddTransient<CreateTournamentForm>();
            builder.Services.AddTransient<TournamentDashboardForm>();
            builder.Services.AddTransient<TournamentViewerForm>();

            using IHost host = builder.Build();

            // Resolve the form with all dependencies wired up
            Application.Run(host.Services.GetRequiredService<CreateTournamentForm>());
        }
    }
}