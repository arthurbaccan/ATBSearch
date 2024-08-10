using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public abstract class InternetConnectionChecker
    {
        public static bool wasThereConnection = false;

        public static bool isInternetConnected(int timeoutMs = 500, string url = "http://www.gstatic.com/generate_204")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMilliseconds(timeoutMs);
                    var task = client.GetAsync(url);
                    task.Wait(); // Block until the task completes

                    using (var response = task.Result)
                    {
                        wasThereConnection = response.IsSuccessStatusCode;
                        return response.IsSuccessStatusCode;
                    }
                }
            }
            catch
            {
                wasThereConnection = false;
                return false;
            }
        }
    }
}
