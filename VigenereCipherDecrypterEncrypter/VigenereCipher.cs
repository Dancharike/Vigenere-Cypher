namespace VigenereCipherDecrypterEncrypter;

class VigenereCipher
{
    // ASCII symbols
    private static readonly char[] Alphabet = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~".ToCharArray();
    private static readonly int AlphabetSize = Alphabet.Length;

    // encryption method
    public static string Encrypt(string text, string key)
    {
        char[] encryptedText = new char[text.Length];
        int keyIndex = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            int charIndex = Array.IndexOf(Alphabet, currentChar);

            // if symbol belong to the alphabet
            // else leave the symbol if it is not in the alphabet
            if (charIndex != -1)
            {
                // indexes of entered text and key
                int keyCharIndex = Array.IndexOf(Alphabet, key[keyIndex % key.Length]);
                int encryptedCharIndex = (charIndex + keyCharIndex) % AlphabetSize;
                
                encryptedText[i] = Alphabet[encryptedCharIndex];
                keyIndex++;
            }
            else
            {
                encryptedText[i] = currentChar;
            }
        }

        return new string(encryptedText);
    }

    // decryption method
    public static string Decrypt(string encryptedText, string key)
    {
        char[] decryptedText = new char[encryptedText.Length];
        int keyIndex = 0;

        for (int i = 0; i < encryptedText.Length; i++)
        {
            char currentChar = encryptedText[i];
            int charIndex = Array.IndexOf(Alphabet, currentChar);

            if (charIndex != -1)
            {
                int keyCharIndex = Array.IndexOf(Alphabet, key[keyIndex % key.Length]);
                int decryptedCharIndex = (charIndex - keyCharIndex + AlphabetSize) % AlphabetSize;
                
                decryptedText[i] = Alphabet[decryptedCharIndex];
                keyIndex++;
            }
            else
            {
                decryptedText[i] = currentChar;
            }
        }

        return new string(decryptedText);
    }
}