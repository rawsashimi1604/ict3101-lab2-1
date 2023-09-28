using ICT3101_Lab2;
using ICT3101_Lab2_Specflow.Contexts;
using NUnit.Framework;

namespace ICT3101_Lab2_Specflow.Steps
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorStepDefinitions(CalculatorContext calculatorContext)
        {   
            _calculatorContext = calculatorContext;
        }
            
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {}
        
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculatorContext.Calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculatorContext.Calculator.Divide(p0, p1);
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }
    }
}