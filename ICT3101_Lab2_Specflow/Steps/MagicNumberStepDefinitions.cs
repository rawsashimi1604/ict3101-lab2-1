using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Lab2_Specflow.Contexts;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Lab2_Specflow.Steps;

[Binding]
public sealed class MagicNumberStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly CalculatorContext _calculatorContext;
    private double _result;

    public MagicNumberStepDefinitions(CalculatorContext calculatorContext)
    {
        this._calculatorContext = calculatorContext;
    } 
    
    [Given("I have a a calculator")]
    public void GivenIHaveACalculator()
    {}
    
    [When(@"I have entered a postive number and press Magic Number")]
    public void WhenIHaveEnteredAPostiveNumberAndPressMagicNumber()
    {
        _result = _calculatorContext.Calculator.GenMagicNum(1);
    }

    [When(@"I have entered a negative number and press Magic Number")]
    public void WhenIHaveEnteredANegativeNumberAndPressMagicNumber()
    {
        _result = _calculatorContext.Calculator.GenMagicNum(-1);
    }
    
    [Then(@"the positive magic number result should be ""(.*)""")]
    public void ThenThePositiveMagicNumberResultShouldBe(string p0)
    {
        Assert.That(_result.Equals(10));
    }
    
    [Then(@"the negative magic number result should be ""(.*)""")]
    public void ThenTheNegativeMagicNumberResultShouldBe(string p0)
    {
        Assert.That(_result.Equals(-0));
    }
}