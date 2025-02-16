namespace VigenereCipherDecrypterEncrypter;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the text for encrypting: ");
        string text = Console.ReadLine();

        Console.WriteLine("Enter the key: ");
        string key = Console.ReadLine();

        // encrypting
        string encryptedText = VigenereCipher.Encrypt(text, key);
        Console.WriteLine($"Encrypted text is: {encryptedText}");

        // decrypting
        string decryptedText = VigenereCipher.Decrypt(encryptedText, key);
        Console.WriteLine($"Decrypted text is: {decryptedText}");
    }
}