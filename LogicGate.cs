using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicGate: MonoBehaviour
{
    public List<Wire> inputs;
    public List<Wire> outputs;
    public bool outValue;

    public void Update() //used for testing
    {
        if (outValue) { this.GetComponent<Renderer>().material.color = new Color(0f, 1f, 0f, 0f); }
        else { this.GetComponent<Renderer>().material.color = new Color(1f, 0f, 0f, 0f); }
    }

    public bool GetValue()
    {
        if(!inputs[0].value) { outValue = false; }
        else { outValue = true; }
        return outValue;
    }

    public List<Wire> GetInputs() { return inputs; }

    public List<Wire> GetOutputs() { return outputs; }

    public void sendOutput()
    {
        if (outputs != null)
        {
            for (int i = 0; i < outputs.Count; i++)
            {
                outputs[i].value = outValue;
            }
        }
    }


}
