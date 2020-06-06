using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class ClientController : MonoBehaviour
{
    #region Singlenton
    public static ClientController instance;

    // private static dynamic client;



    private void Awake ()
    {
        instance = this;
    }
    #endregion
    private static dynamic client;
    public static dynamic Client
    {
        get { return client; }
        set
        {         
            client = value;           
        }
    }
    public static Kind kindClient;
    private void Start ()
    {
        GameEvent.instance.OnDeleteClient += DeleteClient;
    }

    public void DeleteClient ()
    {
        //Delete from dataBase
        Debug.Log ( "Deleted client" );
        GameEvent.instance.OpenNextScene ( "HomeOfficeBranch" );
    }

    public static void CheckClient ( AccountController.Kind kind , NaturalPersonData data )
    {
        if ( !NaturalPersonData.VerifyData ( data ) )
        {
            GameEvent.instance.AddClientFail();
            return;
        }

        CreateClient ( kind , data );
        GameEvent.instance.AddClientSucceded();
    }
    public static void CheckClient ( AccountController.Kind kind , CompanyData data )
    {
        if ( !CompanyData.VerifyData ( data ) )
        {
            GameEvent.instance.AddClientFail ();
            return;
        }

        CreateClient ( kind , data );
        GameEvent.instance.AddClientSucceded ();

    }

    public static void CreateClient ( AccountController.Kind kind , CompanyData data )
    {
        kindClient = ClientController.Kind.company;
        Client = new Company ( data.id , data.contactNumber , data.fullName , data.occupation , data.address , data.NIT , data.companyName , data.commercialSector );
        AccountController.CreateAccountOf ( kind );
    }
    public static void CreateClient ( AccountController.Kind kind , NaturalPersonData data )
    {
        kindClient = ClientController.Kind.natural;
        Client = new NaturalPerson ( data.id , data.contactNumber , data.fullName , data.occupation , data.address );
        AccountController.CreateAccountOf (  kind );
    }

    public enum Kind
    {
        company,
        natural
    }

}
