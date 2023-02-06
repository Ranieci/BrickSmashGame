using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraAnimasyon : MonoBehaviour
{
    private Vector3 ilkpos;
    // Start is called before the first frame update
    void Start()
    {
        ilkpos = transform.position;
        transform.position = new Vector3(ilkpos.x, ilkpos.y - 6f, ilkpos.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, ilkpos, 2 * Time.deltaTime);  
    }
}
