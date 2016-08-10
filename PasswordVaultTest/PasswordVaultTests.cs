using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PasswordVaultNS;

using Moq;

namespace PasswordVaultTests
{
    [TestClass]
    public class PasswordVaultTests
    {
        private int userid;
        private string username;
        private string password;
        private string email;
        private string passwordHint;
        private bool result;
        private static PasswordVault userAccount;
        private readonly IProductRepository MockProductsRepository;

        public PasswordVaultTests()
        {
            Mock<IProductRepository> mockProductRepository = new Mock<IProductRepository>();

            IList<Product> products = new List<Product>
            {
                new Product { UserId = 1, UserName = "one", MasterPassword = "oneabc",
                    UserEmail ="one@hotmail.com", PasswordHint = "1abc" },
                new Product { UserId = 2, UserName = "two", MasterPassword = "twoabc",
                    UserEmail ="two@hotmail.com", PasswordHint = "2abc" },
                new Product { UserId = 3, UserName = "three", MasterPassword = "threeabc",
                    UserEmail ="three@hotmail.com", PasswordHint = "3abc" }
            };
        

            mockProductRepository.Setup(mr => mr.FindAll()).Returns(products);

            mockProductRepository.Setup(mr => mr.FindByUserId(
                It.IsAny<int>())).Returns((int i) => products.Where(
                x => x.UserId == i).SingleOrDefault());

            mockProductRepository.Setup(mr => mr.FindByUserName(
                It.IsAny<string>())).Returns((string s) => products.Where(
                x => x.UserName == s).SingleOrDefault());

            mockProductRepository.Setup(mr => mr.FindByUserEmail    (
                It.IsAny<string>())).Returns((string s) => products.Where(
                x => x.UserEmail == s).SingleOrDefault());

            mockProductRepository.Setup(mr => mr.Save(It.IsAny<Product>())).Returns(
                (Product target) =>
                {
                    if (target.UserId.Equals(default(int)))
                    {
                        target.UserId = products.Count() + 1;
                        products.Add(target);
                    }
                    else
                    {
                        var original = products.Where(
                            q => q.UserId == target.UserId).Single();

                        if (original == null)
                        {
                            return false;
                        }

                        original.UserName = target.UserName;
                        original.MasterPassword = target.MasterPassword;
                        original.UserEmail = target.UserEmail;
                        original.PasswordHint = target.PasswordHint;
                    }

                    return true;
                });

            this.MockProductsRepository = mockProductRepository.Object;
        }


        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            userAccount = new PasswordVault("user", "Passw0rd1", "me@shu.edu", "hint");
        }


        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindByUserId_ReturnProductUserNameByUserId()
        {
            userid = 1;

            Product testProduct = this.MockProductsRepository.FindByUserId(userid);
            var query = testProduct.UserName;
 
            Assert.AreEqual("one", query);
        }


        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindByUserId_ReturnProductUserNameByUserId_NoResult()
        {
            userid = 1000;

            Product testProduct = this.MockProductsRepository.FindByUserId(userid);

            Assert.IsNull(testProduct);
        }


        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindByUserId_ReturnProductUserEmailByUserId()
        {
            userid = 1;

            Product testProduct = this.MockProductsRepository.FindByUserId(userid);
            var query = testProduct.UserEmail;

            Assert.AreEqual("one@hotmail.com", query);
        }


        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindByUserId_ReturnProductUserEmailByUserId_NoResult()
        {
            userid = 1000;

            Product testProduct = this.MockProductsRepository.FindByUserId(userid);

            Assert.IsNull(testProduct);
        }

 
        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindByUserName_ReturnProductMasterPasswordByUserName()
        {
            username = "three";

            Product testProduct = this.MockProductsRepository.FindByUserName(username);
            var query = testProduct.MasterPassword;
 
            Assert.AreEqual("threeabc", query);
        }
        

        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindByUserName_ReturnProductMasterPasswordByUserName_NoResult()
        {
            username = "one-zero";

            Product testProduct = this.MockProductsRepository.FindByUserName(username);

            Assert.IsNull(testProduct);
        }


        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindByUserName_ReturnProductUserEmailByUserName()
        {
            username = "one";

            Product testProduct = this.MockProductsRepository.FindByUserName(username);
            var query = testProduct.UserEmail;

            Assert.AreEqual("one@hotmail.com", query);
        }


        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindByUserEmail_ReturnProductPasswordHintByUserEmail()
        {
            email = "one@hotmail.com";

            Product testProduct = this.MockProductsRepository.FindByUserEmail(email);
            var query = testProduct.PasswordHint;

            Assert.AreEqual("1abc", query);
        }


        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindByUserEmail_ReturnProductPasswordHintByUserEmail_NoResult()
        {
            email = "fake_one@hotmail.com";

            Product testProduct = this.MockProductsRepository.FindByUserEmail(email);

            Assert.IsNull(testProduct);
        }
        

        [TestMethod]
        [TestCategory("Mock DB")]
        public void FindAll_ReturnAllProducts()
        {
            IList<Product> testProduct = this.MockProductsRepository.FindAll();
            var query = testProduct.Count;

            Assert.AreEqual(3, query);
        }
 
        
        [TestMethod]
        [TestCategory("Mock DB")]
        public void Save_InsertNewProductAndVerifyProductByUserName()
        {
            username = "four";
            Product newProduct = new Product { UserName = "four", MasterPassword = "fourabc", 
                    UserEmail = "four@hotmail.com", PasswordHint = "4abc" };
            
            this.MockProductsRepository.Save(newProduct);
            Product testProduct = this.MockProductsRepository.FindByUserName(username);

            Assert.AreEqual("four", testProduct.UserName);
        }
 
        
        [TestMethod]
        [TestCategory("Mock DB")]
        public void Save_UpdateAnExistingProductByUserId()
        {
            userid = 1;
            Product testProduct = this.MockProductsRepository.FindByUserId(userid);
            
            testProduct.UserName = "one-zero";
            this.MockProductsRepository.Save(testProduct);
            var query = this.MockProductsRepository.FindByUserId(userid).UserName;

            Assert.AreEqual("one-zero", query);
        }




        [TestMethod]
        [TestCategory("Mock Email")]
        public void SendEmailNewAccount_EmailNewAccountConfirmation()
        {
            Mock<EmailNotification> testEmail = new Mock<EmailNotification>();

            testEmail.Setup(x => x.SendEmail()).Returns(true);
            result = userAccount.SendEmailNewAccount(testEmail.Object);

            Assert.AreEqual(true, result);
        }


        [TestMethod]
        [TestCategory("Mock Email")]
        public void SendEmailForgotPassword_EmailPasswordHint()
        {
            Mock<EmailNotification> testEmail = new Mock<EmailNotification>();

            testEmail.Setup(x => x.SendEmail()).Returns(false);
            result = userAccount.SendEmailForgotPassword(testEmail.Object);

            Assert.AreEqual(true, result);
        }




        [TestMethod]
        [TestProperty("Validate", "UserName")]
        public void ValidateUserName_MatchFound()
        {
            username = "user";

            result = userAccount.ValidateUserName(username);

            Assert.IsTrue(result, "Username is a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserName")]
        public void ValidateUserName_NoMatchFound()
        {
            username = "fake_username";

            result = userAccount.ValidateUserName(username);

            Assert.IsFalse(result, "Username is not a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserName")]
        public void ValidateUserName_IsNotCaseSensitive()
        {
            username = "USER";

            result = userAccount.ValidateUserName(username);

            Assert.IsTrue(result, "Username is not case sensitive.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserName")]
        public void ValidateComplexUserName_CannotBeLeftBlank()
        {
            username = "";

            result = userAccount.ValidateComplexUserName(username);

            Assert.IsFalse(result, "Username is blank.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserName")]
        public void ValidateComplexUserName_CannotContainOnlyWhiteSpace()
        {
            username = "     ";

            result = userAccount.ValidateComplexUserName(username);

            Assert.IsFalse(result, "Username cannot contain only whitespace.");
        }


        [TestMethod]
        [TestProperty("Validate", "MasterPassword")]
        public void ValidatePassword_MatchFound()
        {
            password = "Passw0rd1";

            result = userAccount.ValidatePassword(password);

            Assert.IsTrue(result, "Password is a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "MasterPassword")]
        public void ValidatePassword_NoMatchFoundContainsExtraWhiteSpaceAtTheEnd()
        {
            password = "Passw0rd1    ";

            result = userAccount.ValidatePassword(password);

            Assert.IsFalse(result, "Password is not a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "MasterPassword")]
        public void ValidatePassword_IsCaseSensitive()
        {
            password = "PASSw0rd1";

            result = userAccount.ValidatePassword(password);

            Assert.IsFalse(result, "Password is case sensitive.");
        }


        [TestMethod]
        [TestProperty("Validate", "MasterPassword")]
        public void ValidateComplexPassword_CannotBeLeftBlank()
        {
            password = "";

            result = userAccount.ValidateComplexPassword(password);

            Assert.IsFalse(result, "Password is blank.");
        }


        [TestMethod]
        [TestProperty("Validate", "MasterPassword")]
        public void ValidateComplexPassword_CannotContainOnlyWhiteSpace()
        {
            password = "     ";

            result = userAccount.ValidateComplexPassword(password);

            Assert.IsFalse(result, "Password cannot contain only whitespace.");
        }


        [TestMethod]
        [TestProperty("Validate", "MasterPassword")]
        public void ValidateComplexPassword_MustContainAtLeastEightCharactersInLength()
        {
            password = "Pass";

            result = userAccount.ValidateComplexPassword(password);

            Assert.IsFalse(result, "Password must be at least 8 characters in length.");
        }


        [TestMethod]
        [TestProperty("Validate", "MasterPassword")]
        public void ValidateComplexPassword_MustContainAtLeastOneUpperCaseCharacter()
        {
            password = "password1"; 

            result = userAccount.ValidateComplexPassword(password);

            Assert.IsFalse(result, "Password must contain at least one upper case character.");
        }


        [TestMethod]
        [TestProperty("Validate", "MasterPassword")]
        public void ValidateComplexPassword_MustContainAtLeastOneLowerCaseCharacter()
        {
            password = "PASSWORD1";

            result = userAccount.ValidateComplexPassword(password);

            Assert.IsFalse(result, "Password must contain at least one lower case character.");
        }


        [TestMethod]
        [TestProperty("Validate", "MasterPassword")]
        public void ValidateComplexPassword_MustContainAtLeastOneDigit()
        {
            password = "Password";

            result = userAccount.ValidateComplexPassword(password);

            Assert.IsFalse(result, "Password must contain at least one digit.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserName And MasterPassword")]
        public void ValidateUserNameAndPassword_MatchFound()
        {
            username = "user";
            password = "Passw0rd1";

            result = userAccount.ValidateUserNameAndPassword(username, password);

            Assert.IsTrue(result, "Username and Password are a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserName And MasterPassword")]
        public void ValidateUserNameAndPassword_NoMatchFound()
        {
            username = "1111user";
            string password = "1111Passw0rd1";

            result = userAccount.ValidateUserNameAndPassword(username, password);

            Assert.IsFalse(result, "Username and/or Password is not a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserEmail")]
        public void ValidateEmailAddress_MatchFound()
        {
            email = "me@shu.edu";

            result = userAccount.ValidateEmailAddress(email);

            Assert.IsTrue(result, "Email address is a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserEmail")]
        public void ValidateEmailAddress_NoMatchFound()
        {
            email = "admin@shu.edu";

            result = userAccount.ValidateEmailAddress(email);

            Assert.IsFalse(result, "Email address is not a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserEmail")]
        public void ValidateComplexEmailAddress_CannotBeLeftBlank()
        {
            email = "";

            result = userAccount.ValidateComplexEmailAddress(email);

            Assert.IsFalse(result, "Email address is blank.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserEmail")]
        public void ValidateComplexEmailAddress_CannotContainOnlyWhiteSpace()
        {
            email = "     ";

            result = userAccount.ValidateComplexEmailAddress(email);

            Assert.IsFalse(result, "Email address cannot contain only whitespace.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserEmail")]
        public void ValidateComplexEmailAddress_MatchComplexityCriteria()
        {
            email = "me@shu.edu";

            result = userAccount.ValidateComplexEmailAddress(email);

            Assert.IsTrue(result, "Email address is valid to use.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserEmail")]
        public void ValidateComplexEmailAddress_MustContainAtSymbolBeforeDotNotation()
        {
            email = "wei[at]sacredheart.edu";

            result = userAccount.ValidateComplexEmailAddress(email);

            Assert.IsFalse(result, "Email address must contain an @ symbol before the . (dot) notation.");
        }

        [TestMethod]
        [TestProperty("Validate", "UserEmail")]
        public void ValidateComplexEmailAddress_MustContainADotNotationAfterAtSymbol()
        {
            email = "wei@sacredheart[dot]edu";

            result = userAccount.ValidateComplexEmailAddress(email);

            Assert.IsFalse(result, "Email address must contain a . (dot) notation after the @ symbol.");
        }


        [TestMethod]
        [TestProperty("Validate", "UserEmail")]
        public void ValidateComplexEmailAddress_MustContainAtAndDotNotation()
        {
            email = "wei[at]sacredheart[dot]edu";

            result = userAccount.ValidateComplexEmailAddress(email);

            Assert.IsFalse(result, "Email address must contain both an @ (at) symbol and . (dot).");
        }


        [TestMethod]
        [TestProperty("Validate", "PasswordHint")]
        public void ValidatePasswordHint_MatchFound()
        {
            passwordHint = "hint";

            result = userAccount.ValidatePasswordHint(passwordHint);

            Assert.IsTrue(result, "Password Hint is a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "PasswordHint")]
        public void ValidatePasswordHint_NoMatchFound()
        {
            passwordHint = "fake_hint";

            result = userAccount.ValidatePasswordHint(passwordHint);

            Assert.IsFalse(result, "Password Hint is not a match.");
        }


        [TestMethod]
        [TestProperty("Validate", "PasswordHint")]
        public void ValidateComplexPasswordHint_CannotBeLeftBlank()
        {
            passwordHint = "";

            result = userAccount.ValidateComplexPasswordHint(passwordHint);

            Assert.IsFalse(result, "Password Hint is blank.");
        }


        [TestMethod]
        [TestProperty("Validate","PasswordHint")]
        public void ValidateComplexPasswordHint_CannotContainOnlyWhiteSpace()
        {
            passwordHint = "   ";

            result = userAccount.ValidateComplexPasswordHint(passwordHint);

            Assert.IsFalse(result, "Password Hint cannot contain only white space.");
        }


        [AssemblyCleanUp()]
        public static void AssemblyCleanup()
        {
            userAccount.Dispose();
        }
    }
}
