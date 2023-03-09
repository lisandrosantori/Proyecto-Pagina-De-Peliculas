﻿namespace Peliculas.Extensiones
{
    public static class Extensiones
    {
        public static string JoinString<T>(this IEnumerable<T> source, Func<T, string> func)
        {
            return JoinString(source, ", ", func);
        }

        public static string JoinString<T>(this IEnumerable<T> source, string delimiter, Func<T, string> func)
        {
            return String.Join(delimiter, source.Select(func).ToArray());
        }
    }
}
