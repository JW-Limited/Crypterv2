namespace LILO_Packager.v2.Core.Interfaces
{
    public interface IAdvancedMessageFilter
    {
        List<string> GetCustomMessages();
        bool PreFilterMessage(ref Message m);
    }
}