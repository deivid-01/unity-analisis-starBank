using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public class AccountUI 
{
    public Text id;
    public Text totalBalannce;
    public Text state;
  
    public BranchOfficeUI openingBranchOffice;
    public List<OperationsUI> operations = new List<OperationsUI>();

}
