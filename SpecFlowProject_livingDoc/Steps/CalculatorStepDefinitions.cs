using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowProject_livingDoc.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

        }

        [Given(@"I enter following numbers")]
        public void GivenIEnterFollowingNumbers(Table table)
        {

        }


        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            Assert.Fail("Trying to fail forcibily !!");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic


        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic


        }

        [Given(@"I open the application")]
        public void GivenIOpenTheApplication()
        {
            
        }

        [Given(@"I set all the environment settings")]
        public void GivenISetAllTheEnvironmentSettings()
        {
           
        }

        [Given(@"the setting includes")]
        public void GivenTheSettingIncludes(Table table)
        {
           // dynamic data = table.CreateDynamicInstance();
        }

    }
}
