using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlaUI.UIA2;
using FlaUI.UIA3;
using FlaUI.Core;

namespace FlaUI_NotebookApp
{
    [TestClass]
    public class SetupMethods
    {
        [TestMethod]
        public void LunchNoteApp()
        {
            var msApplication = Application.Launch(@"C:\Windows\System32\notepad.exe");
            var automation = new UIA3Automation();
            var mainWindow = msApplication.GetMainWindow(automation);
        }
    }
}
