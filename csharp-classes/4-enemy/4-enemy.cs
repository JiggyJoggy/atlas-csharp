using System;

namespace Enemies
{
    /// <summary>
    /// Public class Zombie with health
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Zombie's field(s)
        /// health
        /// name (Default is equal to (No name))
        /// </summary>
        private int health;
        private string name = "(No name)";


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
        /// Returns name of Zombie
        /// Default name is (No name)
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
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