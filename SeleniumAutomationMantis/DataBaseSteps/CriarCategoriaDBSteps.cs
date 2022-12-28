using SeleniumAutomationMantis.Helpers;
using SeleniumAutomationMantis.Queries;
using System.IO;

namespace SeleniumAutomationMantis.DataBaseSteps
{
    public class CriarCategoriaDBSteps
    {
        public static void CriarCategoria()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/GerenciarQueries/CriarCategoria.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
    }
} 