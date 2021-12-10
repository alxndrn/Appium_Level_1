/*
 * 1. In the already created test project add a new test launching the
 * Android demo app. Open directly Controls view. Click on the 1. Light
 * Theme button.
 * 2. Create a separate test performing an action against all the different
 * controls.
 * 3. Create a Page Object Model for this particular view.
 * 4. Open the Drag and Drop view and create a test for drag and drop
 * operation.
 * 5. Create one more test rotating the device horizontally and turn off the
 * WiFi.
 */

using Appium_Level_1_Tasks_6_10.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Options;
using System;
using System.IO;

namespace Appium_Level_1_Tasks_6_10.Tests
{
    [TestClass]
    public class AppiumTests
    {
        private static AndroidDriver<AndroidElement> _driver;
        private static AppiumLocalService _appiumLocalService;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            var args = new OptionCollector().AddArguments(GeneralOptionList.PreLaunch());
            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            _appiumLocalService.Start();
            string testAppPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "ApiDemos-debug.apk");
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "android25-test");
            appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "io.appium.android.apis");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "7.1");
            appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, ".ApiDemos");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, testAppPath);

            _driver = new AndroidDriver<AndroidElement>(_appiumLocalService, appiumOptions);
            _driver.CloseApp();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            if (_driver != null)
            {
                _driver.LaunchApp();
                _driver.StartActivity("io.appium.android.apis", ".ApiDemos");
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (_driver != null)
            {
                _driver.CloseApp();
            }
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _appiumLocalService.Dispose();
        }
        [TestMethod]
        public void OpenLightThemePage()
        {
            HomePage homePage = new HomePage(_driver);
            ViewsPage viewsPage = new ViewsPage(_driver);
            ControlsPage controlsPage = new ControlsPage(_driver);
            LightThemePage lightThemePage = new LightThemePage(_driver);

            homePage.clickViewsButton();
            viewsPage.clickControlsButton();
            controlsPage.clickLightThemeButton();

            _driver.HideKeyboard();

            Assert.IsTrue(lightThemePage.isSaveButtonEnabled());
        }

        [TestMethod]
        public void PerformActionsAgainstAllControls()
        {
            HomePage homePage = new HomePage(_driver);
            ViewsPage viewsPage = new ViewsPage(_driver);
            ControlsPage controlsPage = new ControlsPage(_driver);
            LightThemePage lightThemePage = new LightThemePage(_driver);

            homePage.clickViewsButton();
            viewsPage.clickControlsButton();
            controlsPage.clickLightThemeButton();

            _driver.HideKeyboard();

            Assert.IsTrue(lightThemePage.isSaveButtonEnabled());

            lightThemePage.clickSaveButton();
            lightThemePage.enterTextInInput("Alexandrina");
            lightThemePage.selectFirstCheckbox();
            lightThemePage.selectFirstRadioButton();
            lightThemePage.selectStarElement();
            lightThemePage.toggleFirstElement();
            lightThemePage.selectFromDropdown();
        }

        [TestMethod]
        public void PerformDragAndDrop()
        {
            HomePage homePage = new HomePage(_driver);
            ViewsPage viewsPage = new ViewsPage(_driver);
            DragAndDropPage dragAndDropPage = new DragAndDropPage(_driver);

            homePage.clickViewsButton();
            viewsPage.clickDragAndDropButton();

            dragAndDropPage.performDragAndDrop();
        }

        [TestMethod]
        public void RotateDeviceHorizontallyAndToggleWiFi()
        {
            var rotatable = (IRotatable)_driver;
            rotatable.Orientation = ScreenOrientation.Landscape;

            _driver.ToggleWifi();
        }
    }
}
