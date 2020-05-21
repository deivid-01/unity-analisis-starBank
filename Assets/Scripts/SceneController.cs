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

    void Start ()
    {
        if (isNew)
        {
            GameEvent.instance.OpenScene += OpenNextScene;       
        }
    }

    void OpenNextScene ( int index )
    {

        SceneManager.LoadScene ( index );
    }
    
}
