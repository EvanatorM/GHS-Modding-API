using System.Numerics;

namespace GHS_Modding_API.Interfaces
{
    public interface IPlayerMovement
    {
        Vector3 OnMove(Vector2 input, Vector3 currentVelocity);
    }
}