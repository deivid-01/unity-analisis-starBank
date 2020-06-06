using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public class CompanyUI 
{
    public Text txtFullName;
    public  Text txtId;
    public  Text txtOccupation;
    public Text txtAddress;
    public  Text txtContactNumber;
    public  Text txtNIT;
    public  Text txtCompanyName;
    public  Text txtCommercialSector;

    public GameObject texts;

    public void ShowData () {
        ShowData ( ClientController.Client );
        texts.SetActive ( true );
    }

    public void ShowData ( Company client )
    {
        txtFullName.text = client.FullName;
        txtId.text = "Id: " + client.iD;
        txtOccupation.text = "Occupation: " + client.Occupation;
        txtAddress.text = "Address: " + client.Address;
        txtContactNumber.text = "Phone: " + client.ContactNum;
        txtCompanyName.text = "Company : " + client.CompanyName;
        txtNIT.text = "NIT: " + client.nIT;
        txtCommercialSector.text = "Commercial sector: " + client.CommercialSector;
    }
}
