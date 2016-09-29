using UnityEngine;
using System.Collections;
using HoloToolkit.Unity;

public class PlayAudioClip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public  static void PlayAudio(AudioSource source, AudioClip clip)
    {
        if (!source)
            return;

        if (!clip)
            return;

        source.clip = clip;
        source.Play();
    }
}
