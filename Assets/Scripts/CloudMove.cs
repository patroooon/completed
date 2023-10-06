using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TestXlab
{
    public class CloudMove : MonoBehaviour
    {
        public Transform cloud;
        public GameObject rain;
        public List<Transform> cloudPoints = new List<Transform>();
        public float speed;
        public float offsetYPosition;
        public CloudMove cloudMove;
        public bool isNeedToMove = false;
        public int currentPointIndex = -1;
        public const float error = 0.1f;
        public void MoveToNextPoint()
        {
            if (currentPointIndex + 1 < cloudPoints.Count)
            {
                currentPointIndex++;
            }
            else
            {
                currentPointIndex = 0;
            }

            isNeedToMove = true;
            rain.SetActive(false);
        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
               // cloudMove.MoveToNextPoint();
            }

            {
                if (isNeedToMove == false)
                    return;

                Vector3 targetPos = cloudPoints[currentPointIndex].position + new Vector3(0, offsetYPosition, 0);

                Vector3 direction = targetPos - cloud.position;

                if (Vector3.Distance(cloud.position, targetPos) > error)
                {
                    cloud.Translate(direction * (speed * Time.deltaTime));
                }
                else
                {
                    isNeedToMove = false;
                    rain.SetActive(true);
                }

            }


        }

    }
}