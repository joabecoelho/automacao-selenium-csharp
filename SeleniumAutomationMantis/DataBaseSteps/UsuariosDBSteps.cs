using SeleniumAutomationMantis.Helpers;
using SeleniumAutomationMantis.Queries;

namespace SeleniumAutomationMantis.DataBaseSteps
{
    public class UsuariosDBSteps
    {
        public static string RetornaSenhaDoUsuario(string username)
        {
            string query = UsuariosQueries.RetornaSenhaUsuario.Replace("$username", username);

            return DataBaseHelpers.RetornaDadosQuery(query)[0];
        }
    }
}
