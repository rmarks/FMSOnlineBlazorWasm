using FluentValidation;

namespace FMS.Client.Features.Company;

public class CompanyModel
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string RegNo { get; set; } = "";
    public string? VATNo { get; set; }
    public string? DeliveryTermName { get; set; }
    public int PaymentDays { get; set; }
    public int FixedDiscountPercent { get; set; }
    public bool IsVAT { get; set; }
    public DateTime? CreatedOn { get; set; }

    public CompanyModel GetCopy()
    {
        return new CompanyModel
        {
            Id = this.Id,
            Name = this.Name,
            RegNo = this.RegNo,
            VATNo = this.VATNo,
            DeliveryTermName = this.DeliveryTermName,
            PaymentDays = this.PaymentDays,
            FixedDiscountPercent = this.FixedDiscountPercent,
            IsVAT = this.IsVAT,
            CreatedOn = this.CreatedOn,
        };
    }

    public void CopyTo(CompanyModel dest)
    {
        dest.Id = this.Id;
        dest.Name = this.Name;
        dest.RegNo = this.RegNo;
        dest.VATNo = this.VATNo;
        dest.DeliveryTermName = this.DeliveryTermName;
        dest.PaymentDays = this.PaymentDays;
        dest.FixedDiscountPercent = this.FixedDiscountPercent;
        dest.IsVAT = this.IsVAT;
        dest.CreatedOn = this.CreatedOn;
    }
}

public class CompanyModelValidator : AbstractValidator<CompanyModel>
{
    public CompanyModelValidator()
    {
        RuleFor(c => c.Name).NotEmpty().WithMessage("Sisesta nimi");
        RuleFor(c => c.RegNo).NotEmpty().WithMessage("Sisesta reg. nr.");
        RuleFor(c => c.PaymentDays).GreaterThanOrEqualTo(0).WithMessage("Sisesta sobiv makseaeg");
        RuleFor(c => c.FixedDiscountPercent).GreaterThanOrEqualTo(0).WithMessage("Sisesta sobiv protsent");
    }
}
