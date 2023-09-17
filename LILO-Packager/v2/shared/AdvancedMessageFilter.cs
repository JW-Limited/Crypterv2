using LILO_Packager.v2.Core.Interfaces;

namespace LILO_Packager.v2.shared
{
    public class AdvancedMessageFilter : IMessageFilter, IAdvancedMessageFilter
    {
        private const int WM_CUSTOM_MESSAGE = 0x8000;
        private const int WM_CUSTOM_ACTION = 0x8001;
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_MOUSEWHEEL = 0x020A;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int WM_CUSTOM_MOUSE_CLICK = 0x8002;
        private const int WM_CUSTOM_MOUSE_DOUBLE_CLICK = 0x8003;
        private const int WM_CLIPBOARD_UPDATE = 0x031D;

        private readonly Form targetForm;

        private List<string> customMessages = new List<string>();

        public AdvancedMessageFilter(Form form)
        {
            targetForm = form;

            targetForm.Activated += (sender, e) =>
            {
                //Console.WriteLine("Form Regained Focus");
                Message message = Message.Create(targetForm.Handle, 0x0008, nint.Zero, nint.Zero);
                //Console.WriteLine($"Additional Info - WPARAM: {message.WParam}, LPARAM: {message.LParam}");
            };


        }

        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_MOUSEMOVE:
                    int xPos = (short)m.LParam;
                    int yPos = (short)(m.LParam >> 16);
                    //Console.WriteLine($"Mouse Move: X={xPos}, Y={yPos}");
                    break;

                case WM_MOUSEWHEEL:
                    int delta = (short)(m.WParam >> 16);
                    //Console.WriteLine($"Mouse Wheel: Delta={delta}");
                    break;

                case WM_KEYDOWN:
                    Keys keyData = (Keys)(int)m.WParam;
                    //Console.WriteLine($"Key Down: {keyData}");
                    break;

                case WM_KEYUP:
                    Keys keyUpData = (Keys)(int)m.WParam;
                    //Console.WriteLine($"Key Up: {keyUpData}");
                    break;

                case WM_CUSTOM_MESSAGE:
                    customMessages.Add("Custom Message Received");
                    //Console.WriteLine("Custom Message Received");
                    break;

                case WM_CUSTOM_ACTION:
                    //Console.WriteLine("Custom Action Performed");
                    break;

                case WM_CUSTOM_MOUSE_CLICK:
                    //Console.WriteLine("Custom Mouse Click");
                    break;

                case WM_CUSTOM_MOUSE_DOUBLE_CLICK:
                    //Console.WriteLine("Custom Mouse Double-Click");
                    break;

                case WM_CLIPBOARD_UPDATE:
                    //Console.WriteLine("Clipboard Updated");
                    break;

                default:
                    break;
            }

            return false;
        }

        public List<string> GetCustomMessages()
        {
            return customMessages;
        }
    }
}

