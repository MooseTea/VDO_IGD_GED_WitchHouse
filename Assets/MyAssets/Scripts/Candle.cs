using UnityEngine;

public class Candle : MonoBehaviour, IClick
{
    Light GetLight;
    public AudioSource BlowOut;
    public AudioSource Matchstrike;

    void Start()
    {
        GetLight = GetComponent<Light>();
        GetLight.enabled = true;
    }

    public void OnClick()
    {
        GetLight.enabled = !GetLight.enabled;

        if (GetLight.enabled)
        {
            Matchstrike.Play();
        }
        else
        {
            BlowOut.Play();
        }
    }
}