using LinqApp;

//var mas = new int[] { 1, 2, -5, 3, 4,-8,  5, 6, 7, 8, 9, 10 };

//foreach (var k in mas)
//    Console.WriteLine(k);

//Console.WriteLine("********************************");

//var m = mas.Where(x => x > 0).Where(x => x % 3 != 0)
//    .OrderBy(x => -x).Skip(2);//.Average();//.Take(3);

////Console.WriteLine(m);

//foreach (var k in m)
//    Console.WriteLine(k);

Console.WriteLine("********************************");

var lst = Fitness.GetClients();

foreach (var c in lst.Where(c=>c.Year==2026)
    .OrderByDescending(c=>c.Hours) )
    Console.WriteLine(c);


Console.WriteLine(lst.Average(c => c.Hours));

Console.WriteLine("********************************");

var cl = Client.Clients();
foreach (var c in cl.Select(s => s.Name).OrderBy(s => s[s.Length-1]))
    Console.WriteLine(c);

Console.WriteLine(cl.FirstOrDefault(c => c.Age == 27));

//foreach (var c in cl.Select(s => new { s.Name, s.Age, Even = s.Age%2==0 }).OrderBy(a=>a.Age).ThenBy(a=>a.Name)  )
//    Console.WriteLine(c);

//Console.WriteLine("********************************");


////var gr = lst.GroupBy(f => f.Year).Select(g => new { g.Key, Cnt = g.Count(), Av = g.Average(f=>f.Hours)});

//var gr = lst.GroupBy(f => f.IdClient).Select(g => new { g.Key, Sum = g.Sum(f => f.Hours) })
//    .OrderByDescending(g=>g.Sum);

//foreach (var g in gr)
//{
//    Console.WriteLine(g);
//}

Console.WriteLine("*****************************************");

var lst1 = lst.Join(cl, f => f.IdClient, c => c.Id,
    (f, c) => new { c.Name, c.Age, f.Month, f.Year, f.Hours })
    .GroupBy(f => new { f.Name, f.Year })
    .Select(g => new
    {
        g.Key.Year,
        g.Key.Name,
        Sum = g.Sum(f => f.Hours),
        Max = g.Max(f => f.Hours)
    })
    .OrderBy(g => g.Year).ThenByDescending(g => g.Max);

foreach(var el in lst1)
{
    Console.WriteLine(el);
}









