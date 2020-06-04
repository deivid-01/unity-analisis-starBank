using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Bson;

public class BranchOffice 
{
    public ObjectId _id;
    private string ID;
    private string city;
    private string password;
    private string address;

    private List<Operation> operations;

    public List<Operation> Operations
    {
        get { return operations; }
        set { operations = value; }
    }


    public string iD { get => ID; set => ID = value; }
    public string City { get => city; set => city = value; }
    public string Password { get => password; set => password = value; }
    public string Address { get => address; set => address = value; }


}
