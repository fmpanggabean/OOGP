using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAction : MonoBehaviour, IAction
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform anchor;
    [SerializeField] private float shootingPower;

    public void Execute()
    {
        GameObject go = SpawnProjectile();
        Projectile p = go.GetComponent<Projectile>();
        p.SetVelocity(anchor, shootingPower);
    }

    private GameObject SpawnProjectile()
    {
        return Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
