using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Lab2;
using ICT3101_Lab2_Specflow.Contexts;
using Moq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Lab2_Specflow.Steps;

[Binding]
public sealed class MagicNumberStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly CalculatorContext _calculatorContext;
    private double _result;
    private Mock<IFileReader> _mockFileReader;

    public MagicNumberStepDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    } 
    
    [BeforeScenario]
    public void Setup()
    {
        _mockFileReader = new Mock<IFileReader>();
        _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[3]{"1","5", "10"});
    }
    
    [Given("I have a a calculator")]
    public void GivenIHaveACalculator()
    {}
    
    [When(@"I have entered a postive number and press Magic Number")]
    public void WhenIHaveEnteredAPostiveNumberAndPressMagicNumber()
    {
        _result = _calculatorContext.Calculator.GenMagicNum(1, _mockFileReader.Object);
    }

    [When(@"I have entered a negative number and press Magic Number")]
    public void WhenIHaveEnteredANegativeNumberAndPressMagicNumber()
    {
        _result = _calculatorContext.Calculator.GenMagicNum(-1, _mockFileReader.Object);
    }
    
    [Then(@"the positive magic number result should be ""(.*)""")]
    public void ThenThePositiveMagicNumberResultShouldBe(string p0)
    {
        Assert.AreEqual(10, _result);
    }
    
    [Then(@"the negative magic number result should be ""(.*)""")]
    public void ThenTheNegativeMagicNumberResultShouldBe(string p0)
    {
        Assert.AreEqual(0, _result);
    }
}