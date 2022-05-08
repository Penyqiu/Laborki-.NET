// See https://aka.ms/new-console-template for more information

List<int> lista = new List<int>();
lista.Add(1);
lista.Add(3);

for (int i = 0; i < lista.Count; i++)
{
    if (lista[i]%3==0)
    {
        Console.WriteLine(lista[i]);
    }
}
return -1;