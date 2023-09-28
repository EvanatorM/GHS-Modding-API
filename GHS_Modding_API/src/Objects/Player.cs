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
        private float speed = 10f;
        private Vector3 velocity = Vector3.Zero;

        #region Constructors

        public Player() { }

        public Player(float speed)
        {
            this.speed = speed;
        }

        #endregion

        #region Getters/Setters

        // Speed
        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        public void AddSpeed(float speed)
        {
            this.speed += speed;
        }

        public float GetSpeed()
        {
            return speed;
        }

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
    }
}
