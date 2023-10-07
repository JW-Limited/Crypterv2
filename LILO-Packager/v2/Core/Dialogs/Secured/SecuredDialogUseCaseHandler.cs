using LILO_Packager.v2.Shared.Api.Core;
using LILO_Packager.v2.Shared.Api.Types;

namespace LILO_Packager.v2.Core.Dialogs.Secured
{
    public class SecuredDialogUseCaseHandler
    {
        public static SecuredDialogPreferences GetPreferences(SecuredDialogUsecase usecase)
        {
            _preferenzes.TryGetValue(usecase, out var preferences);
            return preferences ?? null;
        }

        public static Dictionary<SecuredDialogUsecase, SecuredDialogPreferences> _preferenzes = new Dictionary<SecuredDialogUsecase, SecuredDialogPreferences>()
        {
            {SecuredDialogUsecase.EnCryptionKeyFetch, new SecuredDialogPreferences("SecuredHost", "Please put in youre Key","",BroadcastChannel.Instance,BroadcastEndPoint.Encryption) }
        };
    }
}
