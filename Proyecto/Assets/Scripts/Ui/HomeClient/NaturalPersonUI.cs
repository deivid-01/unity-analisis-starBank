using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public class NaturalPersonUI
{
    
    public Text txtFullName;
    public  Text txtId;
    public  Text txtOccupation;
    public Text txtAddress;
    public  Text txtContactNumber;

    public GameObject texts;


    public void ShowData () {
        ShowData ( ClientController.Client );
        texts.SetActive ( true );
    }

    public void ShowData ( NaturalPerson client )
    {
        txtFullName.text = client.FullName;
        txtId.text = "Id: " + client.iD;
        txtOccupation.text = "Occupation: " + client.Occupation;
        txtAddress.text = "Address: " + client.Address;
        txtContactNumber.text = "Phone: " + client.ContactNum;

    }
}
