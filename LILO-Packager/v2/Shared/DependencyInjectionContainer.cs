using LILO_Packager.v2.Shared.Interfaces;

namespace LILO_Packager.v2.Shared
{
    public class DependencyInjectionContainer : ILILOCacheContainer
    {
        private readonly Dictionary<Type, object> _instances;
        private readonly Dictionary<Type, Func<object>> _factories;

        private readonly Dictionary<Type, Dictionary<string, Func<object>>> __factoriesNames;
        private readonly Dictionary<Type, Dictionary<string, object>> __instancesNames;

        public DependencyInjectionContainer()
        {
            _instances = new Dictionary<Type, object>();
            _factories = new Dictionary<Type, Func<object>>();
        }

        public void Register<TService>(Func<object> factory)
        {
            _factories.Add(typeof(TService), factory);
        }

        public void Register<TService>(string name, Func<object> factory)
        {
            var type = typeof(TService);
            if (!_factories.ContainsKey(type))
            {
                __factoriesNames.Add(type, new Dictionary<string, Func<object>>());
            }

            __factoriesNames[type].Add(name, factory);
        }

        public void RegisterSingleton<TService>(Func<object> factory)
        {
            _instances[typeof(TService)] = factory();
        }

        public void RegisterScoped<TService>(Func<object> factory)
        {
            _factories.Add(typeof(TService), factory);
        }

        public void RegisterTransient<TService>(Func<object> factory)
        {
            _factories.Add(typeof(TService), factory);
        }

        public void RegisterService<TService>(Func<object> factory, Func<bool> condition)
        {
            if (condition())
            {
                _factories.Add(typeof(TService), factory);
            }
        }

        /*var container = new DependencyInjectionContainer();

        container.Register<IMyService, MyService>();

        container.Intercept<IMyService>(LogServiceCalls);
        */

        public void Intercept<TService>(Func<TService, TService> interceptor)
        {
            _factories[typeof(TService)] = () =>
            {
                var instance = interceptor(Resolve<TService>());
                return instance;
            };
        }

        public TService Resolve<TService>()
        {
            var type = typeof(TService);
            if (!_instances.ContainsKey(type))
            {
                if (!_factories.ContainsKey(type))
                {
                    throw new Exception($"No service registered for type {type.FullName}");
                }

                var factory = _factories[type];
                var instance = factory();
                _instances.Add(type, instance);
            }

            return (TService)_instances[type];
        }

        public void Unregister<TService>()
        {
            _factories.Remove(typeof(TService));
        }

        public void ClearAll()
        {
            _instances.Clear();
            _factories.Clear();
            __instancesNames.Clear();
            __factoriesNames.Clear();
        }

        public IEnumerable<object> GetAllServices()
        {
            return _instances.Values;
        }


        public TService Resolve<TService>(string name)
        {
            var type = typeof(TService);
            if (!_instances.ContainsKey(type))
            {
                if (!__factoriesNames.ContainsKey(type))
                {
                    throw new Exception($"No service registered for type {type.FullName} with name {name}");
                }

                var factory = __factoriesNames[type][name];
                var instance = factory();
                __instancesNames.Add(type, new Dictionary<string, object>());
                __instancesNames[type].Add(name, instance);
            }

            return (TService)__instancesNames[type][name];
        }
    }
}

