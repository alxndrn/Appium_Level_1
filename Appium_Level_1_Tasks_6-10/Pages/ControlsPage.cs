using OpenQA.Selenium.Appium.Android;

namespace Appium_Level_1_Tasks_6_10.Pages
{
    public class ControlsPage : BasePage
    {
        public ControlsPage(AndroidDriver<AndroidElement> driver) : base(driver)
        {
        }

        private AndroidElement LightThemeButton => _driver.FindElementByXPath("//*[@text='1. Light Theme']");
        public void clickLightThemeButton()
        {
            LightThemeButton.Click();
        }
    }
}
