using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Common.Interface;
using WebApi2.Common.Models.Dtos;
using WebApi2.Data;
using WebApi2.Dtos;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    [Route("api/WebApi")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        private readonly IDomainDbData _domain;
        private readonly IMapper _mapper;
        public WebApiController(IDomainDbData Dbdata, IMapper mapper)
        {
            _domain = Dbdata;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<WebApiReadDto>>> GetAllCommands()
        {
            var CommandItems = await _domain.GetAllData();

            return Ok(CommandItems);
            //return Ok(_mapper.Map<IEnumerable<WebApiReadDto>>(CommandItems));
        }


        [HttpGet("{id}")]
        public ActionResult<WebApiReadDto> GetCommandById(int id)
        {

            var response = _domain.GetDataById(id);
            return response;
        }
        [HttpPost]
        public ActionResult<WebApiReadDto> CreateCommandAsync(WebApiCreateDto commandCreateDto)
        {

            var response = _domain.AddData(commandCreateDto);

            return response;

        }
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, WebApiUpdateDto webApiUpdateDto)
        {
            _domain.Updatecomnd(id, webApiUpdateDto);
            return NoContent();
        }
    }
            

    
}
