using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class ClientController : MonoBehaviour
{

    #region Singlenton
    public static ClientController instance;

    private static dynamic client;

    private void Awake ()
    {
        instance = this;
    }

    private void Start ()
    {
        GameEvent.instance.OnDeleteClient += DeleteClient;
    }

    public  void DeleteClient () {
        //Delete from dataBase
        Debug.Log ( "Deleted client" );

        GameEvent.instance.OpenNextScene ( "HomeOfficeBranch" );
    }
    #endregion

    public static void SetClient( dynamic cli ) {
        client = cli;
    }

}
