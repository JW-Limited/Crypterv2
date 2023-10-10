namespace LILO_Packager.v2.Shared
{
    public class DependencyInjectionContainer
    {
        private readonly Dictionary<Type, object> _instances;
        private readonly Dictionary<Type, Func<object>> _factories;

        public DependencyInjectionContainer()
        {
            _instances = new Dictionary<Type, object>();
            _factories = new Dictionary<Type, Func<object>>();
        }

        public void Register<TService>(Func<object> factory)
        {
            _factories.Add(typeof(TService), factory);
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

    }


}

