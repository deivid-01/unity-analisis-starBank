using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Bson;

public abstract class Client
    
{
    public ObjectId _id;
    private string  ID;
    private string contactNum;
    private string fullName;
    private string occupation;
    private string address;

    private List<CheckingAccount> checkingAccounts=new List<CheckingAccount>();
    private List<SavingAccount> savingAccounts=new List<SavingAccount>();

    protected Client (string iD , string contactNum , string fullName , string occupation , string address )
    {

        _id = ObjectId.GenerateNewId ();
        ID = iD;
        this.contactNum = contactNum;
        this.fullName = fullName;
        this.occupation = occupation;
        this.address = address;
    
    }

    public string iD { get => ID; set => ID = value; }
    public string ContactNum { get => contactNum; set => contactNum = value; }
    public string FullName { get => fullName; set => fullName = value; }
    public string Occupation { get => occupation; set => occupation = value; }
    public string Address { get => address; set => address = value; }
    public List<CheckingAccount> CheckingAccounts { get => checkingAccounts; set => checkingAccounts = value; }
    public List<SavingAccount> SavingAccounts { get => savingAccounts; set { savingAccounts = value;  } }
}

