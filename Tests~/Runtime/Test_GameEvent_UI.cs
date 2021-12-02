using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_GameEvent_UI : MonoBehaviour
{
    public Text text;

    private void Awake()
    {
        if (text) 
            text.CrossFadeAlpha(0,0,true);
    }


    public void SetText()
    {
        if (text)
        {
            text.CrossFadeAlpha(1, 0, true);
            text.CrossFadeAlpha(0, 3, true);
        }
    }
}
