void PrintArray(string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write (arr[i] + "   ");
    }
    Console.WriteLine();
}
string [] arr = new string [] {"1234", "1567", "-2", "Computer science", "555"};
string [] mass = new string [arr.Length];
void FillMass (string[] arr, string [] mass)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            mass[count] = arr[i];
            count++;
        }
    }
}
FillMass(arr, mass);
PrintArray(mass);