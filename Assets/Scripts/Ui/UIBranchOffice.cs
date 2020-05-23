using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBranchOffice : MonoBehaviour
{

    public Text dataOffice;
    
    public GameObject btnAddNewClient;
    public GameObject btnClientKind;


    public GameObject windowMessageFail;

    public string nameNextxSceneSearch;

    #region Singlenton

    public static UIBranchOffice instance;

    private void Awake ()
    {
        instance = this;
    }

    #endregion
    void Start ()
    {
        GameEvent.instance.OnClientFound += ClientFound;
        GameEvent.instance.OnClientDontFound += ClientDontFound;


    }

    private void ShowData ()
    {
        Debug.Log ( "oli" );
        throw new System.NotImplementedException ();
    }

    // Update is called once per frame


    public void ClientFound ()
    {
        GameEvent.instance.OpenNextScene ( "HomeClient" );
    }

    public void ClientDontFound ()
    {
        StartCoroutine ( ShowWindow ( windowMessageFail ) );
    }


    public void ShowKindOfClients () {
        btnAddNewClient.SetActive ( false );
        btnClientKind.SetActive ( true  );
    }

    public void ShowNaturalPersonUI (string nextSceneName) {
        GameEvent.instance.OpenNextScene ( nextSceneName );
    }

    public void ShowCompanyIU ( string nextSceneName )
    {
        GameEvent.instance.OpenNextScene ( nextSceneName );
    }

    public void ReadIdDocument (InputField idDocument) {
        BranchOfficeController.CheckId( idDocument.text.ToString () );
                  
    }

    IEnumerator ShowWindow ( GameObject window )
    {
        window.SetActive ( true );
        yield return new WaitForSeconds ( 1f );
        window.SetActive ( false );
    }

}
