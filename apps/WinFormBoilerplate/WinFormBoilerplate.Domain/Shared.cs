using System.Configuration;

namespace WinFormBoilerplate.Domain
{
    public static class Shared
    {
        /// <summary>
        /// Fakeの時True
        /// </summary>
        public static bool IsFake { get; } = ConfigurationManager.AppSettings["IsFake"] == "1";
    }
}
