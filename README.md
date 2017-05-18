# osc_unity_max
OSC > Max > MIDI output

OSC implemented using SharpOSC library:
https://github.com/ValdemarOrn/SharpOSC

EXAMPLE CODE:
    
    var message = new SharpOSC.OscMessage("/test/1", 23, 42.01f, "hello world");
		var sender = new SharpOSC.UDPSender("127.0.0.1", 55555);
		sender.Send(message);
