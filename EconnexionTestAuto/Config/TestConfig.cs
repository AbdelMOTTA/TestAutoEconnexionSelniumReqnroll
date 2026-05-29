using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconnexionTestAuto.Config
{
    public static class TestConfig
    {
        public static string Username =>
            Environment.GetEnvironmentVariable("APP_USERNAME");

        public static string Password =>
            Environment.GetEnvironmentVariable("APP_PASSWORD");
    }
}
