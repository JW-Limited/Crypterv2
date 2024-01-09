using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Shared
{
    public interface IManagableDialog : IDisposable
    {
        /// <summary>
        /// Indicates whether the dialog is accessible for access.
        /// </summary>
        /// <value><c>true</c> if the dialog is accessible; otherwise, <c>false</c>.</value>
        bool CanBeAccessed { get; set; }

        /// <summary>
        /// Indicates whether the dialog has been accessed.
        /// </summary>
        /// <value><c>true</c> if the dialog has been accessed; otherwise, <c>false</c>.</value>
        bool IsAccessed { get; set; }

        /// <summary>
        /// Provides a unique identifier for the dialog.
        /// </summary>
        /// <value>A unique identifier for the dialog.</value>
        int DialogId { get; }

        /// <summary>
        /// Loads and initializes the dialog's data.
        /// </summary>
        void LoadData();

        /// <summary>
        /// Saves the dialog's data to persistent storage.
        /// </summary>
        void SaveData();

        /// <summary>
        /// Handles the dialog's internal operations and events.
        /// </summary>
        void ProcessDialog();

        /// <summary>
        /// Displays the dialog.
        /// </summary>
        void ShowDialog(object sender);
    }

    public class ManagableDialog
    {
        private readonly Form Form;
        private readonly IManagableDialog Interface;
        private readonly int DialogId;

        public ManagableDialog(Form form, IManagableDialog dialog)
        {
            Form = form;
            Interface = dialog;
            DialogId = Guid.NewGuid().GetHashCode();
        }

        public Form _Form
        {
            get
            {
                return Form;
            }
        }

        public IManagableDialog _Interface
        {
            get
            {
                return Interface;
            }
        }

        public int _DialogId
        {
            get
            {
                return DialogId;
            }
        }
    }

    public interface IDialogManager
    {
        byte ShowDialog<TService>(Form form, TService Dialoginterface);
    }

    public class DialogManager : IDialogManager
    {
        public static DialogManager Instance 
        {
            get
            {
                try
                {
                    if (Program.InstanceCacheContainer.Resolve<IDialogManager>() is not null)
                    {
                        return Program.InstanceCacheContainer.Resolve<IDialogManager>() as DialogManager;
                    }
                }
                catch(Exception e)
                {
                    ConsoleManager.Instance().WriteLineWithColor(e.Message);
                }

                var tempInstance = new DialogManager();
                Program.InstanceCacheContainer.Register<IDialogManager>(() => tempInstance);

                return tempInstance;
            }
        }

        public ManagableDialog OpendForm = null;
        public Dictionary<string,ManagableDialog> History = new Dictionary<string,ManagableDialog>();


        /// <summary>
        /// Displays the specified dialog form.
        /// </summary>
        /// <typeparam name="TService">The type of the dialog service.</typeparam>
        /// <param name="form">The dialog form to display.</param>
        /// <returns>A byte indicating success or failure.</returns>
        public byte ShowDialog<TService>(Form form, TService Dialoginterface)
        {
            if (OpendForm != null)
            {
                OpendForm._Form.Close();
            }
            try
            {
                var uiDialog = Program.InstanceCacheContainer.Resolve<TService>() as IManagableDialog;
                if (uiDialog.CanBeAccessed && uiDialog.IsAccessed)
                {
                    uiDialog.ShowDialog(this);
                    return 1;
                }
            }
            catch (Exception)
            {
                var newForm = new ManagableDialog(form, Dialoginterface as IManagableDialog);

                Program.InstanceCacheContainer.Register<TService>(() => form);
                form.ShowDialog();
                return 1;
            }

            return 0;
        }
    
    }
}
