using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedRiver.Saffron.AspNetCore;
using RedRiver.Saffron.Cqrs;

namespace CruiseLine.Shared.Temp
{
    public class DeleteENTITYCommand : CommandBase
    {
        public Guid Id { get; set; }
    }

    public class DeleteENTITYCommandHandler : CommandHandlerBase<DeleteENTITYCommand>
    {
        private readonly CoreContext _context;

        public DeleteENTITYCommandHandler(CoreContext context)
        {
            _context = context;
        }

        public override async Task ExecuteAsync(DeleteENTITYCommand command)
        {
            var enquiryQuery = await _context.Enquiries.SingleOrDefaultAsync(x => x.Id == command.Id);

            if (enquiryQuery == null)
            {
                throw new ErrorCodeException(ENTITYErrors.InvalidEnquiryId);
            }

            enquiryQuery.DeletedUtc = DateTime.UtcNow;

            await _context.SaveChangesAsync();
        }
    }
}
