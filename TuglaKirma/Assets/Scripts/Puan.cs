using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    private int puan;
    public void PuanArttir()
    {
        puan++;
    }
    public int PuaniAl()
    {
        return puan;
    }
    public void puanSifirla()
    {
        puan = 0;
    }
}
