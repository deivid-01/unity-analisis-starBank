using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartApp : MonoBehaviour
{
    public string nextSceneName;
    void Update()
    {
        if ( Input.anyKeyDown )
        {
            
            GameEvent.instance.OpenNextScene ( nextSceneName );
        }
    }
}
