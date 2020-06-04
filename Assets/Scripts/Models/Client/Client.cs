﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Bson;

public abstract class Client
    
{
    public ObjectId _id;
    private string  ID;
    private int contactNum;
    private string fullName;
    private string occupation;
    private string address;

    private List<CheckingAccount> checkingAccounts=new List<CheckingAccount>();
    private List<SavingAccount> savingAccounts=new List<SavingAccount>();

    public string iD { get => ID; set => ID = value; }
    public int ContactNum { get => contactNum; set => contactNum = value; }
    public string FullName { get => fullName; set => fullName = value; }
    public string Occupation { get => occupation; set => occupation = value; }
    public string Address { get => address; set => address = value; }
    public List<CheckingAccount> CheckingAccounts { get => checkingAccounts; set => checkingAccounts = value; }
    public List<SavingAccount> SavingAccounts { get => savingAccounts; set => savingAccounts = value; }
}

