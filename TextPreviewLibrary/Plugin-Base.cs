using LILO_Packager.v2.Core.Visuals;
using LILO_Packager.v2.Core.Updates;
using LILO_Packager.v2.plugins.PluginCore;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using TextPreviewLibrary.Core.Formats;

namespace TextPreviewLibrary
{
    public class PluginBase : IPluginBase
    {
        public string Name { get; set; } = "TextPreviewLibrary";
        public PluginID ID { get; set; } = PluginID.GetID("tpl", "lbl", "lvl02");
        public string Description { get; set; } = "A Library for previewing plain based Files";
        public string Version { get; set; } = "v0.1";
        public static SemanticVersion _sVersion = new SemanticVersion(0, 1, 2, "alpha", false);
        public Form PluginInterface { get; set; } = Core.PluginInterface.Instance("v0.1", PluginID.GetID("tpl", "lbl", "lvl02"), "Text-Preview",true);
        public static ThemeManager _thManager;
        public ObservableCollection<object> DynamicValues { get; set; }

        public PluginResponse Execute(PluginParameters args)
        {

            var para = new PluginResponse();

            try
            {

                if(args.themeManager != null)
                {
                    _thManager = (ThemeManager)args.themeManager;
                }
                else
                {
                    _thManager = ThemeManager.Initialize();
                }

                var file = (string)args.Context[0];

                Core.PluginInterface.Instance(null, null, null, false).SetContent(new CrypterTextFile()
                {
                    RtfContent = File.ReadAllText(file),
                    IsLocked = true,
                    FileName = Path.GetFileName(file),
                    Author = "n/a"
                });

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
