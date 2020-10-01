# List tasks

## Required Skills
* Iteration
* Selection 
* By reference
* In-place 
* Timing 

Examples: https://github.com/st-pauls-school/csharp/blob/master/ListUtilities/ListConsole/Program.cs 

## Questions 

#### The point of the first two questions is to practice iteration and selection, not to use the built in function. 

1. Given a list of integers - without using built in list functions - return: 
   1. the sum 
   2. the max element 
   3. the min element
   4. a list of the negative elements in the array
2. Build a function that, given two lists of integers, returns a boolean to say if they contain the same items (order is not important, nor are any duplicates). 
3. Search a sorted list (without using built in functions)
   1. Implement a “naive” search, which just loops over the list and returns true if the given item is in the list 
   2. Create a binary search function (as opposed to a linear search function) to return a bool to answer if a given item is in the list.

#### From this point on, you can use whatever methods you like.
 
4. Given an unsorted list of signed integers, return a list of all the integers that are duplicated in the list. 
5. Building on Q2, build a function that takes two lists and returns a Boolean if one list is a subset of the other list
6. Reverse a list, in-place<sup>1</sup>.
7. We will, later in the course, be discussing sorting in much greater detail. But for now, implement a sort algorithm, you can use wikipedia: 
   1. (not Bubble), although insertion or selection are ok
   2. But quick, shell, merge or something with average complexity better than O(n2) would be better
   3. Using a timing mechanism and generating some random numbers, prove that the order of growth<sup>2</sup> is roughly what you might expect 

#### Extension work

2005 https://olympiad.org.uk/papers/2005/bio/ 
* Q1 - “Fractions” 
* Q3 - “Movie Magic” 

________________
1. “In computer science, an in-place algorithm is an algorithm which transforms input using no auxiliary data structure. However a small amount of extra storage space is allowed for auxiliary variables.” - Wikipedia in-place
2. “one commonly considers the worst-case time complexity, which is the maximum amount of time required for inputs of a given size.” - Wikipedia time-complexity
