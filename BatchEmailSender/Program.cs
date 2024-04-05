using BatchEmailSender.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;

namespace BatchEmailSender;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<MainForm>());

    }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => {
                services.AddTransient<MainForm>();
            });
    }
}