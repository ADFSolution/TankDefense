using UnityEngine;
using System.Collections;

public class Bomba : MonoBehaviour {

	public int ponto = 2;
	public float tempoMaximoVida;
	
	public float tempoVida;
	private Gerenciador gerenciador;
	private Vidas vida;
    private SpecialEffect effect;
    private GameObject nave;
    private Gerenciador gerencia;
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
         
        if (colisor.gameObject.tag == "Nave")
        {
            
			vida = GameObject.FindGameObjectWithTag("Vidas").GetComponent<Vidas>() as Vidas;
			
			if (vida.ExcluirVida())
            {
				
				Handheld.Vibrate();
				//score.TiraPonto(ponto);
				gerenciador.AddQuantidade(1); 
               
				Destroy(gameObject);
                //Instantiate<SpecialEffect>().Explosion(transform.position);
                //GetComponent<SpecialEffect>().Explosion(transform.position);
                //effect = GetComponent<SpecialEffect>();
                SpecialEffect.Instance.Explosion(transform.position);
                nave = GameObject.FindGameObjectWithTag("Nave");
                Destroy(nave);
                //System.Threading.Thread.Sleep(3);
                Debug.Log("11111PASSSSSOUUUUU");
                gerenciador.StartGame();
                Debug.Log("PASSSSSOUUUUU");
                
               }else{
				gerenciador.GameOver("GameOver");				
			}
            
		}
		
		
		
	}
}
