using SeleniumAutomationMantis.Helpers;
using System.IO;

namespace SeleniumAutomationMantis.DataBaseSteps
{
    public class LimparDadosBancoDBSteps
    {
        public static void LimparDadosBD()
        {
            MantisBugFileTable();
            MantisBugHistoryTable();
            MantisBugMonitorTable();
            MantisBugnoteTable();
            MantisBugnoteTextTable();
            MantisBugRelationshipTable();
            MantisBugRevisionTable();
            MantisBugTable();
            MantisBugTagTable();
            MantisBugTextTable();
            MantisCategoryTable();
            MantisCustomFieldTable();
            MantisEmailTable();
            MantisProjectTable();
            MantisTagTable();
            MantisUserProfileTable();
            MantisUserTable();
        }

        private static void MantisBugFileTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugFileTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisBugHistoryTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugHistoryTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisBugMonitorTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugMonitorTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
        private static void MantisBugnoteTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisCustomFieldTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisBugnoteTextTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugnoteTextTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisBugRelationshipTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugRelationshipTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisBugRevisionTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugRevisionTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
        private static void MantisBugTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisBugTagTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugTagTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisBugTextTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugTextTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisCategoryTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisCategoryTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
        private static void MantisCustomFieldTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisBugnoteTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisEmailTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisEmailTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisProjectTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisProjectTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisTagTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisTagTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisUserProfileTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisUserProfileTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void MantisUserTable()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/LimparDadosBanco/LimparMantisUserTable.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
    }
}