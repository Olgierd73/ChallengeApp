int number = 777907777;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

List<char> typeOfNumbers = new List<char>
{'0','1','2','3','4','5','6','7','8','9'};

Console.WriteLine(number);

foreach(var cypfer in typeOfNumbers)
{
    int count = 0;
     foreach (var s in letters)
    {
        if (cypfer == s)
        {
            count++;
        }
    }
             Console.WriteLine(cypfer + "=>" + count);
}   

   