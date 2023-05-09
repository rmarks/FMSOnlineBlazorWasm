namespace FMS.Client.Features.Company;

public class CompanyAddressListItemModel
{
    public int Id { get; set; }
    public string CompanyAddressTypeName { get; set; } = "";
    public string FullAddress { get; set; } = "";
    public string? Description { get; set; }
}