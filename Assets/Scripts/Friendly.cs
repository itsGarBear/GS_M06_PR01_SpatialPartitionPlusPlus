using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpatialPartitionPattern
{
    public class Friendly : Soldier
    {
        public Friendly(GameObject soldierObj, float mapWidth)
        {
            this.soldierTrans = soldierObj.transform;
            this.soldierMeshRenderer = soldierObj.GetComponent<MeshRenderer>();
            this.soldierMeshRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
            this.walkSpeed = 2f;
        }

        public override void Move(Soldier closestEnemy)
        {
            soldierTrans.rotation = Quaternion.LookRotation(closestEnemy.soldierTrans.position - soldierTrans.position);
            soldierTrans.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
        }
    }
}
