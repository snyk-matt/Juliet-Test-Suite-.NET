/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_while_08.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-08.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_while
*    GoodSink: While statement contains code
*    BadSink : An empty while statement has no effect
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_while_08 : AbstractTestCase
{
    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false.
     */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        if (PrivateReturnsTrue())
        {
            int i = 0;
            /* FLAW: An empty while statement has no effect */
            while(i++ < 10)
            {
            }
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* Good1() changes PrivateReturnsTrue() to privateReturnsFalse() */
    private void Good1()
    {
        if (PrivateReturnsFalse())
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            int i = 0;
            /* FIX: Do not include an empty while statement */
            while(i++ < 10)
            {
                IO.WriteLine("Inside the while statement");
            }
            IO.WriteLine("Hello from Good()");
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (PrivateReturnsTrue())
        {
            int i = 0;
            /* FIX: Do not include an empty while statement */
            while(i++ < 10)
            {
                IO.WriteLine("Inside the while statement");
            }
            IO.WriteLine("Hello from Good()");
        }
    }

    public override void Good()
    {
        Good1();
        Good2();
    }
#endif //omitgood
}
}
