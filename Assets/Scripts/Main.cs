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
            Matrix m2 = new Matrix(new double[2, 2] { { 2, 3 }, { 1, 0 } });
            Debug.Log((m1 * m2).ToString());
        }
    }
}
