# Unity Scaffolding
This is a basic skeleton I use for all of my Unity projects.

There is a GameManagers object with a ClassManager script on it.

ClassManager knows where everyother script in the game is and is a static object.  
Any file can find any other file by calling `ClassManager.instance."class_name"`

I have included a blank `InputManager.cs` script as an example.
