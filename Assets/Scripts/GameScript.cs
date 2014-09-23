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
	private float deltaTime;
	private Transform Block;
	
	// Use this for initialization
	void Start () {
		CreateBlock();
	}
	
	// Update is called once per frame
	void Update () {
		deltaTime = deltaTime + Time.deltaTime;
		
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
			Block = Instantiate(Block_J,new Vector3(0,0,0),Quaternion.identity) as Transform;
		}
		else if(i == 1){
			Block = Instantiate(Block_L,new Vector3(0,0,0),Quaternion.identity) as Transform;
		}
		else if(i == 2){
			Block = Instantiate(Block_O,new Vector3(0,0,0),Quaternion.identity) as Transform;
		}
		else if(i == 3){
			Block = Instantiate(Block_T,new Vector3(0,0,0),Quaternion.identity) as Transform;
		}
		else if(i == 4){
			Block = Instantiate(Block_Z,new Vector3(0,0,0),Quaternion.identity) as Transform;
		}
		else if(i == 5){
			Block = Instantiate(Block_S,new Vector3(0,0,0),Quaternion.identity) as Transform;
		}
		else if(i == 6){
			Block = Instantiate(Block_I,new Vector3(0,0,0),Quaternion.identity) as Transform;
		}
		

	}
}
