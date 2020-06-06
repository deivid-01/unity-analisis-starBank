using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddCompanyUI : MonoBehaviour
{
    [Header("Inputs Data")]
    public InputField inputFullName;
    public  InputField inputId;
    public  InputField inputOccupation;
    public InputField inputAddress;
    public  InputField inputContactNumber;
    public  InputField inputNIT;
    public  InputField inputCompanyName;
    public  InputField inputCommercialSector;

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


    private CompanyData data;

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

    public void ReadData () => data = new CompanyData ( inputFullName.text ,
                                                             inputId.text ,
                                                             inputOccupation.text ,
                                                             inputAddress.text ,
                                                             inputContactNumber.text ,
                                                             inputNIT.text ,
                                                             inputCompanyName.text ,
                                                             inputCommercialSector.text );
    public void ReadDatawithSavingAccount () => ClientController.CheckClient ( AccountController.Kind.saving , data );
    public void ReadDatawithCheckingAccount () => ClientController.CheckClient ( AccountController.Kind.checking , data );

    public void ShowWindowFail () => StartCoroutine ( ShowWindow ( windowMessageFail ) );

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
