/* // sorting an Array alphabetically
string[] pallets ={"B14","A11","B12","A13"};
Console.WriteLine("Sorted ...");
Array.Sort(pallets);
foreach (var item in pallets)
{
    Console.WriteLine($"-- {item}");
}

//sorting an array in reverse
Console.WriteLine("");
Console.WriteLine("Reversed ...");
Array.Reverse(pallets);
foreach (var item in pallets)
{
    Console.WriteLine($"-- {item}");
}

// Removing an array item ,and checking for null type
Console.WriteLine("");
Console.WriteLine($"Before:{pallets[0].ToLower()}");
Array.Clear(pallets,0,2);
if (pallets[0] != null)
Console.WriteLine($"After:{pallets[0].ToLower()}");
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var item in pallets)
{
    Console.WriteLine($"-- {item}");
}

// Resizing an array
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing in 6 ... count:{pallets.Length}");

pallets[4]="C01";
pallets[5]="CO2";


foreach (var item in pallets)
{
    Console.WriteLine($"-- {item}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var item in pallets)
{
    Console.WriteLine($"-- {item}");
}



string value= "abc123";
char[] valuearray= value.ToCharArray();
Array.Reverse(valuearray);
//string result = new string(valuearray);
string result= String.Join(",",valuearray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

string pangram= "The quick brown fox jumps over the lazy dog";
                                                                   
string[] message= pangram.Split(' ');
string[] newmessage =new string[message.Length];
for (int i=0;i<message.Length;i++)
{
    char[] letters =message[i].ToCharArray();
    Array.Reverse(letters);
    newmessage[i]=new string(letters);

}
string result =string.Join(" ",newmessage);
Console.WriteLine(result);

// new challange

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string [] IncomingOrder= orderStream.Split(',');
Array.Sort(IncomingOrder);
foreach(var item in IncomingOrder)
{
  
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else 
    {   
    Console.WriteLine(item+"\t -Error");}
}

