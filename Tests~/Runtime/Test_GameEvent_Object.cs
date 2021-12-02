using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_GameEvent_Object : MonoBehaviour
{
    [SerializeField] GameEvent gameEvent;
    private void OnDisable() => gameEvent?.Invoke();
}
