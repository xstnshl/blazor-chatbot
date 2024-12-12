This is a VERY beta chatbot written in Blazor.

All it does is open a websocket, and echo your message back to you.

There are 3 projects:

1. Client - the web chatbot, written in webassembly and c#
2. Server - the websocket server, this is a test server to echo the message back to the user, also written in csharp
3. Shared - shared files, like models and other things that can be shared between client and server

To build and run  it:
1. Clone it
2. Install dotnet 9 (instructions vary by OS, can be googled)
3. In the base folder, run these commands
```
dotnet clean
dotnet build
dotnet run
```

And then open http://localhost:5050 in your browser.

Start with the Client.  The main code to look at is in /Client/Pages/Chat.razor

