using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    #region Singlenton
    public static SceneController instance;
    private bool isNew=false;
    private void Awake ()
    {
        if ( instance == null )
        {
            instance = this;
            GameObject.DontDestroyOnLoad ( instance.gameObject );
            isNew = true;

        }

    }

    #endregion 

    public string name;
    void Start ()
    {
        if (isNew)
        {
            GameEvent.instance.OpenScene += OpenNextScene;          
           
        }
    }

    void OpenNextScene ( string n ) { 
        SceneManager.LoadScene ( n );

    }

  

   


}
