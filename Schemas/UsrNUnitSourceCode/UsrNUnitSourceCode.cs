namespace Terrasoft.Configuration
{
    public class UsrNUnitSourceCode
    {
        public string StringToTest
        {
            get
            {
                return "String to test";
            }
        }

        public bool AreStringsEqual(string str1, string str2)
        {
            return str1 == str2;
        }
    }
}