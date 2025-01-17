﻿using UnityEngine;

public static class Utils2
{
    public static bool IsInLineOfSight(this Transform origin, Vector3 target, float fieldOfView, LayerMask layer, Vector3 offset)
    {
        Vector3 direction = target - origin.position;

        if (Vector3.Angle(origin.forward, direction.normalized) < fieldOfView / 2)
        {
            float distanceToTarget = Vector3.Distance(origin.position, target);

            if (Physics.Raycast(origin.forward + offset + origin.forward * .3f, direction.normalized, distanceToTarget, layer))
                return false;

            return true;
        }

        return false;
    }
}