using System;
using System.IO;
using BakeryApplication.Constants;

namespace BakeryApplication.Helpers
{
    public static class DbHelper
    {
        public static string GetDatabasePath() => GetDatabaseDirectory() + $"/{DbConstants.DatabaseName}";
        public static string GetDatabaseDirectory() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"/{DbConstants.DatabaseDirectory}";
    }
}
