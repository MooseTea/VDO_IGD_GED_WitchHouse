using Unity.Mathematics;
using UnityEngine;

public class Lightswitch : MonoBehaviour, IClick
{
   Light GetLight;

    void Start()
    {
       GetLight = GetComponent<Light>();
    }
public void OnClick()
    {
        GetLight.enabled = !GetLight.enabled;
    }
   
   
}
