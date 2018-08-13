using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedRiver.Saffron.AspNetCore;
using RedRiver.Saffron.Cqrs;

namespace CruiseLine.Shared.Templates
{
    public class CreateENTITYCommand : CommandBase
    {
    }

    public class CreateENTITYCommandHandler : CommandHandlerBase<CreateENTITYCommand>
    {
        private readonly CoreContext _context;

        public CreateENTITYCommandHandler(CoreContext context)
        {
            _context = context;
        }

        public override async Task ExecuteAsync(CreateENTITYCommand command)
        {


            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
