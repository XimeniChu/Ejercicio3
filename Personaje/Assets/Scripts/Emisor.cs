using UnityEngine;
using System.Collections;

public class Emisor : MonoBehaviour {
	public GameObject PelotaPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float pos;
		pos = Random.Range (-10, 10);
		Vector3 newPos = new Vector3 (this.transform.position.x+pos, this.transform.position.y, this.transform.position.z );
		//Instantiate (PelotaPrefab, this.transform.position, Quaternion.identity);
		Instantiate (PelotaPrefab, newPos, Quaternion.identity);
	}
}
