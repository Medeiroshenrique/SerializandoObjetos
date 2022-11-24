using Serializando;
using Newtonsoft.Json;
using System.Collections.Generic;


string meujson =File.ReadAllText("Arquivos/listaserializada.json") ;
List<Pessoa> listaPessoa =JsonConvert.DeserializeObject<List<Pessoa>>(meujson) ;

foreach (Pessoa pessoa in listaPessoa) {
    Console.WriteLine($"Nome: {pessoa.Nome}\nSobrenome: {pessoa.Sobrenome}\nIdade: {pessoa.Idade}\n");
}
