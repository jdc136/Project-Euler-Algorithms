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

### Problem Nine
This was challenging, but fun. I got the answer right on my first try. I was mostly pleased with my mathematical/numerical analysis of the problem before tackling the code, which consisted of the following observations:
1. None of a, b, or c can equal 0. For one, if any equal 0 then the product abc = 0. Which strictly speaking is possible, but I'm guessing Project Euler wouldn't have a trick answer like this. Additionally, if one of a^2 + b^2 = c^2, it would have to be a, because a < b < c and the lowest a could be and still be less than b, but not be a negative number is 0. If a equals 0, then 0 + b^2 = c^2 which means b = c, which means that b is not less than c. So 0 is not possible for a, b, or c!
2. Since we're looping through a, b, and c and a < b < c, we're starting at 1, 2, and 3, respectively. What number should we go up to? Well, if a + b + c = 1000, then the maximum number you could go up to and retain a < b < c is 997. This is because 1 + 2 + 997 = 1000. The "limit" changes depending on whether we're talking about a, b, or c, however. For instance, the highest limit for b is less than c but clearly you can't have 1 + 996 + 997... as that is way above 1000. Since my algorithm takes a brute force approach, however, I set the limit of b to one less the limit of c, and so on for a. It would be interesting to refine this algorithm further such that combinations greater than 1000 were excluded altogether, thus improving performance. (Looking at Project Euler's overview of the problem, it appears this is taken into consideration in their "parameterisation of Pythagorean triplets".)

As far as design, I opted for a separate method so as to break out of the nested loop when the correct answer was found. Although I knew it to be impossible, one is also required to give a default return value (in case the condition is not met).

### Problem Ten 
This one was quite easy for me, enough so that there isn't much to say. I used the primality test I've seen before in *Algorithms* by Sedgewick.

### Problem Twelve
I took a look at this one, and was able to break it down pretty quickly for smaller numbers. Running it for some number that had 500 divisors eluded me, however (code was running for about five minutes before I stopped it). About a week later, I was trying some kata on [Codewars.com](www.codewars.com). In trying to find a performant solution for that kata, I came across [this lovely answer on Stack Exchange](https://codereview.stackexchange.com/questions/237416/c-code-to-find-all-divisors-of-an-integer). After plugging that into the `GetNumOfFactors` method, I was able to quickly get the answer!

### Problem Thirteen
I took a look at this one and quickly averted my gaze. I had no idea how I would solve it! Initially I was thinking I'd have to implement some kind of process for the kind of addition you do on paper - manually, adding the remainder, etc. Fortunately, I was working on a different problem one day and a mentor alerted me to the existence of `BigInteger` which allowed me to solve this without all that effort. Whew!
