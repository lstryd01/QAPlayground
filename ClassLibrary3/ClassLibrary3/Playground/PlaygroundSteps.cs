using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ClassLibrary3
{
    public class PlaygroundSteps
    {

        [When(@"I enter Red Shoes into the search bar")]
        public void WhenIEnterRedShoesIntoTheSearchBar()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click search")]
        public void WhenIClickSearch()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the results will include red shoes")]
        public void ThenTheResultsWillIncludeRedShoes()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
