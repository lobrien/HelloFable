#r "node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Import.Browser

let div =  document.getElementById("helloDiv")
div.innerHTML <- "Hello, World!"