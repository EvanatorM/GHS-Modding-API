using GHS_Modding_API.Interfaces;
using GHS_Modding_API.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GHS_Modding_API.StaticClasses
{
    public static class PlayerMovement
    {
        public static List<IPlayerMovement> playerMovements = new();

        public static void OnPlayerMove(Vector2 input, Player player)
        {
            foreach (IPlayerMovement move in playerMovements)
            {
                player.SetVelocity(move.OnMove(input, player.GetVelocity(), player.GetSpeed()));
            }
        }

        #region ModLoader

        public static void AddPlayerMovement(object obj)
        {
            playerMovements.Add((IPlayerMovement)obj);
        }

        #endregion
    }
}
