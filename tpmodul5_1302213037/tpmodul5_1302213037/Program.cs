// See https://aka.ms/new-console-template for more information
using tpmodul5_1302213037;

Console.WriteLine("WELCOME TO TP MOD5\n");
Console.WriteLine("Silakan input NIM: ");
string NIM = Console.ReadLine();
DataGeneric<string> dataBaru = new DataGeneric<string>(NIM);
dataBaru.PrintData();

