using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Common.Models.Dtos;
using WebApi2.Dtos;
using WebApi2.Models;

namespace WebApi2.Profiles
{
    public class WebApiProfiles:Profile
    {
        public WebApiProfiles()
        {
            CreateMap<WebApiModel,WebApiReadDto>();
            CreateMap<WebApiReadDto, WebApiModel>();
            CreateMap<WebApiCreateDto, WebApiModel>();
            CreateMap<WebApiModel, WebApiCreateDto>();
            CreateMap<WebApiUpdateDto, WebApiModel>();
            CreateMap <WebApiModel,WebApiUpdateDto>();
        }
    }
}
