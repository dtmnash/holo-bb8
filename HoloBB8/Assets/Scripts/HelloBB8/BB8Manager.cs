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
    bool intervalWalkComplete;

    #region The Action

    public void DoAction(string action)
    {
        string animation = "";

        #region Audio
        //AudioClip audioClip = null;
        #endregion

        switch (action)
        {
            default:
                break;
            case "Walk":
                {
                    animation = "BB8Walk";
                    #region Audio
                    //audioClip = walkClip;
                    #endregion
                    break;
                }
            case "Talk":
                {
                    animation = "BB8Talk";
                    #region Audio
                    //audioClip = talkClip;
                    #endregion
                    break;
                }
        }

        var animator = gameObject.GetComponent<Animator>();

        animator.Play(animation);
        #region Audio
        //source.clip = audioClip;
        #endregion
        source.Play();
    }

    #endregion

    // Use this for initialization
    void Start()
    {
        _OriginalPosition = transform.localPosition;
        _OriginalRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        #region timer
#if false
#endif 
        if(Time.time > 3 && intervalWalkComplete == false)
        {
            DoAction("Walk");
            intervalWalkComplete = true;
        }
#endregion
    }

    #region Select

    //void OnSelect()
    //{
    //    DoAction("Walk");
    //}

    #endregion

    #region Reset
    //public void Reset()
    //{
    //    gameObject.transform.localPosition = _OriginalPosition;
    //    gameObject.transform.localRotation = _OriginalRotation;
    //}
    #endregion
}