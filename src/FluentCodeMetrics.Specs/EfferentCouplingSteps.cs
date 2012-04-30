using System;
using FluentCodeMetrics.Core;
using SharpTestsEx;
using TechTalk.SpecFlow;

namespace FluentCodeMetrics.Specs
{
    [Binding]
    public class EfferentCouplingSteps
    {
        // ReSharper disable InconsistentNaming
        private int resultingCe;
        private Type workingType;
        // ReSharper restore InconsistentNaming

        [Given(@"que tenho um (.*)")]
        public void DadoQueTenhoUm(string tipo)
        {
            workingType = Type.GetType(tipo);
            workingType.Should().Not.Be.Null();
        }

        [When(@"inspeciono seu acoplamento eferente")]
        public void QuandoInspecionoSeuAcoplamentoEferente()
        {
            resultingCe = workingType.ComputeCe();
        }

        [Then(@"obtenho (.*)")]
        public void EntaoObtenho(int ce)
        {
            resultingCe.Should().Be(ce);
        }
    }
}