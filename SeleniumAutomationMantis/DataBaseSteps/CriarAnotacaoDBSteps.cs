using SeleniumAutomationMantis.Helpers;
using System.IO;

namespace SeleniumAutomationMantis.DataBaseSteps
{
    public class CriarAnotacaoDBSteps
    {
        public static void CriarAnotacao()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/TarefaQueries/CriarAnotacao.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
    }
} 