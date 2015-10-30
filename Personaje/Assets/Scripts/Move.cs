using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed;
	public float Dir;
	// Use this for initialization
	void Start () {
		speed = 5;
		Dir = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//moveFoward ();
		moveSiempre ();
	}
	
	//mueve al personaje
	public void moveLeft()
	{
		Dir = -1;
		//Debug.Log ("Hola");
		//this.transform.position = new Vector3 (2, 0, 1);

		//Vector3.foward
		//Vector3.up
		//Vector3.down
		this.transform.Translate ((Time.deltaTime * speed) * Vector3.left);
	}
	public void moveRight()
	{
		Dir = 1;
		//Debug.Log ("Hola");
		//this.transform.position = new Vector3 (2, 0, 1);
		
		//Vector3.foward
		//Vector3.up
		//Vector3.down
		//this.transform.Translate ((Time.deltaTime * speed * Dir) * Vector3.right);
	}
	public void moveSiempre()
	{
		this.transform.Translate ((Time.deltaTime * speed * Dir) * Vector3.right);
	}
}
