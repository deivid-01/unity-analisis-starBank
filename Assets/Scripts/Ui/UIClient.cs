using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIClient : MonoBehaviour
{
    public GameObject btnAddAcount;
    public GameObject btnKindAccount;

    public List<GameObject>btnAccounts =new List<GameObject>();
    public GameObject confirmationWindow;
    void Start()
    {
        
    }

    // Update is called once per frameas
    void Update()
    {
        
    }

    public void ShowKindAccounts () {
        btnAddAcount.SetActive ( false );
        btnKindAccount.SetActive ( true );
    }

    public void AddSavingAccount () {
        //Display another button
        EnablebtnAccounts ();
    }
    public void AddCheckingAccount ()
    {
        EnablebtnAccounts ();

        //Display another button
    }

    public void DeleteClient () {
        ShowWindow ( confirmationWindow );
    }

    public void ShowAccount (string nextScene) {
        GameEvent.instance.OpenNextScene ( nextScene);
    }

    void ShowWindow ( GameObject window )
    {
        window.SetActive ( true );     
    }

    void HideWindow ( GameObject window )
    {
        window.SetActive ( false );
    }


    public void DeleteClient ( bool answer ) {

        if ( answer )
        {
            GameEvent.instance.DeleteClient ();
        }
        else
        {
            HideWindow ( confirmationWindow );
        }
    }

    public void EnablebtnAccounts () {

        foreach ( var item in btnAccounts )
        {
            if ( !item.activeInHierarchy )
            {
                item.SetActive ( true );
                break;
            }
        }
    
    }

    public void Back ()
    {
        GameEvent.instance.OpenNextScene ( "HomeOfficeBranch" );
    }
}
