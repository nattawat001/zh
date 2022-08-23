using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public AudioClip firearm;
    AudioSource asource;
    
    // Start is called before the first frame update
    void Start()
    {
        asource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            asource.PlayOneShot(firearm);
        }
    }
}
