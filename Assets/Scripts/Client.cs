using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Abstract Classses
public abstract  class Client 
{
    #region Composition Classes

    #region Abstract Classes
    
    public  abstract class Account {

        #region Composition Classes
        
        public class Operation
        {
        }
        #endregion

        public List<Operation> operations = new List<Operation>();       

    }

    #endregion

    #region  Classes
    public class SavingAccount : Account {

    }
    public class CheckingAccount : Account
    {

    }
    #endregion
    #endregion

    protected string id;

    public List<SavingAccount> saving = new List<SavingAccount>();
    public List<CheckingAccount> checking = new List<CheckingAccount>();

    public string Id { get => id; set => id = value; }
}

#endregion

#region Classes
public class NaturalPerson : Client
{
    public static NaturalPerson Instance;


    public NaturalPerson()
    {
        Instance = this;
    }
}


public class Company : Client
{
    public static Company Instance = null;

    public Company()
    {

        Instance = this;
    }

}

#endregion