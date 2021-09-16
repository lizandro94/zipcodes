using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using Zipcodes.Application.Contracts;
using Zipcodes.Domain.Entities;

namespace Zipcodes.Infrastructure.HtmlPack
{
    public class HtmlPackService : IPostalRecordRepository
    {
        public List<PostalRecord> GetPostalRecords()
        {
            var url = "https://en.wikipedia.org/wiki/Postal_codes_in_Nicaragua";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            
            var table = doc.DocumentNode.SelectSingleNode("//table")
            .Descendants("tr")
            .Where(tr => tr.Elements("td").Count() > 1)
            .Select(tr => new PostalRecord
            {
                Department = tr.Elements("td").Select(td => td.InnerText.Trim()).First()
            })
            .ToList();

            return table;
        }
    }
}
