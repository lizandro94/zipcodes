using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zipcodes.Application.Contracts;
using Zipcodes.Domain.Entities;

namespace Zipcodes.Infrastructure.HtmlPack
{
    public class HtmlPackService : IHtmlPackService
    {
        public async Task<List<PostalRecord>> GetPostalRecords()
        {
            var web = new HtmlWeb();
            var doc = await web.LoadFromWebAsync(HtmlPackConstants.ZIPCODES_WIKIPEDIA_URL);
            
            var table = doc.DocumentNode.SelectSingleNode("//table")
            .Descendants("tr")
            .Where(tr => tr.Elements("td").Count() > 1)
            .Select(tr => new PostalRecord
            {
                Department = tr.Element("td").InnerText.Trim(),
                Municipality = tr.Elements("td").Select(td => td.InnerText.Trim()).Skip(1).First(),
                Zipcode = tr.Elements("td").Select(td => td.InnerText.Trim()).Skip(2).First(),
                Neighbourhood = tr.Elements("td").Select(td => td.InnerText.Trim()).Skip(3).First(),
            })
            .ToList();

            return table;
        }
    }
}
