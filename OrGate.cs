using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrGate : LogicGate
{
    // Start is called before the first frame update
    public void computeOr()
    {
        if (!inputs[0].GetOuput() && !inputs[1].GetOuput()) { output = false; }
        else if (inputs[0].GetOuput() && !inputs[1].GetOuput()) { output = true; }
        else if (!inputs[0].GetOuput() && inputs[1].GetOuput()) { output = true; }
        else { output = true; }
    }
}
