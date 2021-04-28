using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

public class SensorReadings : MonoBehaviour
{

    public SensorValues values;

    void Start()
    {
        UduinoManager.Instance.OnDataReceived += DataReceived;
    }

    void DataReceived(string data, UduinoDevice board)
    {
        values.data = data.Split(new char[]{' '}, System.StringSplitOptions.RemoveEmptyEntries);
    }
}