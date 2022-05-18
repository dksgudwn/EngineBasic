// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PositionAutoDestroyer : MonoBehaviour
// {
//     [SerializeField]StageData stageData;
//     float destroyWeigth = 2f;
//     private void LateUpdate()
//     {
//         if(transform.position.x>stageData.LimitMax.x||
//         transform.position.x<stageData.LimitMin.x||
//         transform.position.y>stageData.LimitMax.y||
//         transform.position.y<stageData.LimitMin.y)
//         {
//             Destroy(gameObject);
//         }
//     }
// }
