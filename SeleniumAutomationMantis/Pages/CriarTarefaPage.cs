using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;
using System;

namespace SeleniumAutomationMantis.Pages
{
    public class CriarTarefaPage : PageBase
    {
        #region Mapping
        By categoriaComboBox = By.Id("category_id");
        By frequenciaCombobox = By.Id("reproducibility");
        By gravidadeCombobox = By.Id("severity");
        By prioridadeCombobox = By.Id("priority");
        By atribuirACombobox = By.Id("handler_id");
        By resumoTextField = By.Id("summary");
        By descricaoTextField = By.Id("description");
        By passosParaReproduzirTextField = By.Id("steps_to_reproduce");
        By informacoesAdicionaisTextField = By.Id("additional_info");
        By criarNovaTarefaButton = By.XPath("//input[@class='btn btn-primary btn-white btn-round']");
        By operacaoRealizadaComSucesso = By.XPath("//p[@class='bold bigger-110']");
        By selecionarProjetoButton = By.XPath("//input[@type='submit']");
        By selecionarPublicoRadio = By.XPath("//span[text()='público']");
        By selecionarPrivadoRadio = By.XPath("//span[text()='privado']");
        
        #endregion

        #region Actions
        public void SelecionarCategoria(String categoria)
        {
            ComboBoxSelectByVisibleText(categoriaComboBox, categoria);
        }

        public void SelecionarFrequencia(String frequencia)
        {
            ComboBoxSelectByVisibleText(frequenciaCombobox, frequencia);
        }

        public void SelecionarGravidade(String gravidade)
        {
            ComboBoxSelectByVisibleText(gravidadeCombobox, gravidade);
        }

        public void SelecionarPrioridade(String prioridade)
        {
            ComboBoxSelectByVisibleText(prioridadeCombobox, prioridade);
        }

        public void SelecionarAtribuirA(String atribuirA)
        {
            ComboBoxSelectByVisibleText(atribuirACombobox, atribuirA);
        }

        public void PreencherResumo(String resumo)
        {
            SendKeys(resumoTextField, resumo);
        }

        public void PreencherDescricao(String descricao)
        {
            SendKeys(descricaoTextField, descricao);
        }

        public void PreencherPassosParaReproduzir(String passosParaReproduzir)
        {
            SendKeys(passosParaReproduzirTextField, passosParaReproduzir);
        }

        public void PreencherInformacoesAdicionais(String informacoesAdicionais)
        {
            SendKeys(informacoesAdicionaisTextField, informacoesAdicionais);
        }

        public void ClicarEmCriarNovaTarefa()
        {
            Click(criarNovaTarefaButton);
        }

        public string PegarTextoOperacaoRealizadaComSucesso()
        {
            return GetText(operacaoRealizadaComSucesso);
        }

        public void ClicarEmSelecionarProjeto()
        {
            Click(selecionarProjetoButton);
        }

        public void SelecionarVisibilidade(String visibilidade)
        {
            if(visibilidade == "publico")
            {
                Click(selecionarPublicoRadio);
            }
            if(visibilidade == "privado")
            {
                Click(selecionarPrivadoRadio);
            }
        }

        #endregion
    }
}
 