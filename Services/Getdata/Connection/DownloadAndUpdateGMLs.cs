using GERMAG_local.Services.Getdata.DataCollect;
using GERMAG_local.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERMAG_local.Services.Getdata.Connection;

public interface IDownloadAndUpdateGMLs
{
    void UpdateDownloadGMLs();
}

public class DownloadAndUpdateGMLs : IDownloadAndUpdateGMLs
{
    private readonly IDownloadAndUpdateGMLsByUrl _downloadUpdateGmlsByUrl;

    public DownloadAndUpdateGMLs(IDownloadAndUpdateGMLsByUrl downloadUpdateGmlsByUrl)
    {
        _downloadUpdateGmlsByUrl = downloadUpdateGmlsByUrl;
    }

    public void UpdateDownloadGMLs()
    {
        // <- Add reference Database connection here
        // <- Feed all get request in noted in the database by a loop
        // for (int i = 0; i < x; i++) {}

        // Example URL
        var currentURL = "https://fbinter.stadt-berlin.de/fb/wfs/data/senstadt/s_poly_entzugspot2400_100?service=wfs&version=2.0.0&request=GetFeature&typeNames=fis:s_poly_entzugspot2400_100";

        var connectionFeedback = _downloadUpdateGmlsByUrl.UpdateGmlsByUrl(currentURL, GmlData.Entzugsleistung_100M_2400HP);

        Console.WriteLine(connectionFeedback);


    }
}

