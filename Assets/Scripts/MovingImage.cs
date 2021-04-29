using UnityEngine.UI;
using UnityEngine;

public class MovingImage : MonoBehaviour
{
    public Image image;

    float xPos;
    public bool moveRight;
    public bool moveLeft;

    public float right = -1;

    void Start() 
    {
        xPos = image.transform.position.x;    
    }
    void Update()
    {

        if (xPos == 963.48)
        {
            moveRight = true;
            moveLeft = false;
        }
        if (xPos == -963.48)
        {
            moveLeft = true;
            moveRight = false;
        }

        if (moveRight)
        {
            xPos = image.transform.position.x - 1; 
            image.transform.position = new Vector3(xPos,-0.64718f,0);
        }
        
    }
}
