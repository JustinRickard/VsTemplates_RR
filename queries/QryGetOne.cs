using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RedRiver.Saffron.Cqrs;

namespace CruiseLine.Shared.Templates
{

    public class ENTITYQuery : QueryBase<ENTITYView>
    {
        public Guid Id { get; set; }
    }

    public class ENTITYQueryHandler : QueryHandlerBase<ENTITYQuery, ENTITYView>
    {
        private readonly CoreContext _context;
        private readonly IConfigurationProvider _mapConfig;

        public ENTITYQueryHandler(CoreContext context, IConfigurationProvider mapConfig)
        {
            _context = context;
            _mapConfig = mapConfig;
        }

        public override async Task<ENTITYView> RunAsync(ENTITYQuery query)
        {
        }
    }
}
