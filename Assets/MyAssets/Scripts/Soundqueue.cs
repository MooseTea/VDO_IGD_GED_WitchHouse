using Unity.Mathematics;
using UnityEngine;

public class Soundqueue : MonoBehaviour, IClick
{
   AudioSource MyAudio;
    
    void Start()
    {
       MyAudio = GetComponent<AudioSource>();
    }
public void OnClick()
    {
        MyAudio.enabled = !MyAudio.enabled;
        MyAudio.Play();
        //MyAudio.enabled = !MyAudio.enabled;
        //if (MyAudio != null)
        {
           // MyAudio.Play();
        }
    }
   
   
}
