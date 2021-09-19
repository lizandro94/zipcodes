using Moq;
using System.Collections.Generic;
using Zipcodes.Application.Contracts;
using Zipcodes.Domain.Entities;

namespace Zipcodes.Application.UnitTests.Mocks
{
    public class ServiceMocks
    {
        public static Mock<IHtmlPackService> GetHtmlPackService()
        {
            var postalRecords = new List<PostalRecord>
            {
                new PostalRecord
                {
                    Department = "Managua",
                    Municipality = "Managua",
                    Zipcode = "11015",
                    Neighbourhood = "Sector Oeste Portezuelo"
                },
                new PostalRecord
                {
                    Department = "Managua",
                    Municipality = "Managua",
                    Zipcode = "13021",
                    Neighbourhood = "Herlinda López"
                },
                new PostalRecord
                {
                    Department = "Masaya",
                    Municipality = "Masaya",
                    Zipcode = "41000",
                    Neighbourhood = "Master code"
                },
                 new PostalRecord
                {
                    Department = "Carazo",
                    Municipality = "Dolores",
                    Zipcode = "46100",
                    Neighbourhood = "Master code"
                }
            };
            var mockHtmlPackService = new Mock<IHtmlPackService>();

            mockHtmlPackService.Setup(repo => repo.GetPostalRecords()).ReturnsAsync(postalRecords);

            return mockHtmlPackService;
        }
    }
}
