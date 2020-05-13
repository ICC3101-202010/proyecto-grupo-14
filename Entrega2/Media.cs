using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    abstract class Media
    {
        private int Length { get; set; }
        private DateTime RealeaseDate { get; set; }
        private string Quality { get; set; }
        private string Genre { get; set; }
        private string Type { get; set; }
        private int FileSize { get; set; }
        private string Description { get; set; }
        private int Ratign { get; set; }
        private int Views { get; set; }
        private DateTime DateAdded { get; set; }
        private string Studio { get; set; }
        private int Likes { get; set; }

        public virtual void Play()
        {

        }
        public virtual void Stop()
        {

        }
        public virtual void Next()
        {

        }
        public virtual void Comment()
        {

        }
        public virtual void Add_icon()
        {

        }
    }
}