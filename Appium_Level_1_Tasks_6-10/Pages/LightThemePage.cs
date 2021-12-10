using OpenQA.Selenium.Appium.Android;

namespace Appium_Level_1_Tasks_6_10.Pages
{
    public class LightThemePage : BasePage
    {
        public LightThemePage(AndroidDriver<AndroidElement> driver) : base(driver)
        {
        }

        private AndroidElement SaveButton => _driver.FindElementByXPath("//*[@text='Save']");
        private AndroidElement TextInput => _driver.FindElementById("io.appium.android.apis:id/edit");
        private AndroidElement FirstCheckbox => _driver.FindElementById("io.appium.android.apis:id/check1");
        private AndroidElement FirstRadioButton => _driver.FindElementById("io.appium.android.apis:id/radio1");
        private AndroidElement StarElement => _driver.FindElementById("io.appium.android.apis:id/star");
        private AndroidElement FirstToggleElement => _driver.FindElementById("io.appium.android.apis:id/toggle1");
        private AndroidElement DropdownElement => _driver.FindElementById("io.appium.android.apis:id/spinner1");
        private AndroidElement DropdownEarthElement => _driver.FindElementById("android:id/text1");
        public bool isSaveButtonEnabled()
        {
            return SaveButton.Enabled;
        }
        public void clickSaveButton()
        {
            SaveButton.Click();
        }
        public void enterTextInInput(string text)
        {
            TextInput.Clear();
            TextInput.SetImmediateValue(text);
        }
        public void selectFirstCheckbox()
        {
            FirstCheckbox.Click();
        }
        public void selectFirstRadioButton()
        {
            FirstRadioButton.Click();
        }
        public void selectStarElement()
        {
            StarElement.Click();
        }
        public void toggleFirstElement()
        {
            FirstToggleElement.Click();
        }
        public void selectFromDropdown()
        {
            DropdownElement.Click();
            DropdownEarthElement.Click();
        }
    }
}
