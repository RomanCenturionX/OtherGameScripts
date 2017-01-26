﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Enemy
{
    public void FindPatients(Enemy[] enemyList, UnityEngine.AI.NavMeshAgent agent)
    {
        int healthMin = 110;
        int temp, id = -1;

        for (int i = 0; i < enemyList.Length; i++)
        {
            temp = enemyList[i].health;
            if (temp < healthMin && temp != 0)
            {
                healthMin = temp;
                id = i;
            }
        }

        if (healthMin >= 100)
            healing = false;
        else if (healthMin < 100)
        {
            goal = enemyList[id].self.transform;
            agent.destination = goal.position;

            //TODO: Heal the dude here
        }
    }
}