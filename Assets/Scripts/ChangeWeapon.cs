using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    public GameObject macheteSprite, pistolSprite, goldenMacheteSprite;
    public GameObject macheteHitbox, pistolHitbox, goldenMacheteHitbox;
    private PlayerAimWeapon aimWeapon;

    private void Awake()
    {
        aimWeapon = GetComponent<PlayerAimWeapon>();
    }

    public void SwitchWeapon(string weaponName)
    {
        macheteSprite.SetActive(weaponName == "Machete");
        pistolSprite.SetActive(weaponName == "FlintlockPistol");
        goldenMacheteSprite.SetActive(weaponName == "GoldenMachete");

        macheteHitbox.SetActive(weaponName == "Machete");
        pistolHitbox.SetActive(weaponName == "FlintlockPistol");
        goldenMacheteHitbox.SetActive(weaponName == "GoldenMachete");

        switch (weaponName)
        {
            case "Machete":
                aimWeapon.EquipMachete();
                break;
            case "FlintlockPistol":
                aimWeapon.EquipPistol();
                break;
            case "GoldenMachete":
                aimWeapon.EquipGoldenMachete();
                break;
            default:
                break;
        }
    }
}