using System.Diagnostics;
using Anotar.Log4Net;

public class ClassWithWhileMethod
{

    public void MethodWithWhile()
    {
        while (true)
        {
            Trace.WriteLine("dfg");
            break;
        }
        Log.Info();
    }
}