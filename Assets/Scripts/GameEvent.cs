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


    public event Action <int> OpenScene;


    public void OpenNextScene ( int index ) => OpenScene?.Invoke ( index );


    /*
    private void Update ()
    {
        if ( Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
        }
        else  if ( Input.GetKeyDown ( KeyCode.LeftArrow ) )
        {
            SceneManager.LoadScene ( SceneManager.GetActiveScene ().buildIndex - 1 );
        }
    }
    */
}
