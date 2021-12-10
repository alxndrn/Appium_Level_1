using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Appium_Level_1_Tasks_6_10.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(AndroidDriver<AndroidElement> driver) : base(driver)
        {
        }

        private By byScrollLocator = new ByAndroidUIAutomator("new UiSelector().text(\"Views\");");
        private AndroidElement ViewsButton => _driver.FindElement(byScrollLocator);
        public void clickViewsButton()
        {            
            ViewsButton.Click();
        }
    }
}
