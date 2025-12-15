using Direction.NFSe.Danfe;
using Xunit;

namespace Danfe.Tests;

public class HelperTests
{
    [Fact]
    public void Limit_WhenNull_ReturnsEmpty()
    {
        string? s = null;
        Assert.Equal(string.Empty, Helper.Limit(s, 10));
    }

    [Fact]
    public void Limit_WhenLong_TruncatesAndAddsEllipsis()
    {
        var s = "um texto bem grande para ser cortado";
        var r = Helper.Limit(s, 10);
        Assert.EndsWith("...", r);
        Assert.True(r.Length <= 10);
    }

    [Fact]
    public void GetQrCode_ReturnsPngBytes()
    {
        var bytes = Helper.GetQrCode("teste", 10);
        Assert.True(bytes.Length > 10);
        Assert.Equal(0x89, bytes[0]);
        Assert.Equal(0x50, bytes[1]);
        Assert.Equal(0x4E, bytes[2]);
        Assert.Equal(0x47, bytes[3]);
    }
}
