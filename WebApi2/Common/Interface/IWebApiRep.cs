using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Common.Models.Dtos;
using WebApi2.Models;

namespace WebApi2.Data
{
    public interface IWebApiRep
    {
        bool SaveChanges();

       Task<IEnumerable<WebApiModel>> GetAllComands();

       WebApiModel GetCommandById(int Id);

        void CreateCommand(WebApiModel cmd);
        void UpdateCommand(int id,WebApiUpdateDto cmd);
    }
}
