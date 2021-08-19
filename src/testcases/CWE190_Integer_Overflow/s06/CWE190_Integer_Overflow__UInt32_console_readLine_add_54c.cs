/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt32_console_readLine_add_54c.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-54c.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: console_readLine Read data from the console using readLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt32_console_readLine_add_54c
{
#if (!OMITBAD)
    public static void BadSink(uint data )
    {
        CWE190_Integer_Overflow__UInt32_console_readLine_add_54d.BadSink(data );
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(uint data )
    {
        CWE190_Integer_Overflow__UInt32_console_readLine_add_54d.GoodG2BSink(data );
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(uint data )
    {
        CWE190_Integer_Overflow__UInt32_console_readLine_add_54d.GoodB2GSink(data );
    }
#endif
}
}
