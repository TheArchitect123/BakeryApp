
using BakeryApplication.Helpers;
using BakeryApplication.Services;
using BakeryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;

namespace BakeryApplication
{
    //A global bootstrapper class to manage the application
    //ViewModels, Services, Networking, and the Data Layer
    public class ApplicationManager
    {
        private TinyIoC.TinyIoCContainer _container;
        public ApplicationManager()
        {
            if(_container == null) //Initialize the iOC Container if it is null
            _container = new TinyIoC.TinyIoCContainer();
            RegisterViewModels();
            RegisterServices();

            //Start the Application
            bootApplication();
        }

        private void bootApplication()
        {
            var produceContainer = _container.Resolve<ProduceInputOutputViewModel>();
            produceContainer.ProcessRequest(Common.ProduceType.VegemiteScroll, 10); //Vegimite Scroll
            produceContainer.ProcessRequest(Common.ProduceType.BlueberryMuffin, 14); //Blueberry Muffin
            produceContainer.ProcessRequest(Common.ProduceType.Croissant, 13); //Croissant
        }

        #region Registration
        private void RegisterViewModels()
        {
            _container.Register<ProduceInputOutputViewModel>();
        }

        private void RegisterServices()
        {
            _container.Register<SqliteDataService>(new SqliteDataService(getSqliteConnection()));
        }

        private SQLite.SQLiteConnection getSqliteConnection() => new SQLite.SQLiteConnection(getDatabasePath());

        private string getDatabasePath()
        {
            string directoryPath = DbHelper.GetDatabaseDirectory();
            if (!Directory.Exists(directoryPath)) //Create the directory to store the sqlite database
                Directory.CreateDirectory(directoryPath);

            string databasePath = DbHelper.GetDatabasePath();
            if (!File.Exists(databasePath))
                File.Create(databasePath).Dispose();

            return databasePath;
        }

        #endregion
    }
}
