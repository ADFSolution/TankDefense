using UnityEngine;
using System.Collections;

public class Acelerometro : MonoBehaviour {
	public float speed = 2.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Input.acceleration.x, 0, 0);


	}
	
}
