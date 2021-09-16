using System.Collections.Generic;
using System.Threading.Tasks;
using Zipcodes.Domain.Entities;

namespace Zipcodes.Application.Contracts
{
    public interface IHtmlPackService
    {
        Task<List<PostalRecord>> GetPostalRecords();
    }
}
