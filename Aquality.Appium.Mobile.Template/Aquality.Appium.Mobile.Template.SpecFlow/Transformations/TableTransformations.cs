using Aquality.Appium.Mobile.Template.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Transformations
{
    [Binding]
    public class TableTransformations
    {
        [StepArgumentTransformation]
        public LoginModel TransformLoginModel(Table inputTable) => inputTable.CreateInstance<LoginModel>();
    }
}
