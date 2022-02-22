using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XorGate : LogicGate
{
    public void FixedUpdate()
    {
        computeXor();
    }
    public void computeXor()
    {
        if (inputs[0].value == inputs[1].value) { outValue = false; }
        else { outValue = true; }

        sendOutput();
    }
}
