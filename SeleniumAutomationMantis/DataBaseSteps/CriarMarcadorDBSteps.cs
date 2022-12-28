using SeleniumAutomationMantis.Helpers;
using System.IO;

namespace SeleniumAutomationMantis.DataBaseSteps
{
    public class CriarMarcadorDBSteps
    {
        public static void CriarMarcador()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/GerenciarQueries/CriarMarcador.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
    }
} 