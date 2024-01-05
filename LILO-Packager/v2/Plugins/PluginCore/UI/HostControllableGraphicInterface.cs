using System.ComponentModel.Design;
using System.ComponentModel;

namespace LILO_Packager.v2.Plugins.PluginCore.UI
{
    [DefaultEvent("InitializeGraphicContainer")]
    [Designer("System.Windows.Forms.Design.FormDocumentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(IRootDesigner))]
    [DesignerCategory("Form")]
    [DesignTimeVisible(false)]
    [InitializationEvent("Load")]
    [ToolboxItem(true)]
    [ToolboxItemFilter("System.Windows.Forms.Control.TopLevel")]
    public class HostControllableGraphicInterface : Form
    {
        public HostControllableGraphicInterface()
        {

        }

        public Color PreviousBackgroundColor { get; set; }
        public bool UserControlActive = true;
        public static HostControllableGraphicInterface? ActiveInterface { get; }
        public EventHandler<ErrorEventArgs> ErrorHandler { get; set; }
        public Dictionary<string,ErrorEventArgs> Errors { get; set; } = new Dictionary<string, ErrorEventArgs>();

        protected virtual void OnError(ErrorEventArgs e)
        {
            ErrorHandler?.Invoke(this, e);
            Errors.Add(e.GetHashCode().ToString(), e);
        }

        public void UserControl(bool value)
        {
            if(UserControlActive && !value)
            {
                this.Enabled = false;
                this.AllowDrop = false;
                PreviousBackgroundColor = this.BackColor;
                this.BackColor = Color.WhiteSmoke;
                UserControlActive = false;
            }
            else if (!UserControlActive && value) 
            {
                this.Enabled = false;
                this.AllowDrop = false;
                this.BackColor = PreviousBackgroundColor;
                UserControlActive = true;
            }
        }
    }

    public class ErrorEventArgs : EventArgs 
    {

    }
}
