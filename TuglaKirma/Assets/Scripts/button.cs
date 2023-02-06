using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void DigerSahne()
    {
        tugla.toplamTuglaSayisi = 0;
        GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().puanSifirla();
        SceneManager.LoadScene("bolum1");
    }
}
