using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace LILO_WebEngine.Core.Middleware
{
    /// <summary>
    /// Middleware context holding state during request processing
    /// </summary>
    public class MiddlewareContext
    {
        /// <summary>
        /// The current HTTP request context
        /// </summary>
        public HttpListenerContext Context { get; }
        
        /// <summary>
        /// Tracks whether the response has been sent by a middleware
        /// </summary>
        public bool IsResponseSent { get; set; }
        
        /// <summary>
        /// Arbitrary items that can be shared between middleware components
        /// </summary>
        public Dictionary<string, object> Items { get; } = new Dictionary<string, object>();
        
        /// <summary>
        /// Creates a new middleware context
        /// </summary>
        /// <param name="context">The HTTP listener context</param>
        public MiddlewareContext(HttpListenerContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
    
    /// <summary>
    /// Interface for middleware components in the request pipeline
    /// </summary>
    public interface IRequestMiddleware
    {
        /// <summary>
        /// Processes the request
        /// </summary>
        /// <param name="context">The middleware context</param>
        /// <param name="next">The next middleware to invoke if this one doesn't handle the request</param>
        Task ProcessAsync(MiddlewareContext context, Func<Task> next);
    }
    
    /// <summary>
    /// Pipeline for executing middleware components in sequence
    /// </summary>
    public class RequestMiddlewarePipeline
    {
        private readonly List<IRequestMiddleware> _middleware = new List<IRequestMiddleware>();
        
        /// <summary>
        /// Adds a middleware to the pipeline
        /// </summary>
        /// <param name="middleware">The middleware to add</param>
        public void Add(IRequestMiddleware middleware)
        {
            if (middleware == null)
            {
                throw new ArgumentNullException(nameof(middleware));
            }
            
            _middleware.Add(middleware);
        }
        
        /// <summary>
        /// Clears all middleware from the pipeline
        /// </summary>
        public void Clear()
        {
            _middleware.Clear();
        }
        
        /// <summary>
        /// Executes the middleware pipeline
        /// </summary>
        /// <param name="context">The context for the current request</param>
        public async Task ExecuteAsync(MiddlewareContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            
            // Start the middleware execution chain
            await ExecuteMiddlewareAsync(context, 0);
        }
        
        private async Task ExecuteMiddlewareAsync(MiddlewareContext context, int index)
        {
            // If we've reached the end of the pipeline, return
            if (index >= _middleware.Count)
            {
                return;
            }
            
            // Get the current middleware
            var current = _middleware[index];
            
            // Define the next function
            Task Next() => ExecuteMiddlewareAsync(context, index + 1);
            
            // Execute the current middleware with the next function
            await current.ProcessAsync(context, Next);
        }
    }
    
    /// <summary>
    /// Base class for middleware components that simplifies implementation
    /// </summary>
    public abstract class RequestMiddlewareBase : IRequestMiddleware
    {
        /// <summary>
        /// Processes the request
        /// </summary>
        public async Task ProcessAsync(MiddlewareContext context, Func<Task> next)
        {
            try
            {
                await HandleRequestAsync(context);
                
                // If the response hasn't been sent and we're not at the end of the pipeline,
                // continue to the next middleware
                if (!context.IsResponseSent && next != null)
                {
                    await next();
                }
                
                await AfterRequestAsync(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
                
                // If the exception handler didn't send a response, throw
                if (!context.IsResponseSent)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// Handles the request before the next middleware is invoked
        /// </summary>
        protected virtual Task HandleRequestAsync(MiddlewareContext context)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Handles the request after the next middleware has been invoked
        /// </summary>
        protected virtual Task AfterRequestAsync(MiddlewareContext context)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Handles any exceptions that occur during request processing
        /// </summary>
        protected virtual Task HandleExceptionAsync(MiddlewareContext context, Exception exception)
        {
            return Task.CompletedTask;
        }
    }
}