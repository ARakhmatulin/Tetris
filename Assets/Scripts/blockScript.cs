using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

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

	private bool validPosBricks = false;

	// Use this for initialization
	void Awake () {
		X_pos = Random.Range(2,9);
		Y_pos = 20;
		createBricks();
	}
	
	void Start () {

	}
	
	void Update () {
		CheckPositionBricks();
	}

	public Transform[] getBricks(){
		return Bricks;
	}

	public void Move(int X, int Y){
		if(validPosBricks == false){return;}

		for (int i = 0; i<Bricks.Length;i++){
			BrickScript _brick = Bricks[i].gameObject.GetComponent<BrickScript>();
			_brick.Move(X,Y);
		}
	}

	void CheckPositionBricks(){
		validPosBricks = true;
//		for (int i = 0; i<Bricks.Length;i++){
//			BrickScript _brick = Bricks[i].gameObject.GetComponent<BrickScript>();
//			validPosBricks = _brick.validPos;
//			//
//			if(_brick.validPos == false){break;}
//
//		}
	}

	void createBricks(){

		Vector3[] bricksPositions = getBricksPositions();
		int L = (int)bricksPositions.Length;
		Bricks = new Transform[L];

		for (int i = 0; i<Bricks.Length;i++){
			Bricks[i] = Instantiate(Brick,bricksPositions[i],Quaternion.identity) as Transform;
		}

	}
	
	public void rotateBlock(){

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

		Vector3 pos_1 = Vector3.zero;
		Vector3 pos_0 = Vector3.zero;
		Vector3 pos_2 = Vector3.zero;
		Vector3 pos_3 = Vector3.zero;

		if(viewBlock == 0){ //J
			pos_1 = new Vector3(X_pos,		Y_pos,transform.position.z);
			pos_0 = new Vector3(X_pos-1,	Y_pos,transform.position.z);
			pos_2 = new Vector3(X_pos,		Y_pos+1,transform.position.z);
			pos_3 = new Vector3(X_pos,		Y_pos+2,transform.position.z);			
		}
		else if(viewBlock == 1){ //L
			pos_1 = new Vector3(X_pos,		Y_pos,transform.position.z);
			pos_0 = new Vector3(X_pos+1,	Y_pos,transform.position.z);
			pos_2 = new Vector3(X_pos,		Y_pos+1,transform.position.z);
			pos_3 = new Vector3(X_pos,		Y_pos+2,transform.position.z);			
		}
		else if(viewBlock == 2){ //O
			pos_1 = new Vector3(X_pos,		Y_pos,transform.position.z);
			pos_0 = new Vector3(X_pos+1,	Y_pos,transform.position.z);
			pos_2 = new Vector3(X_pos+1,	Y_pos+1,transform.position.z);
			pos_3 = new Vector3(X_pos,		Y_pos+1,transform.position.z);			
		}
		else if(viewBlock == 3){ //T
			pos_1 = new Vector3(X_pos,		Y_pos,transform.position.z);
			pos_0 = new Vector3(X_pos+1,	Y_pos,transform.position.z);
			pos_2 = new Vector3(X_pos-1,	Y_pos,transform.position.z);
			pos_3 = new Vector3(X_pos,		Y_pos-1,transform.position.z);			
		}
		else if(viewBlock == 4){ //Z
			pos_1 = new Vector3(X_pos,		Y_pos,transform.position.z);
			pos_0 = new Vector3(X_pos,		Y_pos-1,transform.position.z);
			pos_2 = new Vector3(X_pos+1,	Y_pos,transform.position.z);
			pos_3 = new Vector3(X_pos+1,	Y_pos+1,transform.position.z);			
		}
		else if(viewBlock == 5){ //S
			pos_1 = new Vector3(X_pos,		Y_pos,transform.position.z);
			pos_0 = new Vector3(X_pos,		Y_pos-1,transform.position.z);
			pos_2 = new Vector3(X_pos-1,	Y_pos,transform.position.z);
			pos_3 = new Vector3(X_pos-1,	Y_pos+1,transform.position.z);			
		}
		else if(viewBlock == 6){ //I
			pos_1 = new Vector3(X_pos,		Y_pos,transform.position.z);
			pos_0 = new Vector3(X_pos,		Y_pos-1,transform.position.z);
			pos_2 = new Vector3(X_pos,		Y_pos+1,transform.position.z);
			pos_3 = new Vector3(X_pos,		Y_pos+2,transform.position.z);			
		}
		
		bricksPositions[0] = pos_0;
		bricksPositions[1] = pos_1;
		bricksPositions[2] = pos_2;
		bricksPositions[3] = pos_3;
		
		return bricksPositions;
	}

}
