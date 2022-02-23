# Project Euler Algorithms
## Overview
In my efforts to be a software developer, I thought I'd take on the projects on [Project Euler](https://projecteuler.net/about). I am no math major, but I do love numbers. Some are a bit tricky, but I take their advice to "take a break... tackling a different problem might give you the knowledge or inspiration to see how to solve it." My approach is generally to consider the parameters and properties of the given problem, using pencil and paper, first, and then start working out the specifics with the code.

### Problem One - Three
I had solved these problems a year or two ago when I was studying Java. Upon starting this project up, I attempted to solve the problems myself before looking at the solutions I had previously come up with. I did solve problem one pretty easily. Problem two was a bit more difficult, but I was able to solve with use of search engine. Problem three was quite difficult for me, mostly because of difficult figuring out how to define a prime number. Ultimately I did refer to some online examples and my old solution for this one. 

All in all, I took Project Euler's advice to learn from each piece of these solutions to apply in later solutions.

### Problem Four
After having warmed up on the first three problems, I found this one very fluid! I was so pleased with my learning process on this one. While I did use a search engine for some of the individual components of the problem, I came up with the overall algorithm or steps myself. Specifically, I noticed it helpful to consider the parameters of the problem, which you can see in my "considerations" in the P4.cs file. 

I initially only used IsPalindrome() to check whether the number was indeed a palindrome, and got an incorrect answer. I realized that it wasn't enough for the number to be a palindrome: it must also be a product of whatever 3-digit numbers. After adding that condition in, I was able to get the correct answer!

### Problem Five
This one took me about an hour and  half in between some errands. I was also very pleased with my learning process on this one - no search engine use at all! I started by making some considerations (like with problem four) which helped, but this one was a bit trickier in that I couldn't limit it to a range of numbers, etc. I ended up extensively using the Console.WriteLine() method to get a read on the specific steps my program was taking - and trying to match wht I wanted the program to do with the idiom of C#.

The most difficult part was the NoRemainder() method. I outlined in my head the steps, but had a bit of trouble getting the method to actually follow those steps as desired, but eventually I hit on the target. 

After solving the problem, I also realized it could go faster by checking only even numbers - an even number is the only possible answer, after all. All in all, I made use of what I learned on problem three and also came to better appreciate Console.WriteLine() as well as loops and break statements!

### Problem Six
This was the easiest one yet - took me about five minutes. I found that I wasn't struggling as much with which construct to use (there were a number available, but I went ahead with a for loop).

### Problem Seven
This was fun. Didn't take me very long to bear down on the problem by brute force and get the correct answer (first answer I submitted was correct). However, I was displeased by the inelegance of my solution. So I reviewed the overview and modified my code a bit based on that, making it a bit more simple.

### Problem Eight
This was a bit more challenging than the last few, but more than manageable. I've got a solid process now, so I brainstormed and outlined a plan of attack, then dove into coding. As usual, I employed many Console.WriteLine() statements and went through several iterations before arriving at the final design. For fun, I made it interactive, allowing the user to put in the number that they want (so if user inputs 13 then it will look for the product of sequential 13 digit ranges). 

I got the code to work perfectly for the example of 4, provided by Project Euler, but when I did 13 I ran into a little problem. I hadn't used a search engine at this point, except to get a reference on using arrays, and I didn't want to simply get the answer. I found this [Stack Overflow thread](https://stackoverflow.com/questions/35532198/project-euler-8-in-c-sharp) which mentioned changing the data type to long - face palm! Overall, biggest takeway from this problem was implementing and using an array.
