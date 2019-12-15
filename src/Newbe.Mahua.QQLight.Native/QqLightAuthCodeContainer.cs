using System;
using System.IO;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua.QQLight.Native
{
    internal class QqLightAuthCodeContainer : IQqLightAuthCodeContainer
    {
        private static readonly ILog Logger = LogProvider.For<QqLightAuthCodeContainer>();

        public int AuthCode { get; set; }

        private static readonly string TempFileName =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "qqlightcode.txt");

        public void Save()
        {
            File.WriteAllText(TempFileName, AuthCode.ToString());
        }

        public void Load()
        {
            if (File.Exists(TempFileName))
            {
                var content = File.ReadAllText(TempFileName);
                if (int.TryParse(content, out var authCode))
                {
                    AuthCode = authCode;
                }
                else
                {
                    Logger.Error("error on reading auth code from file");
                }

                File.Delete(TempFileName);
            }
        }
    }
}