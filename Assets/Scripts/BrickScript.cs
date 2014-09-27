using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {

	public float speed = 5;
    //
	private Vector3 pos;

	private float pos_x;
	private float pos_y;

	// Use this for initialization
	void Start () {
		pos_x = transform.position.x;
		pos_y = transform.position.y;

		pos = new Vector3(pos_x,pos_y,transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

		//moving
		transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);

	}

	public void Move(float X, float Y){

		float z = transform.position.z;

		pos_x = Mathf.Abs(Mathf.Abs(transform.position.x) - Mathf.Abs(pos_x))>=2?pos_x:pos_x + X ;
		pos_y = pos_y + Y;

		//new position
		pos = new Vector3(pos_x,pos_y,z);
	}

}
