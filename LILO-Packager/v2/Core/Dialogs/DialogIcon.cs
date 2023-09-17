namespace LILO_Packager.v2.Core.Dialogs
{
    public class DialogIconHandler
    {
        private static Dictionary<DialogIcon,Bitmap> _icons = new Dictionary<DialogIcon, Bitmap>() 
        {
            {DialogIcon.Risk, DialogResources.risk_small },
            {DialogIcon.Information, DialogResources.info_small },
            {DialogIcon.Error, DialogResources.error_small },
            {DialogIcon.Question, DialogResources.help_small },
        };

        public static Bitmap GetDialogIcon(DialogIcon icon)
        {
            return _icons[icon];
        }
    }

    public enum DialogIcon
    {
        Error,
        Information,
        Risk,
        Question,
    }
}
