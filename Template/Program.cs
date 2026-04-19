//#if (DoNotUseTopLevelStatements)
namespace BflatProject;

internal static class Program
{
    private static void Main()
    {
        System.Environment.FailFast(null);
    }
}
//#else
System.Environment.FailFast(null);
//#endif