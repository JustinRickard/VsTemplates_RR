using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RedRiver.Saffron.Cqrs;

namespace CruiseLine.Shared.Templates
{
    public class UpdateENTITYCommand : CommandBase
    {
    }

    public class UpdateENTITYCommandHandler : CommandHandlerBase<UpdateENTITYCommand>
    {
        private readonly CoreContext _context;

        public UpdateENTITYCommandHandler(CoreContext context)
        {
            _context = context;
        }

        public override async Task ExecuteAsync(UpdateENTITYCommand command)
        {


            await _context.SaveChangesAsync();
        }
    }
}
