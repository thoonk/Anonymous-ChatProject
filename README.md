# Anonymous-ChatProject
Anonymous-ChatProject using C# in my university.

## function

Server: Client connection, server record storage, hourly recording

Client: Server connection, font setting and background setting through dialog, chat window initialization, chat window saving, copying, and pasting through menu strip

## Manual

### Server

1) Change in the server code can only be applied to open ports that are not used.
2) Before running the chat program (client program), the server must first be turned on.
3) Server can save the server's chat history as a text file through a menu strip.

### Client

1) clientSocket.Connect ("127.0.0.1", 9999); //127.0.0.1 >> Change the server to the IP of the computer to operate.
2) If you are going to communicate externally in the Connect statement, write the external IP, and the port number is an unused open port.
3) If you are going to run it on your own computer, set it to 127.0.0.1, the local IP, and write an open port that is not used.
4) Start the server first, and run the chat program (client). Write the nickname in the nickname box at the top and click the connect button to connect to the chat server.
5) 1: N function and multiple access are possible.
