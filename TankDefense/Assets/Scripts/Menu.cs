using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public GUISkin skinMenu;
    public Texture2D Playy;
    public Texture2D titulo;
    public Texture2D btnSair;

    private Gerenciador gerenciador;

    // Use this for initialization
    void Start()
    {

        gerenciador = FindObjectOfType(typeof(Gerenciador)) as Gerenciador;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.skin = skinMenu;
        //GUI.DrawTexture(new Rect(Screen.width / 2 - titulo.width / 2, 150,
        //titulo.width, titulo.height), titulo);

       // bool Playy = GUI.Button("btnStart", true);

        //bool sair = GUI.Button(new Rect(Screen.width / 2 - 93, Screen.height / 2 + 150, 100, 100), btnSair);


        if (Playy)
        {
            gerenciador.ProximoLevel(gerenciador.proximoLevel);
        }

        //if (sair)
        //{
        //    Application.Quit();
        //}
    }
}
