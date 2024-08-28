// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*Task: Using Test Driven Development practices, 
 * create an application that only allows valid Passwords. 
 * Create a password storage class with a List for storing passwords. 
 * If a password is valid, add it to the List and return true. Otherwise, return false.*/

/*For a password to be valid, it must meet all of the following rules.
 *      The password doesn't already exist in the list
 *      The password is between 7 and 12 characters exclusive
 *      The password has at least one number,
 *              but any password with a 6 is not allowed
 *              Spaces are not permitted in passwords
 *      The password must contain at least 2 capital vowels (Count y as a vowel,
 *              repeated vowels are allowed like in BOOK or EYE)
 *      The words "admin" and "mod" may be used as passwords and
 *      ignores other rules save for one:
 *              the password should only be added if it isn't already in the list.*/

/*Test Cases/Rules: 
 * Write 2 tests for each of the following rules. 
 * Assert that the List is changed (or not changed) and 
 * assert that the method returns true or false.*/


/*Extended Exercise Cases: 
 * Allow only prime numbers in the password. 
 *      Primes with 6 in them should never be valid.*/

/*Hints:
 * Take each case one at a time. Refactor between writing each test.*/