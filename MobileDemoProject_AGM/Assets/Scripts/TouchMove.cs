using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    public Vector3 touchStartPos;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    // Record initial touch position. Save it as our touchStartPos
                    touchStartPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 30));
                    break;

                //Determine if the touch is a moving touch
                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 30));
                    direction = touchPosition - touchStartPos;
                    transform.position = direction;
                    break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    // maybe reset the touchStartPos?
                    // anyway, if we NEED to reset something, do it here

                    break;
            }
        }
    }
}
