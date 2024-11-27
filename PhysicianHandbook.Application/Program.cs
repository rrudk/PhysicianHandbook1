using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhysicianHandbook.Application.Services;
using PhysicianHandbook.Application.Views;
using PhysicianHandbook.Application.Presenters;
using PhysicianHandbook.Application.Services.Interfaces;
using PhysicianHandbook.Application.Views.Interfaces;

namespace PhysicianHandbook.Application;

public static class Program
{
    [STAThread]
    private static void Main()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var services = new ServiceCollection();
        ConfigureServices(services, configuration);

        using (var serviceProvider = services.BuildServiceProvider())
        {
            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            System.Windows.Forms.Application.Run(mainForm);
        }
    }

    private static void ConfigureServices(ServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IConfiguration>(configuration);
        services.AddSingleton<IDataService, DataService>();
        services.AddSingleton<IDiseaseView, DiseaseView>();
        services.AddSingleton<IMedicationView, MedicationView>();
        services.AddSingleton<IPrescriptionView, PrescriptionView>();
        services.AddSingleton<MainForm>();

        services.AddSingleton<MedicationPresenter>();
        services.AddSingleton<DiseasePresenter>();
        services.AddSingleton<PrescriptionPresenter>();
    }

}