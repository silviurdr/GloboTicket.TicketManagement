using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    class GetCategoriesListQuery: IRequest<List<CategoryListVm>>
    {
    }
}
