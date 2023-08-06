using LILO_Packager.v2.plugins.PluginCore;
using System.Collections.ObjectModel;

namespace EncryptionLibary
{
    public class AES256 : IPluginBase
    {
        public string Name { get => "Encryption Library"; set => throw new NotImplementedException(); }
        public string Description { get => "A Library for more Encryption Models"; set => throw new NotImplementedException(); }
        public string Version { get => "v0.0.1alpha"; set => throw new NotImplementedException(); }

        public ObservableCollection<object> DynamicValues 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public PluginResponse Execute(PluginParameters args)
        {
            throw new NotImplementedException();
        }

        public PluginResponse Initialize(PluginParameters args)
        {
            var para = new PluginResponse();
            para.HasError = false;
            para.Message = "Initilized Succesfully";
            para.MessageID = "0x0";

            return para;
        }
    }
}