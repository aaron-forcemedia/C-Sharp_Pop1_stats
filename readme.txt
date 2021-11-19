
Population: One Stats Retriever for Stream Overlay Simulator Code Louisville – Wednesday Night C# Aaron Wilson

Internet connection required. This project is a continuation on my first two projects from the Code Louisville Front-End & JavaScript courses. This C# app adds real time player stats from the Virtual Reality game Population: One to the gaming stream overlay that runs concurrently to the other two projects.

The API calls will be displayed as requested between matches with specific stats being sent to the text files. The API updates as soon as a player leaves the game. Currently, the stats must be requested manually each time but the goal is to later automate this process, given more time to work on this app.

Please enjoy this work in progress. The intended design uses a colored text background and the text files will be overlayed onto a livestream of a video game in progress using Open Broadcaster Software (OBS) using the files created within the app. (Known bug: The code says that the files will be saved locally but they are currently being saved in the Debug Folder located within the bin folder)

To test app please select option from menu and try some of the following Player Name examples: DatByte, x2the4th, J0N_CL0UD, Zoloto_, Gottakeepongamin, SlothLuvsChunk or Jason. (Known bug: Program will continue funtioning until you quit but the app will throw exception if a name wasn't found after closing the program.)

Project Feature List:

• Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program

• Create an additional class which inherits one or more properties from its parent

• Connect to an external/3rd party API and read data into your app

• Use a LINQ query to retrieve information from a data structure (such as a list or array) or file
