using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeBranchofficeUI : MonoBehaviour
{

    #region  Branch office data
    public Text txtID;
    public Text txtCity;
    public  Text txtAddress;

    #endregion


    public GameObject btnAddNewClient;
    public GameObject btnClientKind;


    public GameObject windowMessageFail;

    public string nameNextxSceneSearch;

        

    #region Singlenton

    public static HomeBranchofficeUI instance;

    private void Awake ()
    {
        instance = this;
    }

    #endregion
    void Start ()
    {
        GameEvent.instance.OnClientFound += ClientFound;
        GameEvent.instance.OnClientDontFound += ClientDontFound;

        SetTextValues ( BranchOfficeController.branchOffice );
    }

    public  void SetTextValues ( BranchOffice branchOffice )
    {
        txtID.text = branchOffice.iD;
        txtCity.text = branchOffice.City;
        txtAddress.text = branchOffice.Address;
    }



    public void ClientFound ()
    {
        GameEvent.instance.OpenNextScene ( "HomeClient" );
    }

    public void ClientDontFound ()
    {
        StartCoroutine ( ShowWindow ( windowMessageFail ) );
    }


    public void ShowKindOfClients ()
    {
        btnAddNewClient.SetActive ( false );
        btnClientKind.SetActive ( true );
    }

    public void ShowNaturalPersonUI ( string nextSceneName )
    {
        GameEvent.instance.OpenNextScene ( nextSceneName );
    }

    public void ShowCompanyIU ( string nextSceneName )
    {
        //Account account= new Account();

        
        GameEvent.instance.OpenNextScene ( nextSceneName );
    }

    public void ReadIdDocument ( InputField idDocument )
    {
        BranchOfficeController.CheckId ( idDocument.text.ToString () );

    }

    IEnumerator ShowWindow ( GameObject window )
    {
        window.SetActive ( true );
        yield return new WaitForSeconds ( 1f );
        window.SetActive ( false );
    }

}
