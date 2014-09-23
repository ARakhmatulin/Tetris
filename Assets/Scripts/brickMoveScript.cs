using UnityEngine;
using System.Collections;

public class brickMoveScript : MonoBehaviour {

	public float speed = 5;
	//
	public KeyCode keyUp		 = KeyCode.W;
	public KeyCode keyLeft		 = KeyCode.A;
	public KeyCode keyDown		 = KeyCode.S;
	public KeyCode keyRight		 = KeyCode.D;

	//
	private Vector3 pos;
	private float v_speed;

	private float X;
	private float Y;

	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		X = 0f;
		Y = 0f;

		bool valid_pos = transform.position.y == pos.y
			&& transform.position.x == pos.x;

		//speed = 0
		if(valid_pos
		   && v_speed != 0){
			v_speed = 0;
		}

		if (Input.GetKeyDown(keyUp) && valid_pos){
			movingUp();
		}
		if (Input.GetKeyDown(keyDown) && valid_pos){
			movingDown();
		}
		if (Input.GetKeyDown(keyLeft) && valid_pos){
			movingLeft();
		}
		if (Input.GetKeyDown(keyRight) && valid_pos){
			movingRight();
		}


		//moving
		transform.position = Vector3.MoveTowards(transform.position, pos, v_speed * Time.deltaTime);

	}
	
	void movingUp(){
		Y = 1;
		v_speed = speed;
		//new position
		Moving(X,Y);
	}

	void movingDown(){
		Y = -1;
		v_speed = speed;
		//new position
		Moving(X,Y);
	}

	void movingLeft(){
		X = -1;
		v_speed = speed;
		//new position
		Moving(X,Y);
	}

	void movingRight(){
		X = 1;
		v_speed = speed;
		//new position
		Moving(X,Y);
	}

	void Moving(float X, float Y){

		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;

		//new position
		pos = new Vector3(x + X,y + Y ,z);
	}

}
