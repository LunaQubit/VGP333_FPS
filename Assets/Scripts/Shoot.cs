using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour 
{

    public Rigidbody bullet;
    public float speed;

	
	void Start () 
    {
	
	}
	
	
	void Update () 
    {
	    if( Input.GetButtonDown( "1" ) )
        {
            Rigidbody instantiatedBullet = Instantiate( bullet, transform.position, transform.rotation ) as Rigidbody;
            instantiatedBullet.velocity = transform.TransformDirection( new Vector3( 0, 0, speed ) );
        }
	}
}
