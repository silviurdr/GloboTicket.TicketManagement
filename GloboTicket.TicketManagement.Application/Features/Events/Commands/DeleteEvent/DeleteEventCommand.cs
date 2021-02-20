using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands
{
    public class DeleteEventCommand: IRequest
    {
        public Guid EventId { get; set; }
    }
}
