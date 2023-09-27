using System.Net;
using System;
using System.Xml.Linq;
using System.Resources;
using Microsoft.Extensions.DependencyInjection;
using GERMAG_local.Services.Getdata.Connection;
using GERMAG_local.Services.Getdata.DataCollect;

namespace GERMAG;

internal static class Program
{
    [STAThread]
    private static void Main()
    {

        var services = new ServiceCollection();
        services.AddTransient<IDownloadAndUpdateGMLs, DownloadAndUpdateGMLs>();
        services.AddTransient<IDownloadAndUpdateGMLsByUrl, DownloadAndUpdateGMlsByUrl>();

        using var provider = services.BuildServiceProvider();
        var DownloadAndUpdateGMLs = provider.GetRequiredService<IDownloadAndUpdateGMLs>();

        DownloadAndUpdateGMLs.UpdateDownloadGMLs();
    }
}