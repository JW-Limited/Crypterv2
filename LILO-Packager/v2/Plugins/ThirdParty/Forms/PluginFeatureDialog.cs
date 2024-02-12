using LILO_Packager.v2.Controls;
using Modern.Forms.Renderers;
using System.ComponentModel;
using System.Windows.Forms;

namespace LILO_Packager.v2.Plugins.ThirdParty.Forms
{
    public class PluginFeatureList : Form
    {
        private ModernListView featureListBox;

        public PluginFeatureList(string featureList)
        {
            InitializeComponents(featureList);
        }

        private void InitializeComponents(string featureList)
        {
            this.Text = "Feature List";
            this.Size = new Size(600, 400);
            this.FormBorderStyle = FormBorderStyle.Sizable; 
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White; 

            featureListBox = new ModernListView()
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10),
                BackColor = Color.White,
            };
            var features = featureList.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var _bindingSource = new BindingSource();
            foreach(var feature in features )
            {
                _bindingSource.Add(feature);
               featureListBox.Add(feature);
            }



            featureListBox.ForeColor = Color.DimGray;
            featureListBox.BackColor = Color.WhiteSmoke;
            featureListBox.Padding = new Padding(10);
            this.Controls.Add(featureListBox);
        }

        public static void ShowFeatureList(string featureList)
        {
            using (var dialog = new PluginFeatureList(featureList))
            {
                dialog.ShowDialog();
            }
        }
    }

    
}
