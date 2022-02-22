using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : LogicGate
{
    public void FixedUpdate()
    {
        computeNot();
    }
    public void computeNot()
    {
        if (inputs[0].value) { outValue = true; }
        else { outValue = false; }

        sendOutput();
    }
}
