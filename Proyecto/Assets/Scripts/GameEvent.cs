using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class GameEvent : MonoBehaviour
{

    #region Singlenton
    public static GameEvent instance;

    private void Awake ()
    {
        if ( instance == null )
        {         
        instance = this;
        GameObject.DontDestroyOnLoad ( instance );     
        }
    }

    private void Start ()
    {
   
    }
    #endregion


    public event Action <string> OpenScene;
    public event Action  OnLoginSucceded;
    public event Action  OnLoginFail;
    public event Action  OnClientFound;
    public event Action  OnClientDontFound;
    public event Action  OnDeleteClient;
    public event Action ClientChanged;
    public event Action OnAddClientFail;
    public event Action OnAddClientSucceded;


    public void OpenNextScene ( string nameScene ) => OpenScene?.Invoke ( nameScene );
    public void LoginSucceded () => OnLoginSucceded?.Invoke ();
    public void FailLogin () => OnLoginFail?.Invoke ();
    public void ClientFound () => OnClientFound?.Invoke ();
    public void ClientDontFound () => OnClientDontFound?.Invoke ();
    public void DeleteClient () => OnDeleteClient?.Invoke ();

    public void UpdateClient () => ClientChanged?.Invoke ();

    public void AddClientFail () => OnAddClientFail?.Invoke ();

    public void AddClientSucceded () => OnAddClientSucceded?.Invoke ();
   


}
