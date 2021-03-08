using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Common.Interface;
using WebApi2.Common.Models.Dtos;
using WebApi2.Data;
using WebApi2.Dtos;
using WebApi2.Models;

namespace WebApi2.Domain
{
    public class DomainDbData:IDomainDbData

    {
        private readonly IWebApiRep _repository;
        private readonly IMapper _mapper;
        public DomainDbData(IWebApiRep repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        
        public WebApiReadDto AddData(WebApiCreateDto commandCreateDto)
        {
            var command = _mapper.Map<WebApiModel>(commandCreateDto);
            _repository.CreateCommand(command);
            _repository.SaveChanges();
            var response = _mapper.Map<WebApiReadDto>(command);
            return response;
            
        }
        public async Task<IEnumerable<WebApiReadDto>> GetAllData()
        {
            
            var response = await _repository.GetAllComands();
            var command = _mapper.Map<IEnumerable<WebApiReadDto>>(response);
            return command;
        }

        public WebApiReadDto GetDataById(int Id)
        {
            var CommandItem = _repository.GetCommandById(Id);
            var response = _mapper.Map<WebApiReadDto>(CommandItem);
            return response;
            
        }

        public void Updatecomnd(int id,WebApiUpdateDto webApiUpdateDto)
        {
          
            _repository.UpdateCommand(id,webApiUpdateDto);
            _repository.SaveChanges();
            //var result  = _mapper.Map<WebApiReadDto>(response);
            //return result;
            
        }
    }
}
