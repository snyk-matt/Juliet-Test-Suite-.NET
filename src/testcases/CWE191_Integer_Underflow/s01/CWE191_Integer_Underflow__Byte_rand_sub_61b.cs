/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Byte_rand_sub_61b.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Byte_rand_sub_61b
{
#if (!OMITBAD)
    public static byte BadSource()
    {
        byte data;
        /* POTENTIAL FLAW: Use a random value */
        data = (byte)(new Random().Next(byte.MinValue, byte.MaxValue));
        return data;
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static byte GoodG2BSource()
    {
        byte data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        return data;
    }

    /* goodB2G() - use badsource and goodsink */
    public static byte GoodB2GSource()
    {
        byte data;
        /* POTENTIAL FLAW: Use a random value */
        data = (byte)(new Random().Next(byte.MinValue, byte.MaxValue));
        return data;
    }
#endif
}
}
