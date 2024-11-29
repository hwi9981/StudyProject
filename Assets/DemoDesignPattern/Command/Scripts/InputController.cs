using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class InputController : MonoBehaviour
    {
        // Not complete!!!
        private void RunPlayerCommand(PlayerMover playerMover, Vector3 movement)
        {
            if (playerMover == null)
            {
                return;
            }
            if (playerMover.IsValidMove(movement))
            {
                ICommand command = new MoveCommand(playerMover, movement);
                CommandInvoker.ExecuteCommand(command);
            }
        }

        private void UndoMovement(PlayerMover playerMover)
        {
            if (playerMover == null)
            {
                return;
            }
            CommandInvoker.UndoCommand();
        }
        private void RedoMovement(PlayerMover playerMover)
        {
            if (playerMover == null)
            {
                return;
            }
            CommandInvoker.RedoCommand();
        }

        #region Control

        [SerializeField] private PlayerMover _player;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                RunPlayerCommand(_player, Vector3.forward);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                RunPlayerCommand(_player, Vector3.back);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                RunPlayerCommand(_player, Vector2.left);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                RunPlayerCommand(_player, Vector2.right);
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                UndoMovement(_player);
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                RedoMovement(_player);
            }
        }

        #endregion
    }

}
