Console.WriteLine("Exchange Rate ");
Console.WriteLine("Qiymat:");
string q = Console.ReadLine();
Console.WriteLine("Valyuta kursi (so'm):");
string c= Console.ReadLine();

decimal summ = Convert.ToDecimal(q)*Convert.ToDecimal(c);

Console.WriteLine($"Output: {summ} so'm");