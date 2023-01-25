int number = 1000000000;
string numberInString = number.ToString();//liczbę zamienia na symbole literowe na nią się składające
char[] letters = numberInString.ToArray();// tworzy tablice z symboli -cyfr -tworzących liczbe -number

List<char> typeOfNumbers = new List<char> // określa szuflady  na liście rozdzielonych na cyfry liczb
{'0','1','2','3','4','5','6','7','8','9'};

Console.WriteLine(number);// pokazuje badaną liczbę

foreach(var cypfer in typeOfNumbers)  //tworzy pętlę z listy podanych cyfr
{
    int count = 0;                 // pętla startuje od 0 
    foreach (var s in letters)     //tworzy drugą pętle z tablicy cyfr
    {                               //z listy okreslonej warunkiem if
        if (cypfer == s)             // "jeśli" wśród  listy cyfr sa takie same 
        {
            count++;             // "to" wynikiem jest s + 1, pokazuje ilości takich samych cyfr w danej liczbie np dwa 0 to 0+1+1
        }
    }
             Console.WriteLine(cypfer + "=>" + count); //pokazuje pętlę pierwsza (rozłozone na znaki cyfry) i drugą (
}

