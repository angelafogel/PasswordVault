using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordVaultNS;


namespace EncryptionDecryptionTests
{
    [TestClass]
    public class EncryptionDecryptionTests
    {
        [TestMethod]
        [TestCategory("Encryption")]
        public void EncryptDecrypt()
        {
            string plaintext = "data";
            string password = "password";
            string encryptedText = " ";
            string decryptedText = " "; 
                
            encryptedText = EncryptionDecryption.EncryptionString(plaintext, password);
            decryptedText = EncryptionDecryption.DecryptFromString(encryptedText, password);
                  
            Assert.AreNotEqual(encryptedText, plaintext, "Encryption is not functioning, encrypted = plaintext");
            Assert.AreEqual(plaintext, decryptedText, "Plaintext / Decrypted text does not match");
            
        }

        [TestMethod]
        [TestCategory("Encryption")]
        public void Byte_String_Conversion()
        {
            string convertText = "conversiondata";
            byte[] dataByteArray = null;
            string toString = " ";

            dataByteArray = EncryptionDecryption.PTtoBytes(convertText);
            toString = EncryptionDecryption.toString(dataByteArray);

            Assert.AreEqual(convertText, toString, "Conversion text does not match to string text");
        }
    }
}
