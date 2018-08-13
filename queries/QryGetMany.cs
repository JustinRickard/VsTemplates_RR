using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CruiseLine.Database.Models;
using CruiseLine.Logic.Enquiries;
using RedRiver.Saffron.Cqrs;

namespace CruiseLine.Shared.Templates
{
    public class ENTITIESQuery : QueryBase<ENTITYListView[]>
    {
    }

    public class ENTITIESQueryHandler : QueryHandlerBase<ENTITIESQuery, ENTITYListView[]>
    {
        private readonly CoreContext _coreContext;
        private readonly IConfigurationProvider _mapConfig;

        public ENTITIESQueryHandler(CoreContext context, IConfigurationProvider mapConfig)
        {
            _coreContext = context;
            _mapConfig = mapConfig;
        }

        public override async Task<ENTITYListView[]> RunAsync(EnquiriesQuery query)
        {
        }
    }
}
