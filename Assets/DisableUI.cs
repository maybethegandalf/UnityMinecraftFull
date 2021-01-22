using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableUI : MonoBehaviour
{
    bool visible = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (visible)
                DisableAllUI();
            else
                EnableAllUI();
        }
    }

    void DisableAllUI()
    {
        this.gameObject.GetComponent<Canvas>().enabled = false;
        visible = false;
    }

    void EnableAllUI()
    {
        this.gameObject.GetComponent<Canvas>().enabled = true;
        visible = true;
    }
}
