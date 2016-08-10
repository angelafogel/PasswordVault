using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordVault2;


namespace EncryptionDecryptionTest
{
    [TestClass]
    public class EncryptionTest
    {
   
        [TestMethod]
        public void EncryptDecrypt()
        {
            // arrange
            string plaintext = "data";
            string password = "password";
            string encryptedText = " ";
            string decryptedText = " "; 
                
            // act
            encryptedText = EncryptionDecryption.EncryptionString(plaintext, password);
            decryptedText = EncryptionDecryption.DecryptFromString(encryptedText, password);
                  
            // assert
            Assert.AreNotEqual(encryptedText, plaintext, "Encryption is not functioning, encrypted = plaintext");
            Assert.AreEqual(plaintext, decryptedText, "Plaintext / Decrypted text does not match");
            
        }

        [TestMethod]
        public void Byte_String_Conversion()
        {
            // arrange
            string convertText = "conversiondata";
            byte[] dataByteArray = null;
            string toString = " ";

            // act 
            dataByteArray = EncryptionDecryption.PTtoBytes(convertText);
            toString = EncryptionDecryption.toString(dataByteArray);

           Assert.AreEqual(convertText, toString, "Conversion text does not match to string text");
        }

    }
}
