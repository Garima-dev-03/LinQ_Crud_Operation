using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Common.Models.Dtos;
using WebApi2.Models;

namespace WebApi2.Data
{
    public class SQLWebApiRep : IWebApiRep
    {
        private readonly WebApiContext _context;
        public SQLWebApiRep(WebApiContext context)  //Dependency injection used , using context class to get data from database
        {
            _context = context;
        }
        public void CreateCommand(WebApiModel cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.WebApiTable.Add(cmd);

        }

        public async Task<IEnumerable<WebApiModel>> GetAllComands()
        {
            //return _context.WebApiTable.ToList();
            try
            {
                var filterData = await (from var in _context.WebApiTable
                                 select var).ToListAsync();
                return filterData; 
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public WebApiModel GetCommandById(int Id)
        {
        
            return _context.WebApiTable.FirstOrDefault(p => p.id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(int id,WebApiUpdateDto cmd)
        {
            foreach (var data in _context.WebApiTable.ToList())
            {
                if(data.Name !=cmd.Name)
                {
                    if(data.Email==cmd.Email)
                    {
                        data.UpdateDate = DateTime.Now;
                        data.Name = cmd.Name;
                    }
                }

            }
            

                                               

        }
    }
}
