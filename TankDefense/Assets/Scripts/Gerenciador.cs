using UnityEngine;
using System.Collections;

public class Gerenciador : MonoBehaviour {

	public Vector2 posicaoInicialPlayer;
	public Transform player;
	public int levelAtual;
	public int proximoLevel;
	public int quantidadeColetada = 0;
	//variavel para passar de fase em quantidade
	private int quantidadeMaxima;	
	
	
	// Use this for initialization
	void Awake()
	{
		
		if (player != null)
		{
			posicaoInicialPlayer = player.position;
		}
		quantidadeMaxima = 5;
	}
	
	
	public bool IsColetado()
	{
		if (quantidadeColetada >= quantidadeMaxima)
		{
			Debug.Log("coletou");
			return true;
		}
		else
		{
			return false;
		}
	}
	
	public void StartGame()
	{
		player.position = posicaoInicialPlayer;
		Debug.Log(player.position);
		Debug.Log(posicaoInicialPlayer);
	}
	
	public void GameOver(string nome)
	{
		Application.LoadLevel(nome);
	}
	
	public void AddQuantidade(int quantidade)
	{
		quantidadeColetada += quantidade;
	}
	
	public void ProximoLevel(int level)
	{
		Application.LoadLevel (level);
	}
}
