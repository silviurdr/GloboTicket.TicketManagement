using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Events
{
    class GetEventsListQuery: IRequest<List<EventListVm>>
    {
    }
}
