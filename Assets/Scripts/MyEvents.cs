using UnityEngine;
using UnityEngine.Events;
using System.Collections;

static public class MyEvents
{
    static public UnityEvent Activate = new UnityEvent();
    static public UnityEvent ChangeColor = new UnityEvent();
    static public UnityEvent<int> ChangeColorIndex = new UnityEvent<int>();
}
