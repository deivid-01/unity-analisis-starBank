using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClientFunctions 
{
    void LogIn(string userName, string pass);

    void LoadClient();

    void CreateCLient();

    void DeleteClient();

    void EnableClient();

    void DisableClient();



}
