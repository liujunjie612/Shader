using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    public GameObject go;

    void Start()
    {
        go.GetComponent<Image>().alphaHitTestMinimumThreshold = 1.0f;
        EventTriggerListener.Get(go).onEnter = OnEnter;
    }

    private void OnEnter(GameObject go)
    {
        Debug.Log("ppppppppp");
    }
}
