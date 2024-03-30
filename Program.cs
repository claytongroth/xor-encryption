using System;

namespace XOR_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            string textToPrint = "Hi Dood!";

            // Example usage of your encryption algorithm
            byte[] encryptedBytes = EncryptText.Encrypt(textToPrint);
            Console.WriteLine("Original Character | Encrypted Bytes (Binary):");
            for (int i = 0; i < textToPrint.Length; i++)
            {
                char originalChar = textToPrint[i];
                byte encryptedByte = encryptedBytes[i];
                
                Console.WriteLine(originalChar + " | " + Convert.ToString(encryptedByte, 2).PadLeft(8, '0'));
            }
        }
    }
}
