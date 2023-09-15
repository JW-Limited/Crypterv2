namespace LILO_Packager.v2.Core.Dialogs
{
    public class DialogButtonHandler
    {
        private static Dictionary<DialogButtons,string> _buttons = new Dictionary<DialogButtons, string>() 
        {
            {DialogButtons.OkCancel, "Ok,Cancel" },
            {DialogButtons.SaveDelete, "Save,Delete" },
            {DialogButtons.Allow, "Allow,Denie" },
            {DialogButtons.Authorization, "Continue,Cancel" },
        };

        public static string[] GetSutttingText(DialogButtons buttons)
        {
            return _buttons[buttons].Split(",");
        }
    }

    public enum DialogButtons
    {
        OkCancel,
        SaveDelete,
        Allow,
        Authorization
    }
}
