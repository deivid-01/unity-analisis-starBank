using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchOffice 
{

    public  List<NaturalPerson> naturalPeople;
    public  List<dynamic> clients;
    

    #region Singlenton
    public static BranchOffice Instance;
    void Awake() => Instance = this;
    void Start() => DataBase.Instance.LoadBranchOfficeData();
 
    
    #endregion
}
