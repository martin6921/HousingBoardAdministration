using BookingSystemApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Resident.GetAllResident;

    public class GetAllResidentQueryHandler : IRequestHandler<GetAllResidentQuery, List<GetAllResidentQueryResult>>
    {
        private readonly IResidentRepository _ResidentRepository;

        public GetAllResidentQueryHandler(IResidentRepository residentRepository)
        {
            _ResidentRepository = residentRepository;
        }

        Task<List<GetAllResidentQueryResult>> IRequestHandler<GetAllResidentQuery, List<GetAllResidentQueryResult>>.Handle(GetAllResidentQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_ResidentRepository.GetAll(request.Id).ToList());
        }
    }
