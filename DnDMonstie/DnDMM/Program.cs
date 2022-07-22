using System;
using System.Net.Http;
using System.Text.Json;
using Spell.DTO;    





namespace DnDMM
{
    class Program
    {

        static async Task Main()
        {
            Console.WriteLine("Good Morning");

            var client = new HttpClient();

            string? uri = "https://api.open5e.com/spells/";
            string response = await client.GetStringAsync(uri);

            //Console.WriteLine(response);

            Spell.DTO.SpellList? spellList = JsonSerializer.Deserialize<Spell.DTO.SpellList>(response);

            int num = 1;

        foreach (var item in spellList.results)
            {
                Console.WriteLine(num + ": " + item.name);
                num++;
            }

        Console.ReadKey();

        }
    }
}
