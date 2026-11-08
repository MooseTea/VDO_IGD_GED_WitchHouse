using Unity.Mathematics;
using UnityEngine;

public class Switch : MonoBehaviour, IClick
{
   Light GetLight;
   AudioSource MyAudio;

    void Start()
    {
       GetLight = GetComponent<Light>();
        MyAudio = GetComponent<AudioSource>();
    }
public void OnClick()
    {
        GetLight.enabled = !GetLight.enabled;
        if (MyAudio != null)
        { 
            MyAudio.Play();
        }
    }
   
   
}
