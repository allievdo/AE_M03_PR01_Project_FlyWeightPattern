using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public bool toggled = false;
    public void Toggled()
    {
        toggled = !toggled;
    }
}
