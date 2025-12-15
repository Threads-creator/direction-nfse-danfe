using NReco.PdfGenerator;

namespace Direction.NFSe.Danfe;

public sealed class DanfePdfGenerator
{
    private readonly HtmlToPdfConverter _converter;

    public DanfePdfGenerator(HtmlToPdfConverter? converter = null)
    {
        _converter = converter ?? new HtmlToPdfConverter
        {
            Size = PageSize.A4,
            Orientation = PageOrientation.Portrait,
            Margins = new PageMargins { Top = 1, Bottom = 0, Left = 0, Right = 0 }
        };
    }

    public byte[] Generate(string html) => _converter.GeneratePdf(html);
}
