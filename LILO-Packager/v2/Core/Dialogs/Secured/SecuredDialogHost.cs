namespace LILO_Packager.v2.Core.Dialogs.Secured
{
    public class SecuredDialogHost
    {
        private readonly SecuredDialogUsecase _usecase;

        public SecuredDialogCallBack Show()
        {
            SecuredDialogCallBack callBack = new SecuredDialogCallBack();
            var conf = SecuredDialogUseCaseHandler.GetPreferences(_usecase);
            conf.Callback += call =>
            {
                callBack = call;
            };

            var mainUi = new Forms.uiSecureInputHandler(conf);
            mainUi.ShowDialog();

            return callBack;
        }

        public SecuredDialogHost(SecuredDialogUsecase use)
        {
            _usecase = use;
        }   
    }
}
