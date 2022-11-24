using Serializando;
using Newtonsoft.Json;
using System.Collections.Generic;

//CRIANDO LISTA PARA SERIALIZAR DEPOIS
List<Pessoa> listaPessoa=new List<Pessoa>();
Pessoa alguem1 = new Pessoa("Henrique","Medeiros",21);
Pessoa jurema2 = new Pessoa("Jurema","Preta",87);
Pessoa abraao3 = new Pessoa("Jucelino", "Catingueira", 100);
listaPessoa.Add(alguem1);
listaPessoa.Add(jurema2);
listaPessoa.Add(abraao3);

//SERIALIZANDO PARA JSON
string meujson = JsonConvert.SerializeObject(listaPessoa, Formatting.Indented);
File.WriteAllText("Arquivos/listaserializada.json",meujson);
foreach (Pessoa pessoa in listaPessoa) {
    Console.WriteLine($"Nome:{pessoa.Nome}\nSobrenome:{pessoa.Sobrenome}\nIdade:{pessoa.Idade}");
    Console.WriteLine();
}
