using SeleniumAutomationMantis.Helpers;
using NUnit.Framework;

using SeleniumAutomationMantis.DataBaseSteps;

namespace SeleniumAutomationMantis.Bases
{
    public class TestBase
    {
        [SetUp]
        public void Setup()
        {
            ExtentReportHelpers.AddTest();
            DriverFactory.CreateInstance();
            DriverFactory.INSTANCE.Navigate().GoToUrl(BuilderJson.ReturnParameterAppSettings("DEFAULT_APPLICATION_URL"));
           
            LimparDadosBancoDBSteps.LimparDadosBD();

            CriarProjetoDBSteps.CriarProjeto();
            CriarCampoPersonalizadoDBSteps.CriarCampoPersonalizado();
            CriarMarcadorDBSteps.CriarMarcador();
            CriarCategoriaDBSteps.CriarCategoria();
            CriarTarefaDBSteps.CriarTarefa();
            CriarAnotacaoDBSteps.CriarAnotacao();   
            CriarUsuarioDBSteps.CriarUsuario();         
        }

        [TearDown]
        public void TearDown()
        {
            ExtentReportHelpers.AddTestResult();
            DriverFactory.QuitInstace();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ExtentReportHelpers.CreateReport();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ExtentReportHelpers.GenerateReport();
        }
    }
}
