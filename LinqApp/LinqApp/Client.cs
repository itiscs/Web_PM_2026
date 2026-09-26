using System;
using System.Collections.Generic;
using System.Text;

namespace LinqApp
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Age}";
        }

        public static List<Client> Clients()
        {
            return new List<Client>()
            {
                new Client { Id = 101, Name = "Ivan", Age = 20 },
                new Client { Id = 102, Name = "Anna", Age = 25 },
                new Client { Id = 103, Name = "Max", Age = 31 },
                new Client { Id = 104, Name = "Elena", Age = 19 },
                new Client { Id = 105, Name = "Artem", Age = 40 },
                new Client { Id = 106, Name = "Olga", Age = 28 },
                new Client { Id = 107, Name = "Dmitry", Age = 35 },
                new Client { Id = 108, Name = "Maria", Age = 22 },
                new Client { Id = 109, Name = "Pavel", Age = 45 },
                new Client { Id = 110, Name = "Sofia", Age = 27 }
            };
        }
    }
}
