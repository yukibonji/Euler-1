﻿// sets the current directory to be same as the script directory
System.IO.Directory.SetCurrentDirectory (__SOURCE_DIRECTORY__)
#I @"../packages/FsCheck.1.0.4/lib/net45"
#I @"../packages/FsCheck.Xunit.1.0.4/lib/net45"
#I @"../packages/xunit.1.9.2/lib/net20"
#I @"bin/Debug"
#r @"FsCheck.dll"
#r @"FsCheck.XUnit.dll"
#r @"xunit.dll"
#r @"Euler.dll"

open FsCheck
open Euler.Problems

let 