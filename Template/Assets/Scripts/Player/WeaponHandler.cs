using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponHandler : MonoBehaviour
{
    public Transform firePoint;
    public float fireRate = 0.3f;

    private float fireTimer;
    private PlayerInput inputActions;
    private bool isFiring;

    void Awake()
    {
        inputActions = new PlayerInput();
    }

    void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.Fire.performed += ctx => isFiring = true;
        inputActions.Player.Fire.canceled += ctx => isFiring = false;
    }

    void OnDisable()
    {
        inputActions.Disable();
    }

    void Update()
    {
        fireTimer += Time.deltaTime;

        if (isFiring && fireTimer >= fireRate)
        {
            Fire();
            fireTimer = 0f;
        }
    }

    void Fire()
    {
        GameObject bullet = BulletPool.Instance.GetBullet();
        bullet.transform.position = firePoint.position;
        bullet.transform.rotation = firePoint.rotation;
    }
}
