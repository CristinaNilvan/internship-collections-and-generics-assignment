using Project;

//Add
var myList = new GenericList<Ingredient>(20);

try
{
    myList.Add(new Ingredient(1, "lapte", 50));
    myList.Add(new Ingredient(2, "ou", 30));
    myList.Add(new Ingredient(3, "faina", 40));
    myList.Add(new Ingredient(4, "piersica", 10));
    myList.Add(new Ingredient(5, "rosie", 20));
}
catch (InvalidOperationException e)
{
    Console.WriteLine(e.Message);
}


//GetElement
Console.WriteLine("Initial elements: ");

try
{
    for (int i = 0; i < myList.Count; i++)
    {
        Console.WriteLine(myList.GetElementAt(i).Name);
    }
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();


//SetElement
Console.WriteLine("Set an element: ");

try
{
    myList.SetElementAt(4, new Ingredient(5, "banana", 20));
    for (int i = 0; i < myList.Count; i++)
    {
        Console.WriteLine(myList.GetElementAt(i).Name);
    }
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();


//Delete
Console.WriteLine("Elements after deletion of the last element: ");

try
{
    myList.Remove();
    for (int i = 0; i < myList.Count; i++)
    {
        Console.WriteLine(myList.GetElementAt(i).Name);
    }
}
catch (InvalidOperationException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();


//Swapt by index
Console.WriteLine("Elements after swapping 1: ");

try
{
    myList.SwapElements(2, 3);
    for (int i = 0; i < myList.Count; i++)
    {
        Console.WriteLine(myList.GetElementAt(i).Name);
    }
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();


//Swapt by items
Console.WriteLine("Elements after swapping 2: ");

var ingredient1 = new Ingredient(1, "lapte", 50);
var ingredient2 = new Ingredient(2, "ou", 30);

try
{
    myList.SwapElements(ingredient1, ingredient2);
    for (int i = 0; i < myList.Count; i++)
    {
        Console.WriteLine(myList.GetElementAt(i).Name);
    }
}
catch (NoMatchException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();


//Swap by index and item
Console.WriteLine("Elements after swapping 3: ");

var ingredient3 = new Ingredient(3, "faina", 40);

try
{
    myList.SwapElements(0, ingredient3);
    for (int i = 0; i < myList.Count; i++)
    {
        Console.WriteLine(myList.GetElementAt(i).Name);
    }
}
catch (NoMatchException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();