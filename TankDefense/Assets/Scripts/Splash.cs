using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]

public class Splash : MonoBehaviour {

    public MovieTexture video;

    // Use this for initialization
	void Start () {

    #if UNITY_ANDROID
        Handheld.PlayFullScreenMovie("splash.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
        Application.LoadLevel("StartGame");
#endif

#if UNITY_STANDALONE_WIN

        AudioSource audio = GetComponent<AudioSource>();
        GetComponent<Renderer>().material.mainTexture = video as MovieTexture;
        audio.clip = video.audioClip;
        video.Play();
        audio.Play();
        
    #endif
	}
	
	// Update is called once per frame
	void OnMouseDown()
    {
    #if UNITY_STANDALONE_WIN
        video.Stop();
        Application.LoadLevel("StartGame");
    #endif
    }


    void Update()
    {
    #if UNITY_STANDALONE_WIN
        if (!video.isPlaying)
        {
            Application.LoadLevel("StartGame");
        }
    #endif
    }
}
