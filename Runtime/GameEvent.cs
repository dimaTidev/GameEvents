using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "ScriptableObjects/GameEvent")]
public class GameEvent : ScriptableObject
{
#if UNITY_EDITOR
    [SerializeField, TextArea] string EDITOR_description;
#endif

    HashSet<GameEventListener> _listenerts = new HashSet<GameEventListener>();

    public void Invoke()
    {
        foreach (var globalEventListener in _listenerts)
            globalEventListener.RaiseEvent();
    }

    public void Add(GameEventListener gameEventListener) => _listenerts.Add(gameEventListener);
    public void Remove(GameEventListener gameEventListener) => _listenerts.Remove(gameEventListener);
}
