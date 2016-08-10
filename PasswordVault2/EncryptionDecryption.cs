using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Security.Cryptography;


namespace PasswordVault2
{
    public static class EncryptionDecryption
    {

        #region Encryptors and Decryptors

        // (1) Recieves user data from the form, 
        // (2) sends plaintext data to bytes conversion PTtoBytes(),
        // (3) sends bytes, password and sets encryption flag to true
        // as parameters for encryption algorithm EncryptDecryptBytes(),
        // (4) converts the returned encrypted bytes to string ByteString_Conversion()
        public static string EncryptionString(string plain_text, string password)
        {
            byte [] PT_Byte_Array = PTtoBytes(plain_text);
            byte [] encrpytedBytes = EncryptDecryptBytes(password, PT_Byte_Array, true);
            return ByteString_Conversion(encrpytedBytes);
        }

        // Converts user data string into an array of bytes.
        public static byte[] PTtoBytes(string plain_text)
        {
            ASCIIEncoding ascii_encoder = new ASCIIEncoding();
            byte[] pt_bytes_array = ascii_encoder.GetBytes(plain_text);
            return pt_bytes_array;
        }

        // Convert encrypted bytes into a string.
        public static string ByteString_Conversion(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes)
            {
                result += " " + b.ToString("X2");
            }
            if (result.Length > 0) result = result.Substring(1);
            return result;
        }
        
        // Converts encrypted string to byte array 
        // then sends bytes to decryption algorithm with password
        // decryption algorithm returns decrypted bytes
        // toString method converts bytes to a string
        public static string DecryptFromString(string encrypted_bytes_string, string password)
        {
            byte[] encryptedBytes = String_Bytes_Conversion(encrypted_bytes_string);
            byte[] decrypted_bytes = EncryptDecryptBytes(password, encryptedBytes, false);
            return toString(decrypted_bytes);
        }

        // Converts encrypted string back into byte array
        private static byte[] String_Bytes_Conversion(string str)
        {
            str = str.Replace(" ", "");
            int num_bytes = str.Length / 2;
            byte[] bytes = new byte[num_bytes];
            for (int i = 0; i < num_bytes; i++)
            {
                bytes[i] = Convert.ToByte(str.Substring(2 * i, 2), 16);
            }
            return bytes;
        }

        //Convert decrypted bytes to a string
        public static string toString(byte[] fromBytes)
        {
            ASCIIEncoding ascii_encoder = new ASCIIEncoding();
            return new string(ascii_encoder.GetChars(fromBytes));
        }
       

            //***********SHARED ENCRYPTION / DECRYPTION METHOD***********//
        // Encryption or decryption of a byte array depending on encryptionTF bool variable.
        private static byte[] EncryptDecryptBytes(string password, byte[] pt_byte_Array, bool encryptionTF)
        {
            // Make an AES service provider.
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();

            //Derive the key using password
            PasswordDeriveBytes derive_bytes = new PasswordDeriveBytes(password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            //gets key and initialization vector based on password derived bytes
            //and sets the size of the key and initialization vector
            byte[] key = derive_bytes.GetBytes(AES.KeySize/8);
            byte[] initVector = derive_bytes.GetBytes(AES.BlockSize/8);

            //******CREATE ENCRYPTOR || DECRYPTOR SELECTION*******//
            // Make the encryptor or decryptor depending on EncryptionTF bool variable.
            ICryptoTransform cryptographicTransformation;
            if (encryptionTF) cryptographicTransformation = AES.CreateEncryptor(key, initVector);
            else cryptographicTransformation = AES.CreateDecryptor(key, initVector);

            // Create output stream.
            MemoryStream MemoryOutputStream = new MemoryStream();

            // Attach a crypto stream to the output stream
            CryptoStream myCryptoStream = new CryptoStream(
               MemoryOutputStream, cryptographicTransformation,
               CryptoStreamMode.Write);

            // Write the bytes into the CryptoStream.
            myCryptoStream.Write(pt_byte_Array, 0, pt_byte_Array.Length);
            try
            {
                myCryptoStream.FlushFinalBlock();
            }
            catch (CryptographicException)
            {
                // Ignore this one. The password is bad.
            }
            catch
            {
                // Re-raise this one.
                throw;
            }
   
            // Save the result.
            byte[] result = MemoryOutputStream.ToArray();

            // Stream close.

            myCryptoStream.Close();
            MemoryOutputStream.Close();

            return result; 
        }

        #endregion Encryptors and Decryptors
    }
}
