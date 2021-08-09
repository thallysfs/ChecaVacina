using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
namespace ConsoleApp1
{
    //class MinhaLista<T> : IEnumerable<T>, ICollection<T>
    //{
    //    List<T> meu = new List<T>();
    //    public int Count => throw new NotImplementedException();

    //    public bool IsReadOnly => throw new NotImplementedException();

    //    public void Add(T item)
    //    {
    //        meu.Add(item);
    //    }

    //    public void Clear()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool Contains(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void CopyTo(T[] array, int arrayIndex)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<T> MeuWhere(Func<T, bool> predicate)
    //    {
    //        List<T> result = new List<T>();

    //        foreach(T f in meu)
    //        {
    //            if (predicate(f))
    //            {
    //                result.Add(f);
    //            }
    //        });

    //        return result;
    //    }

    //    public bool Remove(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Pessoa
    //{
    //    public int Id { get; set; }
    //    public string Nome { get; set; }
    //    public int Idade { get; set; }
    //}
    public class Configuration
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Smtp { get; set; }
        public int Port { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //lendo arquivo json e convertendo em obj
            JObject json = (JObject)JsonConvert.DeserializeObject(File.ReadAllText("Appsettings.json"));
            //convertendo o nó "configuration" para navegar no seu objeto
            Configuration config = ((JObject)json["Configuration"]).ToObject<Configuration>();
            Console.WriteLine($"Teste Password: {config.Password}");

         }
    }
}
