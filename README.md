## How to use

1. Create gameEvent scriptableObject `Create/ScriptableObjects/GameEvent`
2. Call next methods on this scriptableObject:

```C#
GameEvent.Invoke();                                     //Invoke events
GameEvent.Add(GameEventListener gameEventListener);     //Subscribe
GameEvent.Remove(GameEventListener gameEventListener);  //Unsibscribe
```

## Links
[tuttorial](https://www.youtube.com/watch?v=lgA8KirhLEU)
