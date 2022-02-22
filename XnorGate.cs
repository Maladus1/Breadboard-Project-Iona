using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XnorGate : LogicGate
{
    public void FixedUpdate()
    {
        computeXnor();
    }

    public void computeXnor()
    {
        if (inputs[0].value == inputs[1].value) { outValue = true; }
        else { outValue = false; }

        sendOutput();
    }
}
