using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTorre : Enemy
{
    private float distanceToPlayer;
    [SerializeField] float attackDistance;
    [SerializeField] float speed;

    private void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer < attackDistance) {
            transform.LookAt(player.transform);
            Quaternion q = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, Time.deltaTime * speed);
        }
    }
}
