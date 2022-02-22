using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorGate : LogicGate
{
    public void FixedUpdate()
    {
        computeNor();
    }
    public void computeNor()
    {
        if (!inputs[0].value && !inputs[1].value) { outValue = true; }
        else { outValue = false; }

        sendOutput();
    }
}
