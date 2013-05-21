// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace AIRLab.CA.Tools
{
    public static class Helper
    {
        private static readonly Random Random = new Random((int)DateTime.Now.Ticks);

        public static double Round(this double number, int frac)
        {
            return Math.Round(number, frac);
        }

        public static int IndexOf<T>(this IEnumerable<T> obj, T value)
        {
            return obj
                .Select((a, i) => (a.Equals(value)) ? i : -1)
                .Max();
        }

        public static int GetInt(int module)
        {
            return Random.Next() % module;
        }

        public static double GetDouble()
        {
            return Random.NextDouble();
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var i in enumerable)
            {
                action(i);
            }
        }

        public static IEnumerable<double> Range(double min, double max, double step)
        {
            for (double c = min; c <= max; c += step)
                yield return c;
        }

        public static T Copy<T>(this T source)
        {

            if (source.Equals(default(T)))
                return default(T);

            var formatter = new BinaryFormatter();
            var stream = new MemoryStream();

            using (stream)
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }

        public static T Clone<T>(this T source) 
            where T : ICloneable
        {
            return (T)source.Clone();
        }

        public static string CleanTypeName(this Type type)
        {
            var name = type.Name;
            return !type.IsGenericType
                       ? name
                       : name.Remove(name.IndexOf('`'));
        }

        public static void AddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
        {
            foreach (var item in collection)
            {
                if (!source.ContainsKey(item.Key))
                {
                    source.Add(item.Key, item.Value);
                }
            }
        }
    }
}