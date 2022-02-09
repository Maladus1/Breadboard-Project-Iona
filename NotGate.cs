using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : LogicGate
{
    public void computeNot()
    {
        if (inputs[0].GetOuput()) { output = true; }
        else { output = false; }
    }
}
