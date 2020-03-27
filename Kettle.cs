using System;
using System.Collections.Generic;
using System.Text;

namespace EletricKettle
{
    public sealed class Kettle
    {
        Kettle() { }

        private static Kettle _kettleinstance = null;
        private static readonly object _lock = new object();
        public State _kettlestate { get; set; } = State.Empty;

        public static Kettle Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_kettleinstance == null)
                    {
                        _kettleinstance = new Kettle();
                    }
                    return _kettleinstance;
                }
            }
        }
        

        public void Fill()
        {
            if (_kettlestate == State.Empty)
            {
                Console.WriteLine("Filling...\n");
                _kettlestate = State.InProgress;
            }
        }

        public void Drain()
        {
            if (_kettlestate != State.InProgress)
                Console.WriteLine("Draining...\n");
            _kettlestate = State.Empty;
        }

        public void Boil()
        {
            if (_kettlestate == State.InProgress)
                Console.WriteLine("Boiling...\n");
            _kettlestate = State.Boiled;
        }
    }

    public enum State
    {
        Empty,
        InProgress,
        Boiled
    }
}
