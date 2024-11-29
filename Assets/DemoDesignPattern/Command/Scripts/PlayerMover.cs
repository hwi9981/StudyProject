using UnityEngine;

namespace CommandPattern
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private LayerMask obstacleLayer;
        [SerializeField] private float _step = 1f;
        private const float boardSpacing = 1f;

        public void Move(Vector3 movement)
        {
            transform.forward = movement;
            transform.position += movement * _step;
        }

        public bool IsValidMove(Vector3 movement)
        {
            return !Physics.Raycast(transform.position, movement, boardSpacing, obstacleLayer);
        }
    }
}