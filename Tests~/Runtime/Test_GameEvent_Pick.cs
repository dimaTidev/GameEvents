using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_GameEvent_Pick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
                hit.collider.gameObject.SetActive(false);
        }
    }
}
