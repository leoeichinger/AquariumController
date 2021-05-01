using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempManager : MonoBehaviour
{
    float oldTemp;
    public float newTemp;
    int correction = 953;
    public Transform ht;

    void Start() 
    {
        InvokeRepeating("SaveOldTemp",0,0.1f);
        InvokeRepeating("CheckForChange",0.2f,0.2f);
    }

    void SaveOldTemp()
    {
        oldTemp = newTemp;
    }

    void CheckForChange()
    {

        if (oldTemp != newTemp)
        {   
            newTemp *= 35.2f;
            ht.position = new Vector3(540, correction + newTemp, 0);
        }
    }
}
