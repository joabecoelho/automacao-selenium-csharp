using SeleniumAutomationMantis.Helpers;
using System.IO;

namespace SeleniumAutomationMantis.DataBaseSteps
{
    public class CriarUsuarioDBSteps
    {
        public static void CriarUsuario()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/GerenciarQueries/CriarUsuario.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
    }
}