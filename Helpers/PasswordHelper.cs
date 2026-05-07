using System.Security.Cryptography;
using System.Text;

namespace SalesAnalytics.Helpers;

public static class PasswordHelper
{
    private static string ComputeSha256(string value, Encoding encoding)
    {
        var bytes = encoding.GetBytes(value);
        var hashBytes = SHA256.HashData(bytes);
        var builder = new StringBuilder(hashBytes.Length * 2);
        foreach (var b in hashBytes)
        {
            builder.Append(b.ToString("x2"));
        }

        return builder.ToString();
    }

    private static string ComputeMd5(string value, Encoding encoding)
    {
        var bytes = encoding.GetBytes(value);
        var hashBytes = MD5.HashData(bytes);
        var builder = new StringBuilder(hashBytes.Length * 2);
        foreach (var b in hashBytes)
        {
            builder.Append(b.ToString("x2"));
        }

        return builder.ToString();
    }

    public static bool VerifyWithSalt(string password, string salt, string expectedHash)
    {
        if (string.IsNullOrWhiteSpace(expectedHash))
        {
            return false;
        }

        var normalizedExpected = expectedHash.Trim();
        var shaPassword = ComputeSha256(password, Encoding.UTF8);

        string[] candidates =
        [
            // Common variants: sha256(salt + password), sha256(password + salt)
            ComputeSha256($"{salt}{password}", Encoding.UTF8),
            ComputeSha256($"{password}{salt}", Encoding.UTF8),
            // Double hash variants
            ComputeSha256($"{salt}{shaPassword}", Encoding.UTF8),
            ComputeSha256($"{shaPassword}{salt}", Encoding.UTF8),
            // Legacy encoding variants
            ComputeSha256($"{salt}{password}", Encoding.Unicode),
            ComputeSha256($"{password}{salt}", Encoding.Unicode),
            // Some учебные проекты mistakenly used MD5 with salt
            ComputeMd5($"{salt}{password}", Encoding.UTF8),
            ComputeMd5($"{password}{salt}", Encoding.UTF8)
        ];

        return candidates.Any(c => c.Equals(normalizedExpected, StringComparison.OrdinalIgnoreCase));
    }
}
