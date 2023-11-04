using Crypterv2.DevTool.Core.Types;

namespace Crypterv2.DevTool.Core.Forms
{
    public partial class uiDialogFeatures : Form
    {
        public List<PluginFeature> CapabilityInfo;
        public List<PluginFeature> BackUp;
        public bool Canceled;

        public uiDialogFeatures(List<PluginFeature> featureList)
        {
            InitializeComponent();

            CapabilityInfo = featureList;
            BackUp = featureList;
        }

        public List<PluginFeature> GetFeatures()
        {
            base.ShowDialog();

            if (Canceled)
            {
                return BackUp;
            }

            var hashList = new HashSet<PluginFeature>(CapabilityInfo);

            return hashList.ToList();
        }

        private void uiDialogFeatures_Load(object sender, EventArgs e)
        {
            pnlMultimedia.Checked = false;
            pnlUI.Checked = false;
            pnlLLSHandle.Checked = false;
            pnlBroadCasting.Checked = true;
            pnlFileHandle.Checked = false;
            pnlOSRes.Checked = true;
            pnlOSRes.EnabledState = true;
            pnlBroadCasting.EnabledState = true;


            foreach (var item in CapabilityInfo)
            {
                switch (item.Name)
                {
                    case "BroadCasting":
                        pnlBroadCasting.Checked = true;
                        break;
                    case "OSRes":
                        pnlOSRes.Checked = true;
                        break;
                    case "LLS Handle":
                        pnlLLSHandle.Checked = true;
                        break;
                    case "UI Library":
                        pnlUI.Checked = true;
                        break;
                    case "File Handle":
                        pnlFileHandle.Checked = true;
                        break;
                    case "Mulitimedia":
                        pnlMultimedia.Checked = true;
                        break;
                }
            }
        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            Canceled = true;
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            CapabilityInfo.Clear();

            if(pnlFileHandle.Checked)
            {
                CapabilityInfo.Add(new PluginFeature()
                {
                    Name = "File Handle",
                    Description = "Providing a FileHandling Library.",
                    ArgumentInfo = new LILO_Packager.v2.Plugins.ThirdParty.Types.ArgumentInfo()
                    {
                        Name = "file",
                        Type = "string",
                    }
                   
                });
            }

            if (pnlUI.Checked)
            {
                CapabilityInfo.Add(new PluginFeature()
                {
                    Name = "UI Library",
                    Description = "Providing a extensible UI Library.",
                    ArgumentInfo = new LILO_Packager.v2.Plugins.ThirdParty.Types.ArgumentInfo()
                    {
                        Name = "mode",
                        Type = "string",
                    }

                });
            }

            if (pnlOSRes.Checked)
            {
                CapabilityInfo.Add(new PluginFeature()
                {
                    Name = "OSRes",
                    Description = "Use Systemresources",
                    ArgumentInfo = new LILO_Packager.v2.Plugins.ThirdParty.Types.ArgumentInfo()
                    {
                        Name = "admin",
                        Type = "bool",
                    }

                });
            }

            if (pnlMultimedia.Checked)
            {
                CapabilityInfo.Add(new PluginFeature()
                {
                    Name = "Mulitimedia",
                    Description = "Multimedia Handling",
                    ArgumentInfo = new LILO_Packager.v2.Plugins.ThirdParty.Types.ArgumentInfo()
                    {
                        Name = "file",
                        Type = "string",
                    }

                });
            }

            if (pnlLLSHandle.Checked)
            {
                CapabilityInfo.Add(new PluginFeature()
                {
                    Name = "LLS Handle",
                    Description = "En-and Decrypt LSS (LILO Synced Streams)",
                    ArgumentInfo = new LILO_Packager.v2.Plugins.ThirdParty.Types.ArgumentInfo()
                    {
                        Name = "streamKey",
                        Type = "string",
                    }

                });
            }

            if (pnlBroadCasting.Checked)
            {
                CapabilityInfo.Add(new PluginFeature()
                {
                    Name = "BroadCasting",
                    Description = "Crypterv2-MainHost Broadcasting",
                    ArgumentInfo = new LILO_Packager.v2.Plugins.ThirdParty.Types.ArgumentInfo()
                    {
                        Name = "IBroadCastObserver",
                        Type = "Interface",
                    }

                });
            }

            this.Close();
        }
    }
}
