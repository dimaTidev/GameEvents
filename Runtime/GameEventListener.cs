using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] GameEvent _gameEvent = null;
    [SerializeField] UnityEvent onInvokeEvent = null;

    void Awake() => _gameEvent?.Add(this);
    void OnDestroy() => _gameEvent?.Remove(this);
    public void RaiseEvent() => onInvokeEvent?.Invoke();
}
