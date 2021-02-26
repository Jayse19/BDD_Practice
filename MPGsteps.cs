using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ClassLibrary1;
using FluentAssertions;

namespace ClassProject1
{
    [Binding]
    public sealed class MPGsteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public MPGsteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Miles driven is (.*)")]
        public void GivenMilesDrivenIs(int p0)
        {
            _scenarioContext.Add("miles", p0);
        }

        [Given(@"Gallons used is (.*)")]
        public void GivenGallonsUsedIs(int p0)
        {
            _scenarioContext.Add("gallons",p0);
        }

        [When(@"calc_mpg is called")]
        public void WhenCalc_MpgIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("mpg", f.calc_mpg(_scenarioContext.Get<int>("miles"), _scenarioContext.Get<int>("gallons")));
        }
        [When(@"gasHog is called")]
        public void WhenGasHogIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("LotsOfGas", f.gasHog(_scenarioContext.Get<int>("miles"), _scenarioContext.Get<int>("gallons")));
            //ScenarioContext.Current.Pending();
        }


        [Then(@"the fuel efficieny should be (.*)")]
        public void ThenTheFuelEfficienyShouldBe(float p0)
        {
            var m = _scenarioContext.Get<float>("mpg");
            m.Should().Be(p0);
        }
        [Then(@"the car is a gas hog and should be (.*)")]
        public void ThenTheCarIsAGasHogAndShouldBe(Boolean p0)
        {
            var m = _scenarioContext.Get<Boolean>("LotsOfGas");
            m.Should().Be(p0);
        }
        [When(@"gasRewards is called")]
        public void WhenGasRewardsIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("rewards", f.gasPoints(_scenarioContext.Get<int>("miles"), _scenarioContext.Get<int>("gallons")));
        }

        [Then(@"the points given should be (.*)")]
        public void ThenThePointsGivenShouldBe(double p0)
        {
            var m = _scenarioContext.Get<double>("rewards");
            m.Should().Be(p0);
        }




    }
}
