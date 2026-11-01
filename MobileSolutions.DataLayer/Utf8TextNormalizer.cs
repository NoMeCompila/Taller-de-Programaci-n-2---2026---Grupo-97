using System;
using System.Text;

namespace MobileSolutions.DataLayer
{
    /// <summary>
    /// Normaliza textos UTF-8 que hayan sufrido doble codificación (mojibake Windows-1252 / ISO-8859-1 -> UTF-8),
    /// como "sesiÃ³n" -> "sesión", "contraseÃ±a" -> "contraseña", "Ã¡" -> "á", "Â¿" -> "¿", etc.
    /// </summary>
    public static class Utf8TextNormalizer
    {
        private static readonly Encoding Latin1Encoding = Encoding.Latin1;
        private static readonly Encoding StrictUtf8Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        public static string Normalize(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input ?? string.Empty;
            }

            // Detectar marcadores típicos de secuencias UTF-8 de 2 bytes interpretadas como Latin-1/Windows-1252 (0xC3='Ã', 0xC2='Â')
            if (input.IndexOf('Ã') < 0 && input.IndexOf('Â') < 0)
            {
                return input;
            }

            try
            {
                byte[] rawBytes = Latin1Encoding.GetBytes(input);
                string decoded = StrictUtf8Encoding.GetString(rawBytes);
                if (!string.IsNullOrEmpty(decoded) && decoded.IndexOf('\uFFFD') < 0)
                {
                    return decoded;
                }
            }
            catch
            {
                // Si la cadena mezcla caracteres fuera de Latin-1, aplicar reemplazo puntual seguro
            }

            return input
                .Replace("Ã¡", "á")
                .Replace("Ã©", "é")
                .Replace("Ã­", "í")
                .Replace("Ã³", "ó")
                .Replace("Ãº", "ú")
                .Replace("Ã±", "ñ")
                .Replace("Ã\u0081", "Á")
                .Replace("Ã‰", "É")
                .Replace("Ã\u008D", "Í")
                .Replace("Ã“", "Ó")
                .Replace("Ãš", "Ú")
                .Replace("Ã‘", "Ñ")
                .Replace("Ã¼", "ü")
                .Replace("Ãœ", "Ü")
                .Replace("Â¿", "¿")
                .Replace("Â¡", "¡")
                .Replace("Â°", "°")
                .Replace("Âº", "º");
        }

        public static string? NormalizeNullable(string? input)
        {
            if (input is null)
            {
                return null;
            }

            return Normalize(input);
        }
    }
}
