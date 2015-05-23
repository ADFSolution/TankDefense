using UnityEngine;
using System.Collections;

public class Bomba : MonoBehaviour {

	public int ponto = 2;
	public float tempoMaximoVida;
	
	public float tempoVida;
	private Gerenciador gerenciador;
	private Vidas vida;
	//private Score score;

	void Awake()
	{
		//score = GameObject.FindGameObjectWithTag("Pontos").GetComponent<Score>() as Score;
		gerenciador = FindObjectOfType(typeof(Gerenciador)) as Gerenciador;
		
	}
	
		
	// Update is called once per frame
	void Update ()
	{
		
		tempoVida += Time.deltaTime;
		if (tempoVida >= tempoMaximoVida)
		{
			
			Destroy(gameObject);
			tempoVida = 0;
			
		}
		
	}
	
	void OnCollisionEnter2D(Collision2D colisor)
	{
		
		if (colisor.gameObject.tag == "Player") {
			
			vida = GameObject.FindGameObjectWithTag("Vidas").GetComponent<Vidas>() as Vidas;
			
			if (vida.ExcluirVida()){
				
				Handheld.Vibrate();
				//score.TiraPonto(ponto);
				gerenciador.AddQuantidade(1); 
               
				Destroy(gameObject);
                //SpecialEffect.Instantiate<Explosion>(transform.position);
                GetComponent<SpecialEffect>().Explosion(transform.position);
               }else{
				
				gerenciador.GameOver("GameOver");
				
			}
			
		}
		
		
		
	}
}
