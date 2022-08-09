using System;

namespace Enemies
{
    /// <summary>
    /// Define the enemie Zombie
    /// </summary>
    class Zombie
    {
        /// <value>The health of the zombie</value>
        public int health;

        /// <summary>Constructor for Zombie, set health at 0</summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>Initialized an instance of Zombie</summary>
        /// <param name="value">The value of the health</param>
        /// <exception cref="ArgumentException"><paramref name="value"/> can be greater or equal at 0</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");

            this.health = value;
        }
    }
}
