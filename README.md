# EmswithGraph

# Description 
THis repo is a demonstration of creating an Event management system. THis is a very simple and primitve example that has no user authentication and authorization. So anyone can login and has admin priviledges, it is taken as the readers challenge to implement all the security. Remember this is your backend and you can never trust your frontend clients. 

Provided this is a graphql repository you should look for ways to prevent DOS and CSRF from your endpoint. During my own testing I could effectively DOS this server with a simple cyclic query.
Depending on the complexity desired you can edit the database schema to provide more functionality as desireed. 

# Getting started
## Requirements
This system was created on windows but the dependicies may be installed on just about any linux distro or MacOs out there. ~Unless you use `Temple Os` you poor broken soul.~  

the following are requirements that MUST be installed for this to work. 
- ASP.Net core 
- Sql server 

the following are not mandatory but is the toolchain I used to get upto speed effectively. 
- Visual studio 2022
- Sql server management studio
- Chrome browser. 
