using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public int timePeriod = 3;

	public Transform Block_O;
	public Transform Block_J;
	public Transform Block_L;
	public Transform Block_Z;
	public Transform Block_S;
	public Transform Block_T;
	public Transform Block_I;

	//
	public KeyCode startGame = KeyCode.N;

	//
	private float deltaTime;
	private Transform Block;
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
		deltaTime = deltaTime + Time.deltaTime;

		if(deltaTime >= timePeriod
		   && Block != null){

			//Block.moveDown();
		}

		if(Input.GetKeyDown(startGame)
		   && Block == null){
			CreateBlock();
			deltaTime = 0;
		}
	}

	void DestroyBlock(){

	}

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

		Block = (Transform)Instantiate(buf_block,new Vector3(0,0,0),Quaternion.identity);
	}
}
