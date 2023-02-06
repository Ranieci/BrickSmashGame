using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplanmuzik : MonoBehaviour
{
    static bool SahnedeMuzikVar;
    // Start is called before the first frame update
    void Start()
    {
        if (!SahnedeMuzikVar) 
        { 
            GameObject.DontDestroyOnLoad(this.gameObject); //dontdestroyonload->diðer sahneye geçerken, yüklenirken bu objeyi objeyi yok etme
            SahnedeMuzikVar = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
