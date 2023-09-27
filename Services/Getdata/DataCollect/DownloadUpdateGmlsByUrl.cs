using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GERMAG_local.Services.Model;
using GERMAG_local.Services.Getdata.Connection;
using System.Xml.Linq;

namespace GERMAG_local.Services.Getdata.DataCollect;
public interface IDownloadAndUpdateGMLsByUrl
{
    bool UpdateGmlsByUrl(string url, GmlData type);

}

public class DownloadAndUpdateGMlsByUrl : IDownloadAndUpdateGMLsByUrl
{
    public bool UpdateGmlsByUrl(string url, GmlData type)
    {
        try
        {
            var xml = XDocument.Load(url);

            // <- Save downloaded Data in a Database here


            // For testing, before a DB is connected: Saving of the GML 
            string SavePath = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName + "\\Resources\\Test.gml";

            if (SavePath != null)
            {
                xml.Save(SavePath);
            }
            else
            {
                // Do Something
            }


            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }
}


