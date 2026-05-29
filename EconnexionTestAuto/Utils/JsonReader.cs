using System;
using System.IO;
using System.Text.Json;

namespace EconnexionTestAuto.Utils
{
    public static class JsonTestDataReader
    {
        private static readonly string BasePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData");

        public static T Read<T>(string fileName)
        {
            var filePath = Path.Combine(BasePath, fileName);

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Test data file not found: {filePath}");

            var json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<T>(json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })!;
        }
    }

}
