using UnityEngine;
using System.Collections;

public class Acelerometro : MonoBehaviour {
	public float speed = 2.0F;
    private Gerenciador gerenciador;
	// Use this for initialization
	void Start () {
        gerenciador = FindObjectOfType(typeof(Gerenciador)) as Gerenciador;
        gerenciador.StartGame();
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Input.acceleration.x, 0, 0);


	}
	
}
