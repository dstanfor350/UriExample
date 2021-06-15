// Uri Class
// https://docs.microsoft.com/en-us/dotnet/api/system.LoginAPI?view=net-5.0

// prod/api/account/login
// api/order/status
// api/orderItem/status
// api/payment
// machine/status




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UriParseLib;

namespace UriParse
{
    enum RESTFields { CATEGORY=1, FUNCTION=2, FUNCTIONTYPE=3 };
    enum Functions { };
    enum FunctionTypes { };

    class Program
    {
        static void Main(string[] args)
        {
            Uri LoginAPI = new Uri("http://www.jukka.com/prod/api/account/login");
            Uri OrderStatusAPI = new Uri("http://www.jukka.com/api/order/status");
            Uri OrderItemStatusAPI = new Uri("http://www.jukka.com/api/orderItem/status");
            Uri PaymentAPI = new Uri("http://www.jukka.com/api/payment");
            Uri MachineStatusAPI = new Uri("http://www.jukka.com/machine/status");

            Console.WriteLine($"AbsolutePath: {LoginAPI.AbsolutePath}");
            Console.WriteLine($"AbsoluteUri: {LoginAPI.AbsoluteUri}");
            Console.WriteLine($"DnsSafeHost: {LoginAPI.DnsSafeHost}");
            Console.WriteLine($"Fragment: {LoginAPI.Fragment}");
            Console.WriteLine($"Host: {LoginAPI.Host}");
            Console.WriteLine($"HostNameType: {LoginAPI.HostNameType}");
            Console.WriteLine($"IdnHost: {LoginAPI.IdnHost}");
            Console.WriteLine($"IsAbsoluteUri: {LoginAPI.IsAbsoluteUri}");
            Console.WriteLine($"IsDefaultPort: {LoginAPI.IsDefaultPort}");
            Console.WriteLine($"IsFile: {LoginAPI.IsFile}");
            Console.WriteLine($"IsLoopback: {LoginAPI.IsLoopback}");
            Console.WriteLine($"IsUnc: {LoginAPI.IsUnc}");
            Console.WriteLine($"LocalPath: {LoginAPI.LocalPath}");
            Console.WriteLine($"OriginalString: {LoginAPI.OriginalString}");
            Console.WriteLine($"PathAndQuery: {LoginAPI.PathAndQuery}");
            Console.WriteLine($"Port: {LoginAPI.Port}");
            Console.WriteLine($"Query: {LoginAPI.Query}");
            Console.WriteLine($"Scheme: {LoginAPI.Scheme}");
            Console.WriteLine($"Segments: {string.Join(", ", LoginAPI.Segments)}");
            Console.WriteLine($"UserEscaped: {LoginAPI.UserEscaped}");
            Console.WriteLine($"UserInfo: {LoginAPI.UserInfo}");

            List<string> sa = new List<string>();
            foreach (var s in LoginAPI.Segments)
                sa.Add(s.Trim('/'));

            Console.WriteLine("\nElements");
            Console.WriteLine(string.Join(" ",sa));

            UriParseLib.APIPaySystem.APIPayLoad LoginPayLoad = new UriParseLib.APIPaySystem.APIPayLoad(LoginAPI);
            Console.WriteLine($"Segment 0 of LoginPayload: {LoginPayLoad.GetPathSegments()[0]}");
            Console.WriteLine($"LoginLocalPath: { LoginPayLoad.GetLocalPath() }");
        }
    }
}
