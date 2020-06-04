using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginUI : MonoBehaviour
{
    public InputField id;
    public InputField passw;

    public GameObject windowMessageFail;


    public string nextSceneName;
    private void Start ()
    {
        GameEvent.instance.OnLoginSucceded += LoginSucceded;
        GameEvent.instance.OnLoginFail += LoginFail;
    }



   public  void ReadData () {
     
        LoginController.CheckLogin(id.text,passw.text);
    }

    public void LoginSucceded () {
        GameEvent.instance.OpenNextScene ( nextSceneName );
    }
    
    public void LoginFail () {
        StartCoroutine ( ShowWindow ( windowMessageFail ) );
        //Display error message
    }

    IEnumerator ShowWindow ( GameObject window ) {
        window.SetActive ( true );
        yield return new WaitForSeconds ( 1f );
        window.SetActive ( false);
    }
}
