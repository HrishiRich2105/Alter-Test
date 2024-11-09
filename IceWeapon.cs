using UnityEngine;
using UnityEngine.VFX;

public class IceWeapon : Weapon
{
    public VisualEffect iceEffect; // Assign this in the Inspector
    public GameObject iceModel; // Assign the 3D model

    public override void Attack()
    {
        Debug.Log("Ice attack!");
        iceEffect.Play();
    }
}
