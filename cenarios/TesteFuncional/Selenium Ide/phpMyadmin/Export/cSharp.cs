using NUnit.Framework;
using NUnit.Core;

namespace SeleniumTests
{
    public class CSharp
    {
        [Suite] public static TestSuite Suite
        {
            get
            {
                TestSuite suite = new TestSuite("CSharp");
                suite.Add(new UserInvalid());
                suite.Add(new UserValid());
                suite.Add(new AddBd());
                suite.Add(new AddBdExists());
                suite.Add(new DelBd());
                return suite;
            }
        }
    }
}
