using System;

namespace Palindrome.Domain
 {
 public class Class1
 {
 static void Main(string[] args)
 {
 // Ask the user to enter a string
 // Reverse that string
 // Comparison
 
 string palindrome = string.Empty;
 Console.WriteLine("Enter string");
 palindrome = Console.ReadLine();
 
 char[] temp = palindrome.ToCharArray();
 Array.Reverse(temp);
 string b = new string(temp);
 
 if(a.ToLower().Equals(b.ToLower()))
 {
 Console.WriteLine("This is a palindrome");
 }
 else
 {
 Console.WriteLine("This is not a palindrome");
 }
 }
 }
 }