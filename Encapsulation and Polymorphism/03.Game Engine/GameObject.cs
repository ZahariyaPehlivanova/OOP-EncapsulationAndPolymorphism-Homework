using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Game_Engine
{
    public class GameObject
    {
        private string id;
        
        public string Id
        {
            get { return this.id; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Id cannot be null");
                }
                this.id = value;
            }
        }
        protected GameObject(string id)
        {
            this.Id = id;
        }
    }
}
