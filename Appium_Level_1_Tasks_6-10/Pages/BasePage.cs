using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appium_Level_1_Tasks_6_10.Pages
{
    public class BasePage
    {
        protected AndroidDriver<AndroidElement> _driver;

        public BasePage(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver ?? throw new ArgumentNullException("Driver cannot be null.");
        }
    }
}
