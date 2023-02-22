using AutoItX3Lib;

namespace Userinterface.Framework.Utils
{
    public static class AutoITUtils
    {
        public static void UploadFile(string page)
        {
            AutoItX3 auto = new AutoItX3();
            auto.WinWait("Открытие");
            auto.WinActivate("Открытие");
            auto.Send(Path.GetFullPath(page));
            auto.Send("{ENTER}");
        }
    }
}
