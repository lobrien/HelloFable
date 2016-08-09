# HelloFable

HelloWorld for Fable, the F#-to-JavaScript compiler

This is the simplest thing I know how to do with [Fable][1],
the F#-to-JavaScript compiler. This program retrieves a `div` in an HTML page and sets its value:

```
#r "node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Import.Browser

let div =  document.getElementById("helloDiv")
div.innerHTML <- "Hello, World!"
```

With this corresponding HTML page:

```
<!doctype html>
<html>
<head>
 <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>
</head>
<body>
  <div id="helloDiv"/>

  <script src="node_modules/core-js/client/core.min.js"></script>
  <script src="node_modules/requirejs/require.js"></script>
  <script>
    requirejs.config({
        // Set the baseUrl to the path of the compiled JS code
        baseUrl: 'out',
        paths: {
            // Explicit path to core lib (relative to baseUrl, omit .js)
            'fable-core': '../node_modules/fable-core/fable-core.min'
        }
    });
    // Load the entry file of the app (use array, omit .js)
    requirejs(["hello"]);
  </script>
</body>
</html>
```




[1]:	http://fsprojects.github.io/Fable/