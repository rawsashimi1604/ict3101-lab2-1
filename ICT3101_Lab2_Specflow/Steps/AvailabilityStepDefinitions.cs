using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Lab2_Specflow.Contexts;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Lab2_Specflow.Steps;

[Binding]
public sealed class AvailabilityStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly CalculatorContext _calculatorContext;
    private double _result;

    public AvailabilityStepDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }

    [Given("I have a a calculator")]
    public void GivenIHaveACalculator()
    {}

    [When(@"I have entered \? and \? into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMtbf()
    {
        _result = _calculatorContext.Calculator.CalculateMBTF(1.0, 2.0);
    }
    
    [When(@"I have entered \? and \? into the calculator and press Availability")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability()
    {
        _result = _calculatorContext.Calculator.CalculateAvailability(6.0, 2.0);
    }

    [Then(@"the availability result should be ""(.*)""")]
    public void ThenTheAvailabilityResultShouldBe(string p0)
    {
        Assert.AreEqual(3.0, _result);
    }

    
}