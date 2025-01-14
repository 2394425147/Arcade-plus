using UnityEngine;
using UnityEngine.InputSystem;

namespace Arcade.Util.UnityExtension
{
	public static class CameraExtension
    {
        public static Ray ScreenPointToRay(this Camera camera)
        {
            return camera.ScreenPointToRay(Mouse.current.position.ReadValue());
        }
    }
}
