﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Event
{
    public class Subscriber
    {
        private readonly string _id;
        public Subscriber(string id,Publisher pub)
        {
            _id = id;
            pub.RaiseCustomEvent += HandleCustomeEvent;
        }

        public void HandleCustomeEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(_id+$" received this message: {e.Message}");
        }
    }
}
