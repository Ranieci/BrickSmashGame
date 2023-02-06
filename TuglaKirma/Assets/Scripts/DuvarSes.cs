using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarSes : MonoBehaviour
{
    public GameObject carpma;
    public AudioClip sesEfekti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(sesEfekti, transform.position);
        Vector3 pos = collision.contacts [0].point; //ilk çarpýþma noktasýný belirlemek için.
        GameObject go=Instantiate(carpma,pos, Quaternion.identity) as GameObject;
        Destroy(go, 1f); //1 saniye sonra objeyi ortadan kaldýr.
    }
}
