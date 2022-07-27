using Project;

var myList = new GenericList<Ingredient>(20);

myList.Add(new Ingredient(1, "lapte", 50));
myList.Add(new Ingredient(2, "ou", 30));
myList.Add(new Ingredient(3, "faina", 40));
myList.Add(new Ingredient(4, "piersica", 10));
myList.Add(new Ingredient(5, "rosie", 20));

Console.WriteLine("Initial elements: ");

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList.GetElementAt(i).Name);
}

Console.WriteLine();


Console.WriteLine("Elements after deletion of the last element: ");

myList.Remove();
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList.GetElementAt(i).Name);
}

Console.WriteLine();


Console.WriteLine("Elements after swapping 1: ");

myList.SwapElements(2, 3);
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList.GetElementAt(i).Name);
}

Console.WriteLine();


Console.WriteLine("Elements after swapping 2: ");

var ingredient1 = new Ingredient(1, "lapte", 50);
var ingredient2 = new Ingredient(2, "ou", 30);

myList.SwapElements(ingredient1, ingredient2);
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList.GetElementAt(i).Name);
}

Console.WriteLine();


Console.WriteLine("Elements after swapping 3: ");

var ingredient3 = new Ingredient(3, "faina", 40);

myList.SwapElements(0, ingredient3);
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList.GetElementAt(i).Name);
}

Console.WriteLine();