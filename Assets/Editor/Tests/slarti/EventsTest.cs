using UnityEngine;
using NUnit.Framework;

namespace slarti
{
    [TestFixture]
    public class EventsTest {

		class TestEvent : slarti.events.Event {
		}

		class EventListener<T> where T : events.Event {
			public T eventReceived;

			public EventListener() {
				Events.instance.AddListener<T>(ReceiveEvent);
			}

			public void Remove() {
				Events.instance.RemoveListener<T>(ReceiveEvent);
			}

			public void ReceiveEvent(T evt) {
				eventReceived = evt;
			}
		}

		[Test]
		public void CanListenForGlobalEvents() {
			EventListener<TestEvent> listener = new EventListener<TestEvent>();
			TestEvent toFire = new TestEvent();

			Events.instance.Fire(toFire);

			Assert.AreSame(toFire, listener.eventReceived);
		}

		[Test]
		public void CanRemoveListenersForEvent() {
			EventListener<TestEvent> listener = new EventListener<TestEvent>();
			TestEvent toFire = new TestEvent();
			listener.Remove();

			Events.instance.Fire(toFire);			

			Assert.Null(listener.eventReceived);
		}

		[Test]
		public void MultipleListenersReceiveSameEvent() {
			EventListener<TestEvent> listener1 = new EventListener<TestEvent>();
			EventListener<TestEvent> listener2 = new EventListener<TestEvent>();
			EventListener<TestEvent> listener3 = new EventListener<TestEvent>();
			TestEvent toFire = new TestEvent();

			Events.instance.Fire(toFire);

			Assert.AreSame(toFire, listener1.eventReceived);
			Assert.AreSame(toFire, listener2.eventReceived);
			Assert.AreSame(toFire, listener3.eventReceived);
		}
    }
}

