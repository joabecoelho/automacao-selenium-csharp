using SeleniumAutomationMantis.Helpers;
using System.IO;

namespace SeleniumAutomationMantis.DataBaseSteps
{
    public class CriarTarefaDBSteps
    {

        public static void CriarTarefa()
        {
            CriarTarefaBD();
            CriarDescricaoTarefa();
        }

        public static void CriarTarefaFechada()
        {
            CriarTarefaFechadaBD();
            CriarDescricaoTarefaFechada();
            CriarFechamentoTarefa();
        }

        

        public static void CriarTarefaBD()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/TarefaQueries/CriarTarefa.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void CriarDescricaoTarefaFechada()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/TarefaQueries/CriarDescricaoTarefaFechada.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void CriarTarefaFechadaBD()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/TarefaQueries/CriarTarefaFechada.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void CriarDescricaoTarefa()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/TarefaQueries/CriarDescricaoTarefa.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }

        private static void CriarFechamentoTarefa()
        {
            string query = File.ReadAllText(GeneralHelpers.GetProjectPath() + "Queries/TarefaQueries/CriarFechamentoTarefa.sql");

            DataBaseHelpers.ExecuteQuery(query);
        }
    }
}