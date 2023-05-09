using FluentValidation;

namespace FMS.Client.Features.Company;

public class CompanyAddressModel
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public int? CompanyAddressTypeId { get; set; }
    public string Country { get; set; } = "";
    public string? County { get; set; }
    public string City { get; set; } = "";
    public string Address { get; set; } = "";
    public string? PostCode { get; set; }
    public string? Description { get; set; }
    public DateTime? CreatedOn { get; set; }

    public CompanyAddressModel GetCopy()
    {
        return new CompanyAddressModel
        {
            Id = Id,
            CompanyId = CompanyId,
            CompanyAddressTypeId = CompanyAddressTypeId,
            Country = Country,
            County = County,
            City = City,
            Address = Address,
            PostCode = PostCode,
            Description = Description,
        };
    }

    public void CopyTo(CompanyAddressModel dest)
    {
        dest.Id = Id;
        dest.CompanyId = CompanyId;
        dest.CompanyAddressTypeId = CompanyAddressTypeId;
        dest.Country = Country;
        dest.County = County;
        dest.City = City;
        dest.Address = Address;
        dest.PostCode = PostCode;
        dest.Description = Description;
    }
}

public class CompanyAddressModelValidator : AbstractValidator<CompanyAddressModel>
{
    public CompanyAddressModelValidator()
    {
        RuleFor(x => x.CompanyAddressTypeId).NotEmpty().WithMessage("Sisesta aadressi tüüp");
        RuleFor(x => x.Country).NotEmpty().WithMessage("Sisesta riik");
        RuleFor(x => x.City).NotEmpty().WithMessage("Sisesta linn");
        RuleFor(x => x.Address).NotEmpty().WithMessage("Sisesta aadress");
    }
}