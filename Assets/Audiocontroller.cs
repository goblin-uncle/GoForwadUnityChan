using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiocontroller : MonoBehaviour
{
    //çƒê∂Ç∑ÇÈblockÇÃBGM
    public AudioSource audioClip;
    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Groundtag")
        {
            audioSource = GetComponent<AudioSource>();
            
            audioSource.Play();
        }
        else if(other.gameObject.tag =="Cubetag")
        {
            audioSource = GetComponent<AudioSource>();

            audioSource.Play();
        }

    }
}
