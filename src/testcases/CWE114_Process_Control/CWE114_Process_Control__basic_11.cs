/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE114_Process_Control__basic_11.cs
Label Definition File: CWE114_Process_Control__basic.label.xml
Template File: point-flaw-11.tmpl.cs
*/
/*
* @description
* CWE: 114 Process Control
* Sinks:
*    GoodSink: use Assembly.LoadFrom() to load a library
*    BadSink : use Assembly.Load() to load a library
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Reflection;

namespace testcases.CWE114_Process_Control
{
class CWE114_Process_Control__basic_11 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.StaticReturnsTrue())
        {
            string libraryName = "test.dll";
            /* FLAW: Attempt to load a library with Assembly.Load() without the full path to the library. */
            Assembly.Load(libraryName);
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* good1() changes IO.StaticReturnsTrue() to IO.StaticReturnsFalse() */
    private void Good1()
    {
        if (IO.StaticReturnsFalse())
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            int p = (int)Environment.OSVersion.Platform;
            string root;
            string libraryName = "test.dll";
            if (p == (int)PlatformID.Win32NT || p == (int)PlatformID.Win32Windows || p == (int)PlatformID.Win32S || p == (int)PlatformID.WinCE)
            {
                /* running on Windows */
                root = "C:\\libs\\";
            }
            else
            {
                /* running on non-Windows */
                root = "/home/user/libs/";
            }
            /* FIX: Use Assembly.LoadFrom() which allows you to specify a full path to the library */
            Assembly.LoadFrom(root + libraryName);
        }
    }

    /* good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (IO.StaticReturnsTrue())
        {
            int p = (int)Environment.OSVersion.Platform;
            string root;
            string libraryName = "test.dll";
            if (p == (int)PlatformID.Win32NT || p == (int)PlatformID.Win32Windows || p == (int)PlatformID.Win32S || p == (int)PlatformID.WinCE)
            {
                /* running on Windows */
                root = "C:\\libs\\";
            }
            else
            {
                /* running on non-Windows */
                root = "/home/user/libs/";
            }
            /* FIX: Use Assembly.LoadFrom() which allows you to specify a full path to the library */
            Assembly.LoadFrom(root + libraryName);
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
