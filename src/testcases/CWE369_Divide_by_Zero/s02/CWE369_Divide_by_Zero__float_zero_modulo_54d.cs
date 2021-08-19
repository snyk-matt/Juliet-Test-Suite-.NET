/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_zero_modulo_54d.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-54d.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: zero Set data to a hardcoded value of zero
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_zero_modulo_54d
{
#if (!OMITBAD)
    public static void BadSink(float data )
    {
        CWE369_Divide_by_Zero__float_zero_modulo_54e.BadSink(data );
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(float data )
    {
        CWE369_Divide_by_Zero__float_zero_modulo_54e.GoodG2BSink(data );
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(float data )
    {
        CWE369_Divide_by_Zero__float_zero_modulo_54e.GoodB2GSink(data );
    }
#endif
}
}
