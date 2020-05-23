using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIaddClient : MonoBehaviour
{
    public GameObject btnAddAcount;
    public GameObject btnKindAccount;
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
    }
    public void AddCheckingAccount ()
    {
        //Display another button
    }

    public void DeleteClient () { 
        //Confirmation message
    }

}
