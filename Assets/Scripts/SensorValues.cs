using UnityEngine;
using Uduino;

public class SensorValues : MonoBehaviour
{
    UduinoManager uduino;
    float temp;
    UduinoDevice board;
    void Start() 
    {
        uduino.pinMode(18, PinMode.Input); 
        uduino = UduinoManager.Instance;
        board = uduino.GetBoard("80LNano");
    }
    void Update()
    {
        temp = uduino.analogRead(board, 18);
        Debug.Log(temp);
    }

    

}