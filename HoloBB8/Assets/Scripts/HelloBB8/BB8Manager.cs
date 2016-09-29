using UnityEngine;
using System.Collections;
using HoloToolkit.Unity;

public class BB8Manager : Singleton<BB8Manager>
{
    public AudioSource source;
    public AudioClip walkClip;
    public AudioClip talkClip;
    bool dropped = false;
    Vector3 _OriginalPosition;
    Quaternion _OriginalRotation;

    public void DoAction(string action)
    {
        string animation = "";
        AudioClip audioClip = null;

        switch (action)
        {
            default:
                break;
            case "Walk":
                {
                    animation = "BB8Walk";
                    audioClip = walkClip;
                    break;
                }
            case "Talk":
                {
                    animation = "BB8Talk";
                    audioClip = talkClip;
                    break;
                }
        }

        var animator = gameObject.GetComponent<Animator>();

        animator.Play(animation);
        source.clip = audioClip;
        source.Play();
    }

    // Use this for initialization
    void Start()
    {
        _OriginalPosition = transform.localPosition;
        _OriginalRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnSelect()
    {
        if (dropped)
        {
            DoAction("Walk");
        }
        else
        {
            var rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody.collisionDetectionMode = CollisionDetectionMode.Continuous;
            rigidBody.useGravity = true;
            dropped = true;
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        var rigidBody = gameObject.GetComponent<Rigidbody>();
        rigidBody.collisionDetectionMode = CollisionDetectionMode.Discrete;
        rigidBody.useGravity = true;
        gameObject.transform.localRotation.Set(_OriginalRotation.x, _OriginalRotation.y, _OriginalRotation.z, _OriginalRotation.w);
    }
}