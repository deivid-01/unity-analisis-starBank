using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class AccountsUI
{
    public GameObject btnAddAcount;
    public GameObject btnKindAccount;
    public List<Button>btnAccounts =new List<Button>();

    [Space]
    public Text txtTotalBalance;

    public void ShowKindAccounts ()
    {
        btnAddAcount.SetActive ( false );
        btnKindAccount.SetActive ( true );
    }

    public void ShowAccounts ( dynamic client )
    {

        int totalBalance=0;
        foreach ( SavingAccount sAccount in client.SavingAccounts )
        {
            totalBalance += sAccount.Balance;
            foreach ( Button btn in btnAccounts )
            {
                if ( !btn.gameObject.activeInHierarchy )
                {
                    btn.GetComponentInChildren<Text> ().text = "Saving Account id: " + sAccount._id.ToString ();
                    btn.gameObject.SetActive ( true );
                    break;
                }
            }
        }

        foreach ( CheckingAccount cAccount in client.CheckingAccounts )
        {
            totalBalance += cAccount.Balance;
            foreach ( Button btn in btnAccounts )
            {
                if ( !btn.gameObject.activeInHierarchy )
                {
                    btn.GetComponentInChildren<Text> ().text = "Checking Account id: " + cAccount._id.ToString ();
                    btn.gameObject.SetActive ( true );
                    break;
                }
            }
        }
        txtTotalBalance.text= totalBalance.ToString();
    }

    public void LoadAccount ( string id )  => AccountController.SetAccount ( id );

    public void ShowTotalBalance ( int total ) => txtTotalBalance.text = total.ToString ();

    public void AddSavingAccount ()
    {
        AccountController.CreateAccountOf ( AccountController.Kind.saving );
        DisableAllAccountBtn ();
        ShowAccounts ( ClientController.Client );
    }

    public void AddCheckingAccount ()
    {
        AccountController.CreateAccountOf ( AccountController.Kind.checking );
        DisableAllAccountBtn ();
        ShowAccounts ( ClientController.Client );
    }

    public void DisableAllAccountBtn () {

        foreach ( Button button in btnAccounts )
        {
            button.gameObject.SetActive ( false );
        }
    }
}
