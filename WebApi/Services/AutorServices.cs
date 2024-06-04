using Dapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WebApi.Context;

namespace WebApi.Services
{
    public class AutorServices : IAutorServices
    {
        private readonly ApplicationDBContext _context;
        public AutorServices(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Response<List<Autor>>> GetAutores()
        {
            try
            {
                List<Autor> respose = new List<Autor>();

                var result = await _context.Database.GetDbConnection().QueryAsync<Autor>("spGetAutores", new {}, commandType: CommandType.StoredProcedure);

                respose = result.ToList();

                return new Response<List<Autor>> (respose); 
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedio un error catastrofico" + ex.Message);
            }
        }
    }
}
