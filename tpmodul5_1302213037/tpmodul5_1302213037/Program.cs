// See https://aka.ms/new-console-template for more information

using tpmodul5_1302213037;


Console.WriteLine("WELCOME TO TP MOD5\n");
Console.WriteLine("Silakan input Nama praktikan: ");
string x = Console.ReadLine();
HaloGeneric<string> User = new HaloGeneric<string>();
User.SapaUser(x);

Console.WriteLine("\nSilakan input NIM: ");
string NIM = Console.ReadLine();
DataGeneric<string> dataBaru = new DataGeneric<string>(NIM);
dataBaru.PrintData();

