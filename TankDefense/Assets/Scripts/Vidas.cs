using UnityEngine;
using System.Collections;

public class Vidas : MonoBehaviour {

	public Texture2D[] vidaAtual;
	private int vidas;
	private int contador;
		
	// Use this for initialization
	void Start ()
    {
        Debug.Log("textoStart " + vidas);
        GetComponent<GUITexture>().texture = vidaAtual [0];
		vidas = vidaAtual.Length;
        Debug.Log("textoVida " + vidas);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public bool ExcluirVida()
	{
        Debug.Log("EntrouExcluirVida " + vidas);
		if (vidas < 0) {
			
			return false;
			
		}
		
		if (contador < (vidas - 1)) {
            //contador += 1;
            //GetComponent<GUITexture>().texture = vidaAtual[contador];
            //return true;

            contador += 1;
            GetComponent<GUITexture>().texture = vidaAtual[contador];
           
            Debug.Log("Morreuuuuu " + vidaAtual);
            return true;
			
		} else {
			
			return false;
			
		}
		
	}
}
