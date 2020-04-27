using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Crashier : MonoBehaviour,IClientFunctions,IAccountFunctions
{

    protected dynamic client = null;

    #region Account Functions

    public void DeleteAccount() { }
    public void EnableAccount() { }
    public void DisableAccount() { }

    public void WithDraw() { }
    public void Consignment() { }
    #endregion

    #region Client Functions

    public void LogIn(string userName,string pass) {

       client =DataBase.Instance.SearchClient(userName, pass);

      // if (client == null) { Debug.Log("el usuario no existe"); return; } 

        LoadClient();
      

    }

    public void LoadClient()
    {
        if (client.GetType() == typeof(NaturalPerson)) NaturalPerson.Instance = client;
        else if (client.GetType() == typeof(Company)) Company.Instance = client;
        DataBase.Instance.LoadAccounts(client.id);
    }

    public void CreateCLient()
    {
        //
    }

    public void DeleteClient() {
       DataBase.Instance.DeleteClient(client.id);
        client = null;
        //Exit
    }

    public void EnableClient() { }
    public void DisableClient() { }

    #endregion

}

