This is a VERY beta chatbot written in Blazor.

All it does is open a websocket, and echo your message back to you.

There are 3 projects:

1. Client - the web chatbot, written in webassembly and c#
2. Server - the websocket server, this is a test server to echo the message back to the user, also written in csharp
3. Shared - shared files, like models and other things that can be shared between client and server

