using AutoMapper;
using Entities.Concrete;
using Entities.Concrete.Dtos;

namespace WebAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<CuriousCustomerDto , CuriousCustomer>();
            CreateMap<ForeignInvestorDto, ForeignInvestor>();
            CreateMap<InvestorDto, Investor>();
            CreateMap<PossibleCustomerDto, PossibleCustomer>();
            CreateMap<RoutineServiceDto, RoutineService>();
            CreateMap<SessionDto,Session>();
        }
    }
}
