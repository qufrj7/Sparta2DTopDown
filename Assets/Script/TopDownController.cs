using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController2D : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction) 
    {
        OnMoveEvent?.Invoke(direction); // ?. -> 없으면 말고 있으면 실행한다.
    }

    public void CallLookEvent(Vector2 direction) 
    {
        OnLookEvent?.Invoke(direction); 
    }
}
