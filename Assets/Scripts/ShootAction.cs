using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAction : MonoBehaviour, IAction
{
    [SerializeField] private GameObject projectilePrefab;

    public void Execute()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
