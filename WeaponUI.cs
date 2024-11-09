using UnityEngine;
using UnityEngine.UI;

public class WeaponUI : MonoBehaviour
{
    public Text currentWeaponText;
    public Button fireButton;
    public Button iceButton;
    public Button electricityButton;
    public WeaponManager weaponManager;

    void Start()
    {
        // Assign button listeners
        fireButton.onClick.AddListener(SetFireWeapon);
        iceButton.onClick.AddListener(SetIceWeapon);
        electricityButton.onClick.AddListener(SetElectricWeapon);

        // Initialize the current weapon display
        UpdateWeaponText("None");
    }

    public void SetFireWeapon()
    {
        weaponManager.EquipWeapon(weaponManager.fireWeapon);
        UpdateWeaponText("Fire");
    }

    public void SetIceWeapon()
    {
        weaponManager.EquipWeapon(weaponManager.iceWeapon);
        UpdateWeaponText("Ice");
    }

    public void SetElectricWeapon()
    {
        weaponManager.EquipWeapon(weaponManager.electricWeapon);
        UpdateWeaponText("Electricity");
    }

    void UpdateWeaponText(string weaponName)
    {
        currentWeaponText.text = "Current Weapon: " + weaponName;
    }
}
