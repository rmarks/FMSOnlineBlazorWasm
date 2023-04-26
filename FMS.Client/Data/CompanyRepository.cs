﻿using FMS.Client.Features.CompanyList;

namespace FMS.Client.Data;

public class CompanyRepository
{
    private List<CompanyListItemModel> _companies { get; set; } = new List<CompanyListItemModel>(
        new[]
        {
            new CompanyListItemModel("Paide Kaubamaja", "Eesti", "Paide"),
            new CompanyListItemModel("Türi Kaubamaja", "Eesti", "Türi"),
            new CompanyListItemModel("Rapla Kaubamaja", "Eesti", "Rapla"),
            new CompanyListItemModel("Pärnu Kaubamajakas", "Eesti", "Pärnu"),
            new CompanyListItemModel("Vana-Viru Ehtepood", "Eesti", "Tallinn"),
            new CompanyListItemModel("Võru TÜ", "Eesti", "Võru"),
            new CompanyListItemModel("Saaremaa TÜ", "Eesti", "Kuressaare"),
            new CompanyListItemModel("Peetri Kullaäri", "Eesti", "Viljandi"),
            new CompanyListItemModel("Põlva Ehtemaailm", "Eesti", "Põlva"),
            new CompanyListItemModel("Ilumaailm", "Eesti", "Tallinn"),
            new CompanyListItemModel("Ehtekaubamaja", "Eesti", "Tartu"),
            new CompanyListItemModel("Kullast süda", "Eesti", "Rakvere"),
        });

    public (List<CompanyListItemModel> List, int PageCount) GetPagedList(int page, int pageSize)
    {
        var list = _companies
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        int pageCount = (int)Math.Ceiling((decimal)_companies.Count / pageSize);

        return (list, pageCount);
    }
}