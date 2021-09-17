namespace Zipcodes.Application.Features.PostalRecords.Queries.GetPostalRecords
{
    public class PostalRecordListVM
    {
        public string Department { get; set; }
        public string Municipality { get; set; }
        public string Zipcode { get; set; }
        public string Neighbourhood { get; set; }
        public string Key => Zipcode + Neighbourhood;
        public string DisplayText => $"{Zipcode} - {Neighbourhood}";
    }
}
