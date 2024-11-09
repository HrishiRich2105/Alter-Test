using UnityEngine;
using UnityEngine.VFX;

public class FireWeapon : Weapon
{
    public VisualEffect fireEffect; // Assign this in the Inspector
    public GameObject fireModel; // Assign the 3D model

    public override void Attack()
    {
        Debug.Log("Fire attack!");
        fireEffect.Play();
    }
}
