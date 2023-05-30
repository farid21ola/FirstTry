using UnityEngine;

namespace Eccentric {

    public class CameraMove : MonoBehaviour {

        public float mouseSensitivity = 0.4f;

        private Vector3 _mousePreviousPos;
        private float _rotationX;
        private float _rotationY;

        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        void Update() {

            Rotate();
        }
        void Rotate() {

            Vector3 _mouseDelta;
            _mouseDelta = Input.mousePosition - _mousePreviousPos;
            _mousePreviousPos = Input.mousePosition;

            _rotationX -= _mouseDelta.y * mouseSensitivity;
            _rotationY += _mouseDelta.x * mouseSensitivity;

            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0f);
        }

    }

}

