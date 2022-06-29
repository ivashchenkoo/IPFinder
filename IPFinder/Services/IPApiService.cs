using IPFinder.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace IPFinder.Services
{
    public class IPApiService
    {
        public static IPConfig GetIPConfig(string ip = "127.0.0.1")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://ip-api.com/json/{ip}");

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                IPConfig iPConfig = JsonConvert.DeserializeObject<IPConfig>(reader.ReadToEnd());
                if (iPConfig.Status == "success")
                {
                    return iPConfig;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
