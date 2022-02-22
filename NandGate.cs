using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NandGate : LogicGate
{
    public void FixedUpdate()
    {
        computeNand();
    }
    public void computeNand()
    {
        if (inputs[0].value && inputs[1].value ) { outValue = false; }
        else { outValue = true; }

        sendOutput();
    }
}
