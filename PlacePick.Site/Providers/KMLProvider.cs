using PlacePick.Site.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PlacePick.Site.Providers
{
    public static class KMLProvider
    {
        public static string GenerateKML(List<PolylinePoints> polylinePoints)
        {
            string guid = Guid.NewGuid().ToString();

            string KML = @"<?xml version='1.0' encoding='UTF-8'?>
                            <kml xmlns='http://earth.google.com/kml/2.1'>
                              <Document>
                                <Style id='blueLine'>
                                  <LineStyle>
                                    <color>ffff0000</color>
                                    <width>4</width>
                                  </LineStyle>
                                </Style>
                                <Placemark>
                                  <name>Blue Line</name>
                                  <styleUrl>#blueLine</styleUrl>
                                  <LineString>
                                    <altitudeMode>relative</altitudeMode>
                                    <coordinates>
                          ";

            foreach (var point in polylinePoints)
            {
                KML += point.longitude.ToString().Replace(',', '.') + "," + point.latitude.ToString().Replace(',', '.') + ",0\n";
            }


            KML += @"       </coordinates>
                          </LineString>
                        </Placemark>
                      </Document>
                    </kml>
                    ";

            System.IO.File.WriteAllText(@"D:\KML\"+ guid +".kml", KML);
            SendKML(guid);

            return guid;

        }

        public static void SendKML(string guid)
        {
            try
            {
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    client.Credentials = new System.Net.NetworkCredential("admin@zacne.c0.pl", "zacne.123");
                    client.UploadFile("ftp://zacne.c0.pl/" + "/" + new FileInfo(@"D:\KML\" + guid + ".kml").Name, "STOR", @"D:\KML\" + guid + ".kml");
                }
            }

            catch (Exception ex)
            {
                string xxx = ex.Message;
            }
        }
    }
}