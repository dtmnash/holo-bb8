using UnityEngine;
using System.Collections;

public class PlayAudioOnInput : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip audioClip;
    public InputType input;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnGazeEnter()
    {
        if(input == InputType.Gaze)
        {
            PlayAudioClip.PlayAudio(audioSource, audioClip);
        }
    }
}

public enum InputType
{
    Gaze,
    HandPressed, 
}
