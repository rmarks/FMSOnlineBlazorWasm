using FMS.Client.Features.Company;
using FMS.Client.Features.CompanyList;

namespace FMS.Client.Data;

public class CompanyRepository
{
    private List<CompanyModel> _companies = new List<CompanyModel>(new[]
        {
            new CompanyModel
            {
                Id = 1, Name = "Rapla Kullapood", RegNo = "111", VATNo = "1111111", 
                DeliveryTermName = "CIF Rapla", PaymentDays = 30, FixedDiscountPercent = 2, IsVAT = true, CreatedOn = DateTime.Now
            },
            new CompanyModel
            {
                Id = 2, Name = "Vana-Viru Ehtepood", RegNo = "222", VATNo = "2222222",
                DeliveryTermName = "CIF Tallinn", PaymentDays = 40, FixedDiscountPercent = 1, IsVAT = true, CreatedOn = DateTime.Now
            },
            new CompanyModel
            {
                Id = 3, Name = "Keila Rõõmukaubamaja", RegNo = "333", VATNo = "23423424",
                DeliveryTermName = "CIF Keila", PaymentDays = 60, FixedDiscountPercent = 3, IsVAT = true, CreatedOn = DateTime.Now
            },
            new CompanyModel
            {
                Id = 4, Name = "Paide Kaubamaja", RegNo = "112", VATNo = "4564564565",
                DeliveryTermName = "CIF Paide", PaymentDays = 30, FixedDiscountPercent = 2, IsVAT = true, CreatedOn = DateTime.Now
            },
            new CompanyModel
            {
                Id = 5, Name = "Türi Kaubamaja", RegNo = "122", VATNo = "3464564564",
                DeliveryTermName = "CIF Türi", PaymentDays = 50, FixedDiscountPercent = 1, IsVAT = true, CreatedOn = DateTime.Now            },
            new CompanyModel
            {
                Id = 6, Name = "Rocca Ehted", RegNo = "211", VATNo = "678567567",
                DeliveryTermName = "CIF Tallinn", PaymentDays = 20, FixedDiscountPercent = 0, IsVAT = true, CreatedOn = DateTime.Now
            },
            new CompanyModel
            {
                Id = 7, Name = "Paldiski Kullakeskus", RegNo = "311", VATNo = "2343453454",
                DeliveryTermName = "CIF Paldiski", PaymentDays = 10, FixedDiscountPercent = 1, IsVAT = true, CreatedOn = DateTime.Now,
            },
            new CompanyModel
            {
                Id = 8, Name = "Põlva TÜ", RegNo = "312", VATNo = "6756756775",
                DeliveryTermName = "CIF Põlva", PaymentDays = 30, FixedDiscountPercent = 2, IsVAT = true, CreatedOn = DateTime.Now,
            },
            new CompanyModel
            {
                Id = 9, Name = "Võru TÜ", RegNo = "321", VATNo = "456567567567",
                DeliveryTermName = "CIF Võru", PaymentDays = 30, FixedDiscountPercent = 2, IsVAT = true, CreatedOn = DateTime.Now,
            },
            new CompanyModel
            {
                Id = 10, Name = "Juveliir", RegNo = "223", VATNo = "345345345",
                DeliveryTermName = "CIF Tallinn", PaymentDays = 30, FixedDiscountPercent = 1, IsVAT = true, CreatedOn = DateTime.Now,
            },
            new CompanyModel
            {
                Id = 11, Name = "Ilumaailm", RegNo = "233", VATNo = "95954034",
                DeliveryTermName = "CIF Tallinn", PaymentDays = 60, FixedDiscountPercent = 5, IsVAT = true, CreatedOn = DateTime.Now,
            },
            new CompanyModel
            {
                Id = 12, Name = "Tapa Ehe", RegNo = "333", VATNo = "23345465647",
                DeliveryTermName = "CIF Tapa", PaymentDays = 30, FixedDiscountPercent = 2, IsVAT = true, CreatedOn = DateTime.Now,
            }
        });

    private List<CompanyAddressModel> _companyAddresses = new List<CompanyAddressModel>(new[]
    {
        new CompanyAddressModel 
        { 
            Id = 1, CompanyId = 1, CompanyAddressTypeId = 1, Country = "Eesti", County = "Rapla maakond", City = "Rapla", Address = "Vase 3", PostCode = "2765",
            //CompanyAddressType = _companyAddressTypes.First(cat => cat.Code == "PA")
        },
        new CompanyAddressModel 
        {
            Id = 2, CompanyAddressTypeId = 1, CompanyId = 2, Country = "Eesti", County = "Harjumaa", City = "Tallinn", Address = "Vana-Viru 7", PostCode = "4327"
        },
        new CompanyAddressModel 
        {
            Id = 3, CompanyAddressTypeId = 1, CompanyId = 3, Country = "Eesti", County = "Harjumaa", City = "Keila", Address = "Kalda 15", PostCode = "4327"
        },
        new CompanyAddressModel 
        {
            Id = 4, CompanyAddressTypeId = 1, CompanyId = 4, Country = "Eesti", County = "Järvamaa", City = "Paide", Address = "Ringtee 2", PostCode = "2674"
        },
        new CompanyAddressModel 
        {
            Id = 5, CompanyAddressTypeId = 1, CompanyId = 5, Country = "Eesti", County = "Järvamaa", City = "Türi", Address = "Tallinna 3", PostCode = "2674"
        },
        new CompanyAddressModel 
        {
            Id = 6, CompanyAddressTypeId = 1, CompanyId = 6, Country = "Eesti", County = "Harjumaa", City = "Tallinn", Address = "Vabaõhumuuseumi tee 46", PostCode = "4327"
        },
        new CompanyAddressModel 
        {
            Id = 7, CompanyAddressTypeId = 1, CompanyId = 7, Country = "Eesti", County = "Harjumaa", City = "Paldiski", Address = "Pikk 23", PostCode = "4327"
        },
        new CompanyAddressModel 
        {
            Id = 8, CompanyAddressTypeId = 1, CompanyId = 8, Country = "Eesti", County = "Põlvamaa", City = "Põlva", Address = "Palgi 4", PostCode = "1823"
        },
        new CompanyAddressModel 
        {
            Id = 9, CompanyAddressTypeId = 1, CompanyId = 9, Country = "Eesti", County = "Võrumaa", City = "Võru", Address = "Tamme 21", PostCode = "2773"
        },
        new CompanyAddressModel 
        {
            Id = 10, CompanyAddressTypeId = 1, CompanyId = 10, Country = "Eesti", County = "Harjumaa", City = "Tallinn", Address = "Vene 13", PostCode = "4327"
        },
        new CompanyAddressModel 
        {
            Id = 11, CompanyAddressTypeId = 1, CompanyId = 11, Country = "Eesti", County = "Harjumaa", City = "Tallinn", Address = "Pärnu mnt. 67", PostCode = "4327"
        },
        new CompanyAddressModel 
        {
            Id = 12, CompanyAddressTypeId = 1, CompanyId = 12, Country = "Eesti", County = "Lääne-Virumaa", City = "Tapa", Address = "u 11", PostCode = "3696"
        }
    });

    private List<CompanyContactModel> _companyContacts = new List<CompanyContactModel>(new[]
    {
        new CompanyContactModel { Id = 1, CompanyId = 11, Name = "Milvi Tigu", Job = "juhataja", Mobile = "5534678", Email = "milvi@hot.ee" },
        new CompanyContactModel { Id = 2, CompanyId = 11, Name = "Pilvi Tõru", Job = "müüja", Mobile = "5145578", Email = "pilvi@hot.ee" },
        new CompanyContactModel { Id = 3, CompanyId = 10, Name = "Mati Sammal", Job = "direktor", Mobile = "5566123", Phone = "6512389", Email = "mati.sammal@gmail.com" },
        new CompanyContactModel { Id = 4, CompanyId = 10, Name = "Silvi Laugas", Job = "müüja", Mobile = "5245565", Email = "silvi@hotmail.com" }
    });

    private IEnumerable<CompanyAddressTypeModel> _companyAddressTypes = new List<CompanyAddressTypeModel>(new[]
    {
        new CompanyAddressTypeModel { Id = 1, Code = "PA", Name = "Põhiaadress" },
        new CompanyAddressTypeModel { Id = 2, Code = "SA", Name = "Saaja aadress" }
    });

    public CompanyListModel GetPagedList(string searchString, int page, int pageSize)
    {
        var query = _companies
            .Where(c => c.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            .OrderBy(c => c.Name);

        int pageCount = (int)Math.Ceiling((decimal)query.Count() / pageSize);

        var list = query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .GroupJoin(
                _companyAddresses.Where(a => a.CompanyAddressTypeId == _companyAddressTypes.First(cat => cat.Code == "PA").Id), 
                c => c.Id, 
                ca => ca.CompanyId, 
                (c, ca) => new { company = c, addresses = ca })
            .SelectMany(r => r.addresses.DefaultIfEmpty(),
                (r, ca) => new CompanyListItemModel(
                r.company.Id,
                r.company.Name,
                ca?.City ?? "",
                ca?.Country ?? ""
                ))
            .ToList();

        return new CompanyListModel { PagedList = list, PageCount = pageCount };
    }

    public CompanyModel? GetCompany(int id)
    {
        var company = _companies.FirstOrDefault(c => c.Id == id);

        return company?.GetCopy() ?? null;
    }

    public int AddCompany(CompanyModel company)
    {
        var newCompany = company.GetCopy();

        newCompany.Id = _companies.Count + 1;
        _companies.Add(newCompany);

        return newCompany.Id;
    }

    public bool UpdateCompany(CompanyModel company)
    {
        var existingCompany = _companies.FirstOrDefault(c => c.Id == company.Id);

        if (existingCompany is null) return false;

        company.CopyTo(existingCompany);
        
        return true;
    }

    public bool DeleteCompany(int companyId)
    {
        _companies.RemoveAll(c => c.Id == companyId);
        _companyAddresses.RemoveAll(ca => ca.CompanyId == companyId);
        _companyContacts.RemoveAll(cc => cc.CompanyId == companyId);

        return true;
    }

    public IList<CompanyAddressListItemModel> GetAddressesByCompanyId(int companyId)
    {
        return _companyAddresses
            .Where(ca => ca.CompanyId == companyId)
            .Join(
                _companyAddressTypes,
                ca => ca.CompanyAddressTypeId,
                cat => cat.Id,
                (ca, cat) => new CompanyAddressListItemModel
                {
                    Id = ca.Id,
                    CompanyAddressTypeName = cat.Name,
                    FullAddress = string.Join(", ",(new[] { ca.Country, ca.County, ca.City, ca.Address, ca.PostCode }).Where(s => !string.IsNullOrWhiteSpace(s))),
                    Description = ca.Description
                })
            .ToList();
    }

    public CompanyAddressModel? GetAddressById(int id)
    {
        return _companyAddresses .FirstOrDefault(ca => ca.Id == id);
    }

    public bool UpdateAddress(CompanyAddressModel address)
    {
        var existingAddress = _companyAddresses.FirstOrDefault(ca => ca.Id == address.Id);

        if (existingAddress is null) return false;

        address.CopyTo(existingAddress);

        return true;
    }

    public int AddAddress(CompanyAddressModel address)
    {
        var newAddress = address.GetCopy();
        newAddress.Id = _companyAddresses.Count + 1;
        _companyAddresses.Add(newAddress);
        
        return newAddress.Id;
    }

    public bool DeleteAddress(int addressId)
    {
        var existingAddress = _companyAddresses.FirstOrDefault(ca => ca.Id == addressId);
        if (existingAddress is null) return false;
        
        _companyAddresses.Remove(existingAddress);
        
        return true;
    }

    public IList<CompanyContactModel> GetContactsByCompanyId(int companyId)
    {
        return _companyContacts
            .Where(ca => ca.CompanyId == companyId)
            .ToList();
    }

    public bool UpdateContact(CompanyContactModel contact)
    {
        var existingContact = _companyContacts.FirstOrDefault(cc => cc.Id == contact.Id);

        if (existingContact is null) return false;

        contact.CopyTo(existingContact);

        return true;
    }

    public int AddContact(CompanyContactModel contact)
    {
        var newContact = contact.GetCopy();
        newContact.Id = _companyContacts.Count + 1;
        _companyContacts.Add(newContact);

        return newContact.Id;
    }

    public bool DeleteContact(int contactId)
    {
        var existingContact = _companyContacts.FirstOrDefault(cc => cc.Id == contactId);
        if (existingContact is null) return false;

        _companyContacts.Remove(existingContact);

        return true;
    }

    public IEnumerable<CompanyAddressTypeModel> GetAllAddressTypes()
    {
        return _companyAddressTypes;
    }
}
