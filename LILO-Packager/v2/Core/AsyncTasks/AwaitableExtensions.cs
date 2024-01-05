using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.AsyncTasks
{
    public static class AwaitableExtensions
    {
        public static Task ToTask<T>(this Task<T> awaitable)
        {
            if (awaitable == null)
            {
                throw new ArgumentNullException("awaitable");
            }

            return awaitable;
        }

        public static Task ToTask(this Func<Task> operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException("operation");
            }

            return operation();
        }

        public static Task ToTask(this Func<CancellationToken, Task> operation, CancellationToken cancellationToken)
        {
            if (operation == null)
            {
                throw new ArgumentNullException("operation");
            }

            return operation(cancellationToken);
        }
    }

}
