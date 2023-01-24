int number = 770912734;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

List<char> typeOfNumbers = new List<char>();
typeOfNumbers.Add('0');
typeOfNumbers.Add('1');
typeOfNumbers.Add('2');
typeOfNumbers.Add('3');
typeOfNumbers.Add('4');
typeOfNumbers.Add('5'); 
typeOfNumbers.Add('6');
typeOfNumbers.Add('7');
typeOfNumbers.Add('8');
typeOfNumbers.Add('9');

Console.WriteLine(number);

foreach(var cypfer in typeOfNumbers) 
{
    int count = 0;
     foreach (var s in letters)
    {
        if (cypfer == s) count++;          
    }
             Console.WriteLine(cypfer + "=>" + count);
}   


   