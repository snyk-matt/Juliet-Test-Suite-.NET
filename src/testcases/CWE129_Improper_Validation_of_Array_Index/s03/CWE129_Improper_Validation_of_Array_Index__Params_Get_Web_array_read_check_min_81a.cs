/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_check_min_81a.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_read_check_min
 *    GoodSink: Read from array after verifying that data is at least 0 and less than array.length
 *    BadSink : Read from array after verifying that data is at least 0 (but not verifying that data less than array.length)
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_check_min_81a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        data = int.MinValue; /* Initialize data */
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get() */
        {
            string stringNumber = req.Params.Get("name");
            try
            {
                data = int.Parse(stringNumber.Trim());
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading data from parameter 'name'");
            }
        }
        CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_check_min_81_base baseObject = new CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_check_min_81_bad();
        baseObject.Action(data , req, resp);
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
        GoodB2G(req, resp);
    }

    /* goodG2B() - use GoodSource and BadSink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        int data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_check_min_81_base baseObject = new CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_check_min_81_goodG2B();
        baseObject.Action(data , req, resp);
    }

    /* goodB2G() - use BadSource and GoodSink */
    private void GoodB2G(HttpRequest req, HttpResponse resp)
    {
        int data;
        data = int.MinValue; /* Initialize data */
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get() */
        {
            string stringNumber = req.Params.Get("name");
            try
            {
                data = int.Parse(stringNumber.Trim());
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading data from parameter 'name'");
            }
        }
        CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_check_min_81_base baseObject = new CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_check_min_81_goodB2G();
        baseObject.Action(data , req, resp);
    }
#endif //omitgood
}
}
