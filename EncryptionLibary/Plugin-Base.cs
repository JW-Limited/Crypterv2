using LILO_Packager.v2.plugins.PluginCore;
using System.Collections.ObjectModel;

namespace EncryptionLibary
{
    public class AES256 : IPluginBase
    {
        public string Name { get; set; } = "Encryption Library";
        public string ID { get; set; } = "lvl01_enclbl";
        public string Description { get; set; } = "A Library for more Encryption Models";
        public string Version { get; set; } = "v0.0.1alpha";

        public ObservableCollection<object> DynamicValues { get; set; } 
       

        public PluginResponse Execute(PluginParameters args)
        {
            var para = new PluginResponse();
            para.HasError = false;
            para.Message = "Executed Succesfully";
            para.MessageID = "0x0";

            return para;
        }

        public PluginResponse Initialize(PluginParameters args)
        {
            var para = new PluginResponse();

            try
            {

                para.HasError = false;
                para.Message = "Initilized Succesfully";
                para.MessageID = "0x0";

                return para;
            }
            catch (Exception ex)
            {
                para.HasError = true;
                para.Message = ex.Message;
                para.MessageID = "0x10";

                return para;
            }
            
        }
    }
}