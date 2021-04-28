using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

public class Modes : MonoBehaviour
{
    public void LEDSwitch(){
       UduinoManager.Instance.sendCommand("1");
    }
}
