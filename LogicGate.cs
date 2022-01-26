using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicGate: MonoBehaviour
{
    public List<LogicGate> inputs;
    public bool output;

    void Start()
    {
        //there is only one input for a basic logic gate
        LogicGate temp = inputs[0];
        inputs = new List<LogicGate>(1);
        inputs.Add(temp);
    }

    public bool GetOuput()
    {
        if(!inputs[0].output) { output = false; }
        else { output = true; }
        return output;
    }

    public List<LogicGate> GetInput() { return inputs; }
    

}
