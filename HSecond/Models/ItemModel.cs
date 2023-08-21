using System;

namespace HSecond.Models;

public class ItemModel : ICloneable
{
    #region Constructors

    private ItemModel(string varenummer, string produktnavn, string produktbeskrivelse, decimal salgspris,
        decimal indkøbspris, float lagerantal, ProduktEnhed produktenhed, bool hidden, DateTime? campaignEnd)
    {
        Varenummer = varenummer;
        Produktnavn = produktnavn;
        Produktbeskrivelse = produktbeskrivelse;
        Salgspris = salgspris;
        Indkøbspris = indkøbspris;
        Lagerantal = lagerantal;
        Produktenhed = produktenhed;
        Hidden = hidden;

        if (campaignEnd == null)
            CampaignEnd = DateTime.Now;
        else
            CampaignEnd = (DateTime)campaignEnd;
    }

    public ItemModel(string varenummer)
    {
        Varenummer = varenummer;
        Produktnavn = "";
        Produktbeskrivelse = "";
        Hidden = true;
        CampaignEnd = DateTime.Now;
    }

    #endregion

    #region Properties

    public string Varenummer { get; set; }
    public string Produktnavn { get; set; }
    public string Produktbeskrivelse { get; set; }
    public decimal Salgspris { get; set; }
    public decimal Indkøbspris { get; set; }
    public float Lagerantal { get; set; }
    public ProduktEnhed Produktenhed { get; set; }
    public bool Hidden { get; set; }
    public DateTime CampaignEnd { get; set; }

    #endregion

    public object Clone()
    {
        return new ItemModel(varenummer: Varenummer, produktnavn: Produktnavn, produktbeskrivelse: Produktbeskrivelse,
            salgspris: Salgspris, indkøbspris: Indkøbspris, lagerantal: Lagerantal, produktenhed: Produktenhed,
            hidden: Hidden, campaignEnd: CampaignEnd);
    }
}