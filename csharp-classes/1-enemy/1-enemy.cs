using System;

namespace Enemies
{
    /// <summary>
    /// Public class Zombie with health
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Zombie's HP
        /// </summary>
        public int health;

        /// <summary>
        /// Zombie object with setting health to 0
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
    }
}