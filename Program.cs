Console.Clear();
string[] arr = { "hello", "2", "World", "-2", "elf", "else", "if", "other", "bish bash bosh" };
Console.WriteLine($"Изначальный массив: [ {string.Join(", ", arr)} ]");
Console.Write("Введите максимальное количество символов в строке: ");
int symbols = Convert.ToInt32(Console.ReadLine());
List<string> newArr = new List<string>();
for (int i = 0; i < arr.Length; i++)
{
   if (arr[i].Length <= symbols)
   {
      newArr.Add(arr[i]);
   }
}
Console.Write("Итоговый массив: " + "[\"" + string.Join("\", \"", newArr) + "\"]");