using UnityEngine.UI;
using UnityEngine;

public class MovingImage : MonoBehaviour
{
    public Image image;

    float xPos;
    public bool moveRight;
    public bool moveLeft;
    float movementspeed;

    void Start() 
    {
        
    }
    void Update()
    {
        movementspeed = Time.deltaTime *40 ;
        xPos = image.transform.position.x;

        if (xPos == 1503.48f)
        {
            moveRight = true;
        }
        if (xPos == -423.48f)
        {
            moveRight = false;
        }

        if (moveRight)
        {
            image.transform.Translate(movementspeed * -1,0,0);
        }
        else
        {
            image.transform.Translate(movementspeed,0,0);
        }
    }
}
