using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {

	public float speed = 5;
	
	//
	private Vector3 pos;
	private float v_speed;

	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		bool valid_pos = transform.position.y == pos.y
			&& transform.position.x == pos.x;

		//speed = 0
		if(valid_pos
		   && v_speed != 0){
			v_speed = 0;
		}

		//moving
		transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);

	}
	public void Move(float X, float Y){

		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;

		//new position
		pos = new Vector3(x + X,y + Y ,z);
	}

}
