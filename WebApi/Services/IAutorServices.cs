using Domain.Entities;

namespace WebApi.Services
{
    public interface IAutorServices
    {

        public Task<Response<List<Autor>>> GetAutores();
    }
}
