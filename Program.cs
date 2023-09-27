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



        //remoteFileExsists.RemoteFileExists("https://fbinter.stadt-berlin.de/fb/wfs/data/senstadt/s_poly_entzugspot2400_100?service=wfs&version=2.0.0&request=GetFeature&typeNames=fis:s_poly_entzugspot2400_100");

        //var xml = XDocument.Load("https://fbinter.stadt-berlin.de/fb/wfs/data/senstadt/s_poly_entzugspot2400_100?service=wfs&version=2.0.0&request=GetFeature&typeNames=fis:s_poly_entzugspot2400_100");

        //xml.Save("V:/Repos/GERMAG_local/GERMAG_local/Resources/testOutput.gml");

        //string directory = Directory.GetCurrentDirectory();



        //Console.WriteLine("Hello, World!");

    }





}