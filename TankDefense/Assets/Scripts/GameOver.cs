using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    private Gerenciador gerenciador;
    private GUISkin SKIN;


	// Use this for initialization
	void Start () {
        gerenciador = FindObjectOfType(typeof(Gerenciador)) as Gerenciador;
	}
	
	// Update is called once per frame
	void Update () {

        
	}

    void OnGUI()
    {
        GUI.skin = SKIN;


        if (GUI.Button(new Rect(Screen.width - 750, 350, 150, 50), "Start"))
        {
            gerenciador.ProximoLevel(gerenciador.proximoLevel);
        }

        if (GUI.Button(new Rect(Screen.width - 750, 420, 150, 50), "Exit"))
        {
            Application.Quit();
        }

    }

}
