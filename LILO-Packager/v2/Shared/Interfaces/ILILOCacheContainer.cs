namespace LILO_Packager.v2.Shared.Interfaces
{
    public interface ILILOCacheContainer
    {
        void ClearAll();
        IEnumerable<object> GetAllServices();
        void Intercept<TService>(Func<TService, TService> interceptor);
        void Register<TService>(Func<object> factory);
        void Register<TService>(string name, Func<object> factory);
        void RegisterScoped<TService>(Func<object> factory);
        void RegisterService<TService>(Func<object> factory, Func<bool> condition);
        void RegisterSingleton<TService>(Func<object> factory);
        void RegisterTransient<TService>(Func<object> factory);
        TService Resolve<TService>();
        TService Resolve<TService>(string name);
        void Unregister<TService>();
    }
}