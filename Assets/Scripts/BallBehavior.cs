using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float x = 0;
    public float y = 0;

	public float xSpeed = 2;
	public float ySpeed = 3;

	// Start is called before the first frame update
	private void Start()
    {
        
    }

	// Update is called once per frame
	private void Update()
    {
		// start your code here!

		x += xSpeed * Time.deltaTime;
		y += ySpeed * Time.deltaTime;

		if(x > 10)
		{
			x = 10;
			xSpeed = -xSpeed;
		}
		if(x < -10)
		{
			x = -10;
			xSpeed = -xSpeed;
		}
		if(y > 10)
		{
			y = 10;
			ySpeed = -ySpeed;
		}
		if(y < -10)
		{
			y = -10;
			ySpeed = -ySpeed;
		}

		// end your code here! Leave code under here alone.

        transform.position = new Vector2(x, y);
    }

	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log("OnCollisionEnter: " + collision.gameObject.name);


	}
}
