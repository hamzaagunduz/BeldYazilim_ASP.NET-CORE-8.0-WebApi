﻿using BeldYazilim.Application.Features.Mediator.Results.AboutResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Queries.AboutQueries
{
    public  class GetAllAboutQuery:IRequest<List<GetAllAboutQueryResult>>
    {
    }
}
