using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class Main : MonoBehaviour
    {
        private void Awake()
        {
            Matrix m1 = new Matrix(new double[2, 4] { { 2, 3, 5, 7 }, { 1, 2, 0, 2 } });
            Debug.Log(m1.ToString());
            for (int i = 1; i < 4; i++)
            {
                m1.applyFunction((value) => { return i * value; });
                Debug.Log(m1.ToString());
            }
        }

        private double square(double value)
        {
            return value * value;
        }
    }
}
