using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.IO;

namespace SeleniumAutomationMantis.Helpers
{
    public class DataDrivenHelpers
    {
       public static List<TestCaseData> ReturnDadosPerfisGlobais_CSV
        {
            get
            {
                var testCases = new List<TestCaseData>();
        
                using (var fs = File.OpenRead(GeneralHelpers.GetProjectPath() + @"\DataDriven\planilhaPerfisGlobais.csv"))
                using (var sr = new StreamReader(fs))
                {
                    string headerLine = sr.ReadLine();

                    string line = string.Empty;
                    while (line != null)
                    {
                        line = sr.ReadLine();

                        if (line != null)
                        {
                            string[] split = line.Split(new char[] { ',' },
                                StringSplitOptions.None);
        
                            string param1 = Convert.ToString(split[0]); //plataforma
                            string param2 = Convert.ToString(split[1]); //so
                            string param3 = Convert.ToString(split[2]); //versaoSO
                            string param4 = Convert.ToString(split[3]); //descricao
        
                            var testCase = new TestCaseData(param1, param2, param3, param4);
                            testCases.Add(testCase);
                        }
                    }
                }
        
                return testCases;
            }
        }
    }
}
