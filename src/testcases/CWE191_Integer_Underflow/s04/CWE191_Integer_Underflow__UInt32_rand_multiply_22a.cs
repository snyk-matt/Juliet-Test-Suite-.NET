/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_rand_multiply_22a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_rand_multiply_22a : AbstractTestCase
{

    /* The public static variable below is used to drive control flow in the sink function. */
    public static bool badPublicStatic = false;
#if (!OMITBAD)
    public override void Bad()
    {
        uint data = 0u;
        /* POTENTIAL FLAW: Use a random value */
        data = (uint)(new Random().Next(1 << 30)) << 2 | (uint)(new Random().Next(1 << 2));
        badPublicStatic = true;
        CWE191_Integer_Underflow__UInt32_rand_multiply_22b.BadSink(data );
    }
#endif //omitbad
    /* The public static variables below are used to drive control flow in the sink functions. */
    public static bool goodB2G1PublicStatic = false;
    public static bool goodB2G2PublicStatic = false;
    public static bool goodG2BPublicStatic = false;
#if (!OMITGOOD)
    public override void Good()
    {
        GoodB2G1();
        GoodB2G2();
        GoodG2B();
    }

    /* goodB2G1() - use badsource and goodsink by setting the static variable to false instead of true */
    private void GoodB2G1()
    {
        uint data = 0u;
        /* POTENTIAL FLAW: Use a random value */
        data = (uint)(new Random().Next(1 << 30)) << 2 | (uint)(new Random().Next(1 << 2));
        goodB2G1PublicStatic = false;
        CWE191_Integer_Underflow__UInt32_rand_multiply_22b.GoodB2G1Sink(data );
    }

    /* goodB2G2() - use badsource and goodsink by reversing the blocks in the if in the sink function */
    private void GoodB2G2()
    {
        uint data = 0u;
        /* POTENTIAL FLAW: Use a random value */
        data = (uint)(new Random().Next(1 << 30)) << 2 | (uint)(new Random().Next(1 << 2));
        goodB2G2PublicStatic = true;
        CWE191_Integer_Underflow__UInt32_rand_multiply_22b.GoodB2G2Sink(data );
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        uint data = 0u;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        goodG2BPublicStatic = true;
        CWE191_Integer_Underflow__UInt32_rand_multiply_22b.GoodG2BSink(data );
    }
#endif //omitgood
}
}
