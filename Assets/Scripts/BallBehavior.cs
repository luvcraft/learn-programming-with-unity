using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private float x = 0;
    private float y = 0;

	// Start is called before the first frame update
	private void Start()
    {
        
    }

	// Update is called once per frame
	private void Update()
    {
        // start your code here!

        x = 0;



        // end your code here! Leave code under here alone.

        transform.position = new Vector2(x, y);
    }

	private void OnCollisionEnter(Collision collision)
	{
		
	}
}
