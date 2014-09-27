using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public float timePeriod = 0.1f;

	public Transform Block_O;
	public Transform Block_J;
	public Transform Block_L;
	public Transform Block_Z;
	public Transform Block_S;
	public Transform Block_T;
	public Transform Block_I;

	//
	public KeyCode newBlock = KeyCode.N;
	public KeyCode destryBlock = KeyCode.K;

    public KeyCode keyRotate = KeyCode.R;

    public KeyCode keyUP = KeyCode.W;
    public KeyCode keyLEFT = KeyCode.A;
    public KeyCode keyDOWN = KeyCode.S;
    public KeyCode keyRIGHT = KeyCode.D;
	//
	private float deltaTime = 0;
	private Transform MainBlock;
	private Transform[][] BricksOnTable;

	//
	private Transform buf_block;

	//
	void Awake(){
		//BricksOnTable = new Transform[20][10];
	}

	// Use this for initialization
	void Start() {
		//CreateBlock();
	}
	
	// Update is called once per frame
	void Update () {

		if(MainBlock != null){deltaTime = deltaTime + Time.deltaTime;}
		else{deltaTime = 0;}

		if(deltaTime >= timePeriod
		   && MainBlock != null){
			deltaTime = 0;
			MoveDown();
		}

		if(Input.GetKeyDown(newBlock)
		   && MainBlock == null){
			CreateBlock();
			deltaTime = 0;
		}
		if (Input.GetKeyDown(destryBlock)){DestroyBlock();}
		if (Input.GetKeyDown(keyRotate)){RotateBlock();}
        if (Input.GetKeyDown(keyUP)){MoveUp();}
        if (Input.GetKeyDown(keyDOWN)){MoveDown();}
        if (Input.GetKeyDown(keyLEFT)){MoveLeft();}
        if (Input.GetKeyDown(keyRIGHT)){MoveRight();}
	}

	void RotateBlock(){
	}

	void DestroyBlock(){
		if(MainBlock != null){Destroy(MainBlock.gameObject);}
	}

	//////////////////
	/// MOVING
	void Move(int X, int Y){
		if(MainBlock == null){return;}
		
		BlockScript bScript = MainBlock.gameObject.GetComponent<BlockScript>();
		bScript.Move(X,Y);
	}
	
	void MoveDown(){Move(0,-1);}
	void MoveLeft(){Move(-1,0);}
	void MoveRight(){Move(1,0);}
	void MoveUp(){Move(0,1);}
	//////////////////

	void CreateBlock(){
		//viewBlock = 0 = J;
		//viewBlock = 1 = L;
		//viewBlock = 2 = O;
		//viewBlock = 3 = T;
		//viewBlock = 4 = Z;
		//viewBlock = 5 = S;
		//viewBlock = 6 = I;
		
		int i = Random.Range(0,6);


		if(i == 0){
			buf_block = Block_J;
		}
		else if(i == 1){
			buf_block = Block_L.transform;
		}
		else if(i == 2){
			buf_block = Block_O.transform;
		}
		else if(i == 3){
			buf_block = Block_T.transform;
		}
		else if(i == 4){
			buf_block = Block_Z.transform;
		}
		else if(i == 5){
			buf_block = Block_S.transform;
		}
		else if(i == 6){
			buf_block = Block_I.transform;
		}

		MainBlock = (Transform)Instantiate(buf_block,new Vector3(0,0,0),Quaternion.identity);
	}
}
