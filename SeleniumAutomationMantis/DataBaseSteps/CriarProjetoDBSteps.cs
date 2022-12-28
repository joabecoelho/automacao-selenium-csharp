using SeleniumAutomationMantis.Helpers;
using System.IO;

namespace SeleniumAutomationMantis.DataBaseSteps
{
    public class CriarProjetoDBSteps
    {
        public static void CriarProjeto()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/GerenciarQueries/CriarProjeto.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
    }
} 