/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE193_Off_by_One_Error__do_10.cs
Label Definition File: CWE193_Off_by_One_Error.label.xml
Template File: point-flaw-10.tmpl.cs
*/
/*
* @description
* CWE: 193 An array index is 1 off from the max array index
* Sinks: do
*    GoodSink: restrict max index value
*    BadSink : access array index outside array max
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE193_Off_by_One_Error
{
class CWE193_Off_by_One_Error__do_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.staticTrue)
        {
            int[] intArray = new int[10];
            int i = 0;
            do
            {
                IO.WriteLine("intArray[" + i + "] = " + (intArray[i] = i));
                i++;
            }
            while (i <= intArray.Length);   /* FLAW: Use <= rather than < */
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* good1() changes IO.staticTrue to IO.staticFalse */
    private void Good1()
    {
        if (IO.staticFalse)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            int[] intArray = new int[10];
            int i = 0;
            do
            {
                IO.WriteLine("intArray[" + i + "] = " + (intArray[i] = i));
                i++;
            }
            while (i < intArray.Length);   /* FIX: Use < to ensure no out of bounds access */
        }
    }

    /* good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (IO.staticTrue)
        {
            int[] intArray = new int[10];
            int i = 0;
            do
            {
                IO.WriteLine("intArray[" + i + "] = " + (intArray[i] = i));
                i++;
            }
            while (i < intArray.Length);   /* FIX: Use < to ensure no out of bounds access */
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
