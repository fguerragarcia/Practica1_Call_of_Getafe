using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyListo : EnemyMobile
{
    [SerializeField] int followDistance;
    [SerializeField] float distanceToPlayer;

    void Update()
    {
        base.Update();
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer <= followDistance)
        {

            Vector3 target = new Vector3(player.transform.position.x, transform.position.z, transform.position.y);

            estado = ESTADO.Siguiendo;
            transform.LookAt(player.transform);

        }
        else {
            estado = ESTADO.Normal;
        }
    }
}
