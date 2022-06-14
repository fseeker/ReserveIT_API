# ReserveIT_API

This is a API service built as an assignment by ReserveIT.

# Problem Statement
Build and API service using .NET 5 where a user can send a list of words through a post
request and a page size n using request header. The header name should be page-size. Now
you have to construct line(s) using those words where each line can contain a maximum n
number of characters. Return the constructed line through a get request.

**API Endpoints**
1. /post
a. Request type: POST
b. Request header: page-size
c. Data: List of string
d. Response status code: 201

2. /get
a. Request type: GET
b. Response: List of lies
c. Response status code: 200

# Assumptions
Due to ambiguity in the problem statement, the following assumptions were made:

 - a word can be split anywhere and trailing part is continued in the next line.
 - N can be a positive integer only.
 - whitespaces are considered to be characters.
 - the value of N is 10 by default, or when any invalid value is provided.

# Implementation
The API is configured in the WordListController.CS and can be requested by post and get via the url: https://localhost:44311/WordList. The results are best viewed with postman or swagger.

