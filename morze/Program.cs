using morze;

List<morzeB> morzebetu = new List<morzeB>();
StreamReader sr = new StreamReader("morzeabc.txt");
sr.ReadLine();
while (!sr.EndOfStream)
{
    string[] adat = sr.ReadLine().Split("\t");
    morzebetu.Add(new morzeB(adat[0], adat[1]));
}
sr.Close();


Console.WriteLine($"3. feladat: A morze abc{morzebetu.Count()} db kódját tartalmazza.");
Console.Write("4. feladat: Kérek egy karaktert: ");
string betu = Console.ReadLine();
Console.WriteLine($"A {betu} karakter morze kódja: {morzebetu.Where(x => x.MorzeBetu == betu).First().MorzeKod}".PadLeft(40));

List<morzeI> morzeidezet = new List<morzeI>();
StreamReader srr = new StreamReader("morze.txt");
srr.ReadLine();
while (!srr.EndOfStream)
{
    string[] adat = srr.ReadLine().Split(';');
    morzeidezet.Add(new morzeI(adat[0], adat[1]));
}
srr.Close();

