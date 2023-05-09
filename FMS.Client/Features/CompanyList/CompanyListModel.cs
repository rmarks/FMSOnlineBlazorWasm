namespace FMS.Client.Features.CompanyList;

public class CompanyListModel
{
    public IEnumerable<CompanyListItemModel> PagedList { get; set; } = default!;
    public int PageCount { get; set; }
}

public record CompanyListItemModel(int Id, string CompanyName, string Country, string City);
