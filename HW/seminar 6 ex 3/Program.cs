//Проверка строки на палиндром

string input = "шалаш";
Console.WriteLine(isPalindrome ? "Да" : "Нет");

{
    string normalized = new
    string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
}

