using System;
using System.Globalization;

namespace Direction.NFSe.Danfe;

internal static class DanfeFallback
{
    public static string OrDash(
        string? value,
        DanfeWarningCollector warnings,
        string fieldName,
        string? path = null)
    {
        if (!string.IsNullOrWhiteSpace(value))
            return value!;

        warnings.FieldMissing(fieldName, path, "-");
        return "-";
    }
    public static string OrDash(
    string? value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            return value!;

        return "-";
    }

    public static string OrCurrency(
        decimal? value,
        CultureInfo culture,
        DanfeWarningCollector warnings,
        string fieldName,
        string? path = null)
    {
        if (value.HasValue)
            return value.Value.ToString("C", culture);

        warnings.FieldMissing(fieldName, path, "-");
        return "-";
    }

    public static string OrPercent(
        decimal? value,
        CultureInfo culture,
        DanfeWarningCollector warnings,
        string fieldName,
        string? path = null)
    {
        if (value.HasValue)
            return $"{value.Value.ToString("N2", culture)}%";

        warnings.FieldMissing(fieldName, path, "-");
        return "-";
    }

    public static string OrValue<T>(
        T? value,
        Func<T, string> formatter,
        DanfeWarningCollector warnings,
        string fieldName,
        string fallback,
        string? path = null)
        where T : struct
    {
        if (value.HasValue)
            return formatter(value.Value);

        warnings.FieldMissing(fieldName, path, fallback);
        return fallback;
    }
}
