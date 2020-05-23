using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginController
{

    #region Singlenton
    public static LoginController instance;

    public void Awake ()
    {
        instance = this;
    }
    #endregion

    public void Start () {
  
    }
    
    public static void CheckLogin ( string id , string passw )
    {
        if ( id.Length == 0 || passw.Length == 0 )
        {
            GameEvent.instance.FailLogin ();
            return;
        }

        //if//SearchDataInDataBase
        GameEvent.instance.LoginSucceded ();


        //else
        // GameEvent.instance.FailLogin();

    }


}
