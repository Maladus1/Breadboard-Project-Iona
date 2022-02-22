using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrGate : LogicGate
{
    public void FixedUpdate()
    {
        computeOr();
    }
    public void computeOr()
    {
        if (!inputs[0].value && !inputs[1].value) { outValue = false; }
        else if (inputs[0].value && !inputs[1].value) { outValue = true; }
        else if (!inputs[0].value && inputs[1].value) { outValue = true; }
        else { outValue = true; }

        sendOutput();
    }
}
