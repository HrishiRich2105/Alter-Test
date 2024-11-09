using UnityEngine;
using UnityEngine.VFX;

public class ElectricWeapon : Weapon
{
    public VisualEffect electricEffect; // Assign this in the Inspector
    public GameObject electricModel; // Assign the 3D model

    public override void Attack()
    {
        Debug.Log("Electric attack!");
        electricEffect.Play();
    }
}
