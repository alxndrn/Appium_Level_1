using OpenQA.Selenium.Appium.Android;

namespace Appium_Level_1_Tasks_6_10.Pages
{
    public class ViewsPage : BasePage
    {
        public ViewsPage(AndroidDriver<AndroidElement> driver) : base(driver)
        {
        }

        private AndroidElement ControlsViewButton => _driver.FindElementByXPath("//*[@text='Controls']");
        private AndroidElement DragAndDropViewButton => _driver.FindElementByXPath("//*[@text='Drag and Drop']");
        public void clickControlsButton()
        {
            ControlsViewButton.Click();
        }
        public void clickDragAndDropButton()
        {
            DragAndDropViewButton.Click();
        }
    }
}
