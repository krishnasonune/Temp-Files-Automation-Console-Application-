
# Temp-Files-Automation-Console-Application

Temp Files Automation automates the process of deleting temp files from specified path from your local machine.


## Usage/Examples

```C#
    //if you have multiple paths make array of path and traverse it in this way

    string[] paths = { 
        @"Enter your path here",
        @"Enter your path here" 
    };

    Automation automate = new Automation();

    for (int i = 0; i < paths.Length; i++)
    {
        automate.DeleteAllTempFiles(paths[i]);
        automate.DeleteAllTempDirectories(paths[i]);
    }

    OR

    //for single path do you can do it in this way
    
    string path = @'Enter your path here';
    Automation automate = new Automation();

    automate.DeleteAllTempFiles(path);
    automate.DeleteAllTempDirectories(path);
```




## Screenshots

![App Screenshot](/screenshot/finalresult.png)


## Authors

- [@krishna_Sonune](https://in.linkedin.com/in/krishna-sonune-1421b21b5)

