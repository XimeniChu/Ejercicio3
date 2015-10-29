using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 25;
	}
	
	// Update is called once per frame
	void Update () {
		//moveFoward ();
	}
	
	//mueve al personaje
	public void moveLeft()
	{
		Debug.Log ("Hola");
		//this.transform.position = new Vector3 (2, 0, 1);

		//Vector3.foward
		//Vector3.up
		//Vector3.down
		this.transform.Translate ((Time.deltaTime * speed) * Vector3.left);
	}
	public void moveRight()
	{
		Debug.Log ("Hola");
		//this.transform.position = new Vector3 (2, 0, 1);
		
		//Vector3.foward
		//Vector3.up
		//Vector3.down
		this.transform.Translate ((Time.deltaTime * speed) * Vector3.right);
	}
}
