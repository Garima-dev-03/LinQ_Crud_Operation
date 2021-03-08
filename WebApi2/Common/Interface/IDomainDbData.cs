using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Common.Models.Dtos;
using WebApi2.Dtos;
using WebApi2.Models;

namespace WebApi2.Common.Interface
{
    public interface IDomainDbData
    {
        public Task<IEnumerable<WebApiReadDto>> GetAllData();
        public WebApiReadDto GetDataById(int Id);

        public WebApiReadDto AddData(WebApiCreateDto command);
        public void Updatecomnd(int id, WebApiUpdateDto webApiUpdateDto);
    }
}
