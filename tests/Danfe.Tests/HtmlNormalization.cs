using System.Text.RegularExpressions;

internal static class HtmlNormalization
{
    public static string Normalize(string html)
    {
        if (string.IsNullOrWhiteSpace(html)) return string.Empty;

        // Normalizações típicas:
        html = html.Replace("\r\n", "\n");

        // Remove whitespace redundante entre tags (ajuda muito snapshot)
        html = Regex.Replace(html, @">\s+<", "><");

        // Reduz múltiplos espaços
        html = Regex.Replace(html, @"[ \t]{2,}", " ");

        // Se tiver base64 muito variável:
        // html = Regex.Replace(html, "data:image/png;base64,[A-Za-z0-9+/=]+", "data:image/png;base64,<redacted>");

        return html.Trim();
    }
}
