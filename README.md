# Word Counter
##### By Will Quanstrom
###### Created 20 December, 2019

## Description

A console app where a user inputs and word and a sentence and is returned how many times the word is present in the sentence.

## Links:

Github - https://github.com/wanderlust22/Word-Counter

## Setup/Installation Requirements:

1. Open https://github.com/wanderlust22/Word-Counter
2. Clone repository to local machine 
3. Build and Run project

  - $ dotnet build - when you are ready to build project
  - $ dotnet run - to run the project 
  - $ dotnet test - for testing the project
  

### Specification

| Specs.  | Ex. Input  | Ex. Output   |
|---|---|---|
| Program checks to see whether user inputs a word made of all letters | "fox" or "ap4d"  | Accepted. or Not Accepted.  |
| Program ignores whether there is or isn't capilization of the word inputted | "Fox", "FoX", "fox" | All Accepted. |
| Program checks to see whether user inputs a real sentence with first letter capitalized  | "This a sentence with punctuation." or  "this ain't a full sentence"  | Sentence or Not sentence  |
| Program checks to see if the sentence entered has punctuation at the end. | "This is a proper sentence with a period.", "This sentence does not have a period at the end" | Accepted and Not Accepted |
| Program accurately tells user how many times word is present in sentence.  | "fox", "The fox jumps over the lazy brown cow."  | "fox" is present one time in the sentence.  |


## Known Bugs

* _None at this time_

## Technologies Used:

* C#
* .NET
* MSTest

### License:

Copyright (c) 2019 Will Quanstrom

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.