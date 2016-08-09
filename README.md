# HelloFable

HelloWorld for Fable, the F#-to-JavaScript compiler

This is the simplest thing I know how to do with [Fable][1],
the F#-to-JavaScript compiler. This program retrieves a `div` in an HTML page and sets its value:

```
# r "node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Import.Browser

let div =  document.getElementById("helloDiv")
div.innerHTML \<- "Hello, World!"
```

To run this program, you have to first install Fable. Here's how I compile and run:




[1]:	http://fsprojects.github.io/Fable/