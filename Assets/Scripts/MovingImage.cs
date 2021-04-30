using UnityEngine.UI;
using UnityEngine;

public class MovingImage : MonoBehaviour
{
    public Image image;

    float xPos;
    public bool moveRight;
    float movementspeed;

    void Update()
    {
        movementspeed = Time.deltaTime * 20 ;
        xPos = image.transform.position.x;

        if (image.transform.position.x >= 1503.48f)
        {
            moveRight = true;
        }
        if (image.transform.position.x <= -423.48f)
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
