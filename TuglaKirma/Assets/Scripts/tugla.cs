using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tugla : MonoBehaviour
{
    public GameObject kirilmaEfekti;
    public AudioClip sesEfektiTuglaKirilma;
    public AudioClip sesEfektiTuglaCarpma;
    public static int toplamTuglaSayisi;
    public Sprite[] tuglaSprite; //array(Sprite[])--> bir de�i�ken i�inde birden fazla de�i�keni tutmak i�in kullan�l�r.
    private int maxCarpmaSayisi;
    private int carpmaSayisi;
    private Puan puanScripti;

    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length + 1;
        toplamTuglaSayisi++;
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("top"))
        {
            puanScripti.PuanArttir();
            carpmaSayisi++;
            if(carpmaSayisi >=maxCarpmaSayisi)
            {
                toplamTuglaSayisi--;
                Debug.Log(toplamTuglaSayisi);
                if (toplamTuglaSayisi <= 0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
                }
                Vector3 pos = collision.contacts[0].point; 
                GameObject go = Instantiate(kirilmaEfekti, pos, Quaternion.identity) as GameObject;
                Color tuglaRengi = GetComponent<SpriteRenderer> ().color; //bu scriptin ba�l� oldu�u tu�lan�n spriterender�
                go.GetComponent<ParticleSystemRenderer> ().material.color = tuglaRengi;
                Destroy(go, 1f);
                AudioSource.PlayClipAtPoint(sesEfektiTuglaKirilma, transform.position);
                Destroy(gameObject);
            }
            else
            {
                AudioSource.PlayClipAtPoint(sesEfektiTuglaCarpma, transform.position);
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1];
            }
        }
    }
}
