using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Weapon currentWeapon;
    public Weapon fireWeapon;
    public Weapon iceWeapon;
    public Weapon electricWeapon;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EquipWeapon(fireWeapon);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EquipWeapon(iceWeapon);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EquipWeapon(electricWeapon);
        }

        if (Input.GetButtonDown("Fire1") && currentWeapon != null)
        {
            currentWeapon.Attack();
        }
    }

    public void EquipWeapon(Weapon weapon)
    {
        if (currentWeapon != null)
        {
            currentWeapon.gameObject.SetActive(false);
        }
        currentWeapon = weapon;
        currentWeapon.gameObject.SetActive(true);
    }
}
