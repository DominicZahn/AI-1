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
        private Board board;

        private void Awake()
        {
            board = new Board(3);
            Debug.Log(board.ToString());
        }
    }
}