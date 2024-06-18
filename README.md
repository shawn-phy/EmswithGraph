# EmswithGraph

# Description 
THis repo is a demonstration of creating an Event management system. THis is a very simple and primitve example that has no user authentication and authorization. So anyone can login and has admin priviledges, it is taken as the readers challenge to implement all the security. Remember this is your backend and you can never trust your frontend clients. 

Provided this is a graphql repository you should look for ways to prevent DOS and CSRF from your endpoint. During my own testing I could effectively DOS this server with a simple cyclic query.
Depending on the complexity desired you can edit the database schema to provide more functionality as desireed. 