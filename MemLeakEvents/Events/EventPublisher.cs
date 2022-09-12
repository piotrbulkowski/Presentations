﻿using System;

namespace MemLeakEvents.Events
{
    internal class EventPublisher
    {
        public event EventHandler<Guid> SomeEvent;

        public void PublishEvents()
        {
            var guid = Guid.NewGuid();
            Logger.WriteLine($"{nameof(EventPublisher)}: PublishEvents sends {{{guid}}}");
            this.SomeEvent?.Invoke(this, guid);
        }
    }
}