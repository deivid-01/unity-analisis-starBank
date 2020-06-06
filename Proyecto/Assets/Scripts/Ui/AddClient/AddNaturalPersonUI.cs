using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNaturalPersonUI : MonoBehaviour
{
    [Header("Inputs Data")]
    public InputField txtFullName;
    public  InputField txtId;
    public  InputField txtOccupation;
    public InputField txtAddress;
    public  InputField txtContactNumber;

    [Space]

    [Header("GameObject btns")]
    public GameObject btnAddAcount;
    public GameObject btnKindAccount;

    [Space]

    [Header("Windows messages")]
    public GameObject windowMessageFail;

    [Space]

    [Header("Next scenes")]
    public string nextSceneName;


    private NaturalPersonData data;

    public void Start ()
    {
        GameEvent.instance.OnAddClientFail += ShowWindowFail;
        GameEvent.instance.OnAddClientSucceded += CloseWindow;
    }

    public void ShowKindAccounts ()
    {
        btnAddAcount.SetActive ( false );
        btnKindAccount.SetActive ( true );
    }

    public void ReadData () => data = new NaturalPersonData ( txtFullName.text ,
                                                             txtId.text ,
                                                             txtOccupation.text ,
                                                             txtAddress.text ,
                                                             txtContactNumber.text ); 
    public void ReadDatawithSavingAccount () => ClientController.CheckClient ( AccountController.Kind.saving , data );
    public void ReadDatawithCheckingAccount () => ClientController.CheckClient ( AccountController.Kind.checking , data );

    public void ShowWindowFail () {
        StartCoroutine ( ShowWindow ( windowMessageFail ) );
        
    } 

    IEnumerator ShowWindow ( GameObject window )
    {
        window.SetActive ( true );
        yield return new WaitForSeconds ( 1f );
        window.SetActive ( false );
        btnAddAcount.SetActive ( true );
        btnKindAccount.SetActive ( false );
    }

    public void CloseWindow () => GameEvent.instance.OpenNextScene ( nextSceneName );
    


}
