using Unity.Mathematics;
using UnityEngine;

public class Lightswitch : MonoBehaviour, IClick
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
        MyAudio.enabled = !MyAudio.enabled;
    }
   
   
}
