using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginController
{
  
    public static void CheckLogin ( string id , string passw )
    {
        if ( ( id.Length == 0 || passw.Length == 0 ) || !DataBaseController.instance.CheckLogin ( id , passw ) )
            
        {
            GameEvent.instance.FailLogin ();
            return;
        }
        GameEvent.instance.LoginSucceded ();
    }
}
