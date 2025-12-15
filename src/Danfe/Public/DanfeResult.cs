using System;
using System.Collections.Generic;

namespace Direction.NFSe.Danfe;

public sealed class DanfeResult
{
    public DanfeEnvironment Environment { get; init; }
    public string Html { get; init; } = string.Empty;
    public byte[] PdfBytes { get; init; } = Array.Empty<byte>();
    public IReadOnlyList<DanfeWarning> Warnings { get; init; } = Array.Empty<DanfeWarning>();
}
