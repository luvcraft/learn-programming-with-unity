using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtensionToolbox;
using System.Collections.Specialized;

public class MainBehavior : MonoBehaviour
{
    public Transform ball;

    private float x = 0;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // start your code here!

        x = 0;



        // end your code here! Leave code under here alone.

        UpdateBallPosition();
    }

    void UpdateBallPosition()
    {
        ball.position = new Vector2(x, y);
    }
}
