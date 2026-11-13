using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DoorInteraction : MonoBehaviour, IClick
{
[SerializeField] Animator Anim;

    public void OnClick()
    {
        bool getState = Anim.GetBool("_Open");
        Anim.SetBool("_Open", !getState);
    }
}
