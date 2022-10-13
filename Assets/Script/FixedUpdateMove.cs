using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FixedUpdateMove
{
    public class FixedUpdateMove : MonoBehaviour
    {
        public float speed = 0.5f;
        void FixedUpdate()
        {
            this.transform.Translate(0, 0, Time.deltaTime * speed);
        }
    }
}

