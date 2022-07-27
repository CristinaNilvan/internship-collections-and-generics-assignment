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