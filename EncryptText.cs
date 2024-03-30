using System.Text;

namespace XOR_Encryption
{
    public static class EncryptText
    {
        private static char keyCharacter = 'K'; // Initialize with 'K' as an example

        public static byte[] GetBytesFromASCII(char c)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(new char[] { c });
            return bytes;
        }

        // Method to print byte array
        // Method to print byte array in binary format
        static void PrintByteArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.Write(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
            }
            Console.WriteLine();
        }

        // Method to perform binary XOR operation on byte arrays
        static byte[] XOR(byte[] a, byte[] b)
        {
            byte[] result = new byte[Math.Min(a.Length, b.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (byte)(a[i] ^ b[i]);
            }
            return result;
        }

        public static byte[] Encrypt(string text)
        {

            Console.WriteLine("Your String: " +  text);

            byte[] encryptedBytes = new byte[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                byte[] bytesFromChar = GetBytesFromASCII(c);
                byte[] bytesFromKey = GetBytesFromASCII(keyCharacter);
                
                Console.Write("C: " + c + " Bytes:");
                PrintByteArray(bytesFromChar);

                Console.Write("K: " + keyCharacter + " Bytes:");
                PrintByteArray(bytesFromKey);

                byte[] xorResult = XOR(bytesFromChar, bytesFromKey);
                Console.WriteLine("\n XOR Result:");
                Console.Write("R: " + "  Bytes: ");
                PrintByteArray(xorResult);
                Console.WriteLine("\n");

                encryptedBytes[i] = xorResult[0];
            };
            
            
            return encryptedBytes;
        }
    }
}
