using System.Collections.ObjectModel;

namespace LILO_Packager.v2.Core.Dialogs.Secured
{
    public class SecuredDialogCallBack
    {
        public DialogClosingReason DialogClosingReason { get; set; }
        public ObservableCollection<string> DynamicCallbackValues { get; set;}
    }
}
