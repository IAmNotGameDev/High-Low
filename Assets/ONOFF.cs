using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONOFF : MonoBehaviour
{
    public GameObject gm;
    public bool gmboll = false;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            gm.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            gm.SetActive(true);
        }
    }

    public void oN()
    {
        gm.SetActive(true);
    }
    public void oFF()
    {
        gm.SetActive(false);
    }

}

