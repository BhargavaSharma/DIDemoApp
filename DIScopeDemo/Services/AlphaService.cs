using DIScopeDemo.Interfaces;
using System;

namespace DIScopeDemo.Services
{
    public class AlphaService
    {
        private readonly ITransientService _transientService;
        private readonly ISingletonService _singletonService;
        private readonly ISingletonInstanceService _singletonInstanceService;
        private readonly IScopedService _scopedService;

        public AlphaService(ITransientService transientService, IScopedService scopedService, ISingletonService singletonService, ISingletonInstanceService singletonInstanceService)
        {
            _transientService = transientService;
            _scopedService = scopedService;
            _singletonService = singletonService;
            _singletonInstanceService = singletonInstanceService;
        }

        public void LogRequestId()
        {
            Console.WriteLine("Alpha Service Output");
            Console.WriteLine($"Transient Request Id : {_transientService.requestId}");
            Console.WriteLine($"Scoped Request Id : {_scopedService.requestId}");
            Console.WriteLine($"Singleton Request Id : {_singletonService.requestId}");
            Console.WriteLine($"Singleton Instance Request Id : {_singletonInstanceService.requestId}");
        }
    }
}
