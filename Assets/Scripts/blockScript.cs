using UnityEngine;
using System.Collections;

public class blockScript : MonoBehaviour {

	public KeyCode keyRotate = KeyCode.R;
	public Transform Brick;
	public int viewBlock;
	//viewBlock = 0 = J;
	//viewBlock = 1 = L;
	//viewBlock = 2 = O;
	//viewBlock = 3 = T;
	//viewBlock = 4 = Z;
	//viewBlock = 5 = S;
	//viewBlock = 6 = I;

	//start zero_brick position
	private int X_pos;
	private int Y_pos;

	//
	private Transform[] Bricks;
	private int Rotor;

	// Use this for initialization
	void Awake () {
		X = Random.Range(0,10);
		Y = 20;
		createBricks();
	}
	
	void Start () {
		//rot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(keyRotate)){
			//rotate
			rotateBlock();
		}
	}

	void createBricks(){

		int size = 4;
		Vector3[] bricksPositions() = getBricksPositions();
		
		Bricks[0] = Instantiate(Brick,bricksPositions[0],Quaternion.identity) as Transform;
		Bricks[1] = Instantiate(Brick,bricksPositions[1],Quaternion.identity) as Transform;
		Bricks[2] = Instantiate(Brick,bricksPositions[2],Quaternion.identity) as Transform;
		Bricks[3] = Instantiate(Brick,bricksPositions[3],Quaternion.identity) as Transform;

	}
	
	void rotateBlock(){

	}
	
	Vector3[] getBricksPositions(){

		//viewBlock = 0 = J;
		//viewBlock = 1 = L;
		//viewBlock = 2 = O;
		//viewBlock = 3 = T;
		//viewBlock = 4 = Z;
		//viewBlock = 5 = S;
		//viewBlock = 6 = I;

		Vector3[] bricksPositions = new Vector3[4];

		Vector3 pos_1;
		Vector3 pos_0;
		Vector3 pos_2;
		Vector3 pos_3;

		if(viewBlock == 0){ //J
			pos_1 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos,transform.position.z));
			pos_0 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos-1,Y_pos,transform.position.z));
			pos_2 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos+1,transform.position.z));
			pos_3 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos+2,transform.position.z));			
		}
		else if(viewBlock == 1){ //L
			pos_1 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos,transform.position.z));
			pos_0 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos+1,Y_pos,transform.position.z));
			pos_2 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos+1,transform.position.z));
			pos_3 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos+2,transform.position.z));			
		}
		else if(viewBlock == 2){ //O
			pos_1 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos,transform.position.z));
			pos_0 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos+1,Y_pos,transform.position.z));
			pos_2 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos+1,Y_pos+1,transform.position.z));
			pos_3 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos+1,transform.position.z));			
		}
		else if(viewBlock == 3){ //T
			pos_1 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos,transform.position.z));
			pos_0 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos+1,Y_pos,transform.position.z));
			pos_2 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos-1,Y_pos,transform.position.z));
			pos_3 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos-1,transform.position.z));			
		}
		else if(viewBlock == 4){ //Z
			pos_1 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos,transform.position.z));
			pos_0 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos-1,transform.position.z));
			pos_2 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos+1,Y_pos,transform.position.z));
			pos_3 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos+1,Y_pos+1,transform.position.z));			
		}
		else if(viewBlock == 5){ //S
			pos_1 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos,transform.position.z));
			pos_0 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos-1,transform.position.z));
			pos_2 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos-1,Y_pos,transform.position.z));
			pos_3 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos-1,Y_pos+1,transform.position.z));			
		}
		else if(viewBlock == 6){ //I
			pos_1 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos,transform.position.z));
			pos_0 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos-1,transform.position.z));
			pos_2 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos+1,transform.position.z));
			pos_3 = Camera.main.ViewportToWorldPoint(new Vector3(X_pos,Y_pos+2,transform.position.z));			
		}
		
		bricksPositions[0] = pos_0;
		bricksPositions[1] = pos_1;
		bricksPositions[2] = pos_2;
		bricksPositions[3] = pos_3;
		
		return bricksPositions;
	}

}
