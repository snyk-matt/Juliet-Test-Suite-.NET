/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__Integer_67b.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 476 Null Pointer Dereference
 * BadSource:  Set data to null
 * GoodSource: Set data to a non-null value
 * Sinks:
 *    GoodSink: add check to prevent possibility of null dereference
 *    BadSink : possibility of null dereference
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__Integer_67b
{
#if (!OMITBAD)
    public static void BadSink(CWE476_NULL_Pointer_Dereference__Integer_67a.Container dataContainer )
    {
        int? data = dataContainer.containerOne;
        /* POTENTIAL FLAW: null dereference will occur if data is null */
        IO.WriteLine("" + data.ToString());
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(CWE476_NULL_Pointer_Dereference__Integer_67a.Container dataContainer )
    {
        int? data = dataContainer.containerOne;
        /* POTENTIAL FLAW: null dereference will occur if data is null */
        IO.WriteLine("" + data.ToString());
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(CWE476_NULL_Pointer_Dereference__Integer_67a.Container dataContainer )
    {
        int? data = dataContainer.containerOne;
        /* FIX: validate that data is non-null */
        if (data != null)
        {
            IO.WriteLine("" + data.ToString());
        }
        else
        {
            IO.WriteLine("data is null");
        }
    }
#endif
}
}
