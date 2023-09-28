using GHS_Modding_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GHS_Modding_API.Objects
{
    public class Player
    {
        private Vector3 velocity = Vector3.Zero;

        public static List<IPlayerMovement> playerMovements = new();

        #region Methods

        public void OnPlayerMove(Vector2 input)
        {
            foreach (IPlayerMovement move in playerMovements)
            {
                velocity = move.OnMove(input, velocity);
            }
        }

        #endregion

        #region Getters/Setters

        // Velocity
        public void SetVelocity(Vector3 velocity)
        {
            this.velocity = velocity;
        }

        public void AddVelocity(Vector3 velocity)
        {
            this.velocity += velocity;
        }

        public Vector3 GetVelocity()
        {
            return velocity;
        }

        #endregion

        #region Mod Loader

        public static void AddPlayerMovement(object obj)
        {
            playerMovements.Add((IPlayerMovement)obj);
        }

        #endregion
    }
}
