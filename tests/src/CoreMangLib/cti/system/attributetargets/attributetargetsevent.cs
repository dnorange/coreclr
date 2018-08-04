using System;
/// <summary>
///Event
/// </summary>

public class AttributeTargetsEvent
{
    public static int Main()
    {
        AttributeTargetsEvent AttributeTargetsEvent = new AttributeTargetsEvent();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsEvent");
        if (AttributeTargetsEvent.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Event value is 0x0200. ");
        try
        {
            int expectValue = 0x0200;
            if ((int)AttributeTargets.Event != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Event should return 0x0200.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

