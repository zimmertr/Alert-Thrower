# Alert-Thrower
Alert Thrower was a program written in C# to send alerts of various types to the Application Log in the Windows Event Viewer.

```
- EventID, Category, and a random byte if size 10 is generated for each alert. 
- The user can specify how many alerts to send to the log. 
- # of alerts restricted to 1000 per submission for performance reasons. 
- Has basic error handling.
```

**Prompt**

![Alt text](https://raw.githubusercontent.com/zimmertr/Alert-Thrower/master/program.png "Program with Alert Box")

**Event Viewer after Execution**
![Alt text](https://raw.githubusercontent.com/zimmertr/Alert-Thrower/master/event_viewer.png "Event Viewer after using program")
