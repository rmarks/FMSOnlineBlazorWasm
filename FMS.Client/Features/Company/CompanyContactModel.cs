namespace FMS.Client.Features.Company;

public class CompanyContactModel
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string Name { get; set; } = "";
    public string Job { get; set; } = "";
    public string Mobile { get; set; } = "";
    public string? Phone { get; set; }
    public string? Email { get; set; } 

    public CompanyContactModel GetCopy()
    {
        return new CompanyContactModel 
        {
            Id = Id,
            CompanyId = CompanyId, 
            Name = Name, 
            Job = Job, 
            Mobile = Mobile, 
            Phone = Phone,
            Email = Email
        };
    }

    public void CopyTo(CompanyContactModel contact)
    {
        contact.Id = Id;
        contact.CompanyId = CompanyId;
        contact.Name = Name;
        contact.Job = Job;
        contact.Mobile = Mobile;
        contact.Phone = Phone;
        contact.Email = Email;
    }
}
