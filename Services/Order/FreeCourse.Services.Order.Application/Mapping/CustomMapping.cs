using AutoMapper;
using FreeCourse.Service.Order.Domain.OrderAggregate;
using FreeCourse.Services.Order.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Application.Mapping
{
    public class CustomMapping:Profile
    {
        public CustomMapping() {
            CreateMap<Service.Order.Domain.OrderAggregate.Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
        }
      
    }
}
