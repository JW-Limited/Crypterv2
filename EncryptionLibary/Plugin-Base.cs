using LILO_Packager.v2.plugins.PluginCore;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace EncryptionLibary
{
    public class PluginBase : IPluginBase
    {
        public string Name { get; set; } = "Encryption Library";
        public PluginID ID { get; set; } = PluginID.GetID("enc","lbl","lvl01");
        public string Description { get; set; } = "A Library for more Encryption Models";
        public string Version { get; set; } = "v0.0.1alpha";
        public Form PluginInterface { get; set; } = Core.PluginInterface.Instance("v0.0.1alpha", PluginID.GetID("enc", "lbl", "lvl01"), "EncryptionLibary Installer");

        public ObservableCollection<object> DynamicValues { get; set; } 
       
        public PluginResponse Execute(PluginParameters args)
        {
            var para = new PluginResponse();
            try
            {
                para.HasError = false;
                para.Message = "Executed Succesfully";
                para.MessageID = "0x0";
            }
            catch (Exception ex)
            {
                para.HasError = true;
                para.Message = ex.Message;
                para.MessageID = "0x10";
            }
            

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

        public PluginResponse Close()
        {
            var para = new PluginResponse();
            return para;
        }
    }
}