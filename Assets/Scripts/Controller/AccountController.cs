using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {

    }

    public static void ActiveInactiveAccount () {
        //Disable or active account
        Debug.Log ( "Account has been active o disable" );
    }

    public static void DeleteAccount ()
    {
        //Delete account
        Debug.Log ( "Account has been deleted" );
    }

    public static void WithDraw (string amount) { 
        Debug.Log ( "Amount withdrawn: "+ amount);

    }

    public static void Allocate (string amount)
    {
        Debug.Log ( "Amount allocated: " + amount );

    }
}
