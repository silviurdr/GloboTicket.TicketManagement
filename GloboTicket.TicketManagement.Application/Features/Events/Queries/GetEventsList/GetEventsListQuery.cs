using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Events
{
    public class GetEventsListQuery: IRequest<List<EventListVm>>
    {
    }
}
