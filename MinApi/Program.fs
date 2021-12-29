open Microsoft.AspNetCore.Builder
open Giraffe

let webApp =
    choose [ route "/ping" >=> text "pong"
             route "/" >=> text "Hello world" ]

let app = WebApplication.CreateBuilder().Build()
app.UseGiraffe webApp
app.Run()

type Program() = class end