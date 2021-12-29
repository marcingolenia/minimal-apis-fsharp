module TestApi
  
open Program
open Microsoft.AspNetCore.Mvc.Testing
 
let runTestApi () = (new WebApplicationFactory<Program>()).Server