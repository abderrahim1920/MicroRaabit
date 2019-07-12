using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime TimesTamp { get; protected set; }

        protected Event()
        {
            TimesTamp = DateTime.Now;
        }
    }
}
