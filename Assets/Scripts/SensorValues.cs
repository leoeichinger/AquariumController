using UnityEngine;
using Uduino;

public class SensorValues : MonoBehaviour
{
    UduinoManager uduino = UduinoManager.Instance;
    float temp;
    UduinoDevice board;
    void Start() 
    {
        uduino.pinMode(18, PinMode.Input); 
    }
    void Awake() 
    {
        board = uduino.GetBoard("80LNano");
    }
    void Update()
    {
        temp = uduino.analogRead(board, 18);
        Debug.Log(temp);
    }

    

}