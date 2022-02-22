using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndGate : LogicGate
{
    public void FixedUpdate()
    {
        computeAnd();
    }
    public void computeAnd()
    {
        if (inputs[0].value && inputs[1].value) { outValue = true; }
        else { outValue = false; }

        sendOutput();
    }
}
