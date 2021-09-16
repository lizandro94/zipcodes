using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zipcodes.Domain.Entities;

namespace Zipcodes.Application.Contracts
{
    public interface IPostalRecordRepository
    {
        List<PostalRecord> GetPostalRecords();
    }
}
