

using LeetCode;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("to print A B .... Ab,Ac,Ad....!");
//for (int i = 1; i < 200; i++)
//{
//    Console.WriteLine(LeetCode.GenerateExcelColumnsFromInteger.IntToLetters(i));
//}



//Console.WriteLine("minimum remove of characters to make two string anagaram !");

//Console.WriteLine(Anagram.CountDeletions("a", "ab"));
char[] digits = { '1', '2', '3', '4' };
int n = digits.Length;
Console.Write("Count is ");
Console.Write(PossibelDecodingDigits.countWays(digits, n));