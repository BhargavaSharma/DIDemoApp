using DIScopeDemo.Interfaces;
using System;

namespace DIScopeDemo
{
    public class RequestScope: IScopedService, ISingletonService, ITransientService, ISingletonInstanceService
    {
        public Guid requestId { get; set; }

        public RequestScope(): this(Guid.NewGuid())
        {

        }

        public RequestScope(Guid id)
        {
            requestId = id;
        }
    }
}
