using SeleniumAutomationMantis.Helpers;
using System.IO;

namespace SeleniumAutomationMantis.DataBaseSteps
{
    public class CriarCampoPersonalizadoDBSteps
    {
        public static void CriarCampoPersonalizado()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/GerenciarQueries/CriarCampoPersonalizado.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
    }
} 