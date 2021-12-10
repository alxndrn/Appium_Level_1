using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace Appium_Level_1_Tasks_6_10.Pages
{
    public class DragAndDropPage : BasePage
    {
        public DragAndDropPage(AndroidDriver<AndroidElement> driver) : base(driver)
        {
        }

        private AndroidElement DragDot => _driver.FindElementById("io.appium.android.apis:id/drag_dot_3");
        private AndroidElement DropDot => _driver.FindElementById("io.appium.android.apis:id/drag_dot_2");

        public void performDragAndDrop()
        {
            TouchAction action = new TouchAction(_driver);

            action.LongPress(DragDot).MoveTo(DropDot).Release().Perform();
        }
    }
}
