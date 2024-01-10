using System;

namespace Enemies
{
    /// <summary>
    /// Public class Zombie with health
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Zombie's private int health
        /// </summary>
        private int health;

        /// <summary>
        /// Zombie object with setting health to 0
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Sets health to the value given
        /// Throws an ArgumentException if health is less than 0
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            this.health = value;
        }

        /// <summary>
        /// Return Zombie's health
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return health;
        }
    }
}