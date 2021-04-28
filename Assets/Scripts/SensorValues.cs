using UnityEngine;
using System.Collections;

public class SensorValues : MonoBehaviour
{
    public string[] data;
    public string temp;
    public string hum;
    public string waterTemp;
    public string pH;
    public string tds;
    int i = 0;

    void Update()
    {
        
        foreach (string value in data)
        {
            if (data[i] == null)
            {
                Debug.Log("No data");
            }
            else
            {
                if (data[i].Contains("t"))
                {
                    temp = data[i].Substring(1);
                }
                if (data[i].Contains("h"))
                {
                    hum = data[i].Substring(1);
                }
                if (data[i].Contains("w"))
                {
                    waterTemp = data[i].Substring(1);
                }
                if (data[i].Contains("p"))
                {
                    pH = data[i].Substring(1);
                }
                if (data[i].Contains("l"))
                {
                    tds = data[i].Substring(1);
                }
                i++;   
            }
        }
        i = 0;
    }
}
