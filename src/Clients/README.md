Clients
-------

This directory contains a few different clients that could be used to connect to your MUD.

The WPFClient is the most advanced, and uses WPF with .NET 3.5. It does not work with Mono
and will not work on OSX or Linux, but may be your best choice for a Windows-only client.

The wxMudClient is the second most advanced. It has some issues and does not work perfectly,
but it does build and run on Linux, and builds on OSX (though it has not been tested much
on OSX). It is written in C++ and uses the wxWidgets libraries.

The Silverlight client is the least developed, and requires running the PolicySocketServer
on the same server as the MUD (Silverlight requires a "policy server" to tell it that it's
OK to connect to a server, and can only connect to a limited range of IP ports. That's why
the MUD defaults to running on port 4502 - it's one of the ports supported by Silverlight.
It could, however, be used as an in-browser MUD client, unlike the other two.

All three clients probably still have existing ANSI parsing and layout issues. Only the
first two support graphical maps, and the wxMudClient might be a version or two behind on
the protocol and tile layout.