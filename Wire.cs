using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    public Chip front;
    public Chip end;
    private int i;

    public Chip GetFront() { return front; }

    public Chip GetEnd() { return end; }

    public bool CheckConnection(int i)
    {
        if (i == 0) 
        {
            if (GetFront() != null) { return true; }
            else { return false; }
        }
        else if (i == 1)
        {
            if (GetEnd() != null) { return true; }
            else { return false; }
        }
        else
        {
            return false;
        }
    }
}
