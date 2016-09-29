using UnityEngine;
using System.Collections;

public class PlayAudioOnInput : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public InputType input;
    bool animated = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGazeEnter()
    {
        if (input == InputType.Gaze)
        {
            PlayAudioClip.PlayAudio(audioSource, audioClip);

            if (!animated)
            {
                var animator = gameObject.GetComponent<Animator>();
                if (!animator)
                    throw new System.Exception("AAH");

                animator.Play("BB8Talk");
            }
        }
    }

    void OnSelect()
    {

    }
}

public enum InputType
{
    Gaze,
    HandPressed,
}
