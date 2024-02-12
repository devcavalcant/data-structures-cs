# Data Structures CS

The data structures project aims to study some of the main concepts related to the field, implementing search and sort algorithms based on my understanding of how the algorithm works.

Addendum: Throughout the construction of the project, I tried to minimize the visualization of ready-made code, but at times it became necessary.

## 🌍 Languages

[🇧🇷 Portuguese](./PORTUGUESE.md)

[🇺🇸 English](./README.md)

## 🚀 Technologies

- `.NET SDK 8`
- `C#`
- `Dotnet Cli`

## 🔑 Challenges

Since my study was based on understanding the algorithms and how they worked, the greatest difficulties came precisely from how I understood them, so every problem in the code was an opportunity to re-analyze the algorithm.

## 📖 What I Learned

During the project, although the ultimate goal was to successfully implement the algorithms, I also learned about other techniques.

### 🕵️ Sequential Search

The Sequential Search is the simplest method of search, because it searches each of the indexes in the array, but it should be noted that depending on the location of the number and size of the array, this search can be time-consuming and not flexible.

Complexity: `O(n)`

### 🕵️ Binary Search

Binary search is a much more interesting way of searching for values, because it divides the array into parts and compares the required number with the value of the middle array. The workings of binary search are simple to understand:

With a previously **ordered** array, the first decision is to search for the `minimum,` `medium` and `maximum` index of the array. With the three values duly calculated, the next step is to compare the value stored in the array with the value to be searched for, something like: `array[median] == target`. If the target value is the same, then you already know where it is located, ending the algorithm. If the value is not the same, a comparison is made to see if the target value is greater or less than that found in the[median] array. If it is smaller, then the target value is located in the left part of the array, so the `maximum` index needs to be changed to the value where the `medium` index was located, completing the algorithm and restarting it. If it is greater, the target value is known to be located in the right-hand part of the array, so the `minimum` index is changed to the value of the `medium` index, closing the algorithm and performing the search again.

On the two ways when we try to understand where the target value is located, the `average' index is constantly recalculated on the basis of the other two, to make the search possible again.

Complexity: `O(log2 n)`

### ☁️ Bubble Sort

Bubble Sort has a very simple concept. Given an array, the first two values of the indices (0 and 1) are compared, if the first is greater than the second, the exchange is made, if not, the two indices move one place forward, i.e. now the analysis is done between indices 1 and 2. With each new analysis, the comparison is made until all the values have been sorted.

Complexity: `O(n²)`

### ↪️ Insertion Sort

Insertion Sort is one of the most fun concepts. The idea is often referred to in cards, where a person tries to sort their deck, and accomplishes this by taking a card and putting it in the exact place where it should be, so that it's sorted.

When you start sorting, the first loop starts and the first index is taken from the array. The value of the index is compared, and if it is smaller, then it is known that it should go forward. This comparison is made until its position is identified, ending the first loop. The loops continue until all the values are sorted.

Complexity: `O(n²)`

### ↪️ Merge Sort

Merge sorting works in a different way, it uses the technique of `recursiveness` for sorting, with an idea along the lines of *Divide for Conquer*. Merge sorting must be carried out with two functions, where the first will be called by the "client", receiving an unordered array. The unordered array is split in two, and each part goes back into the same function, where it will be split again. These split arrays will be returned by the same function, which in turn uses another function to sort the arrays.

Complexity: `O(nlogn)`

### ⚡ Quick Sort

Quick Sort is a sorting method that also uses recursion like [Merge Sort](#↪️-merge-sort), but one of its main features is the way it works. This technique is based on choosing a pivot, from which all the other smaller and larger values will be organized. The organization by pivot is based on the final structure of the sort, since a properly sorted array will have smaller values on the left and larger values on the right, depending on the reference. At the end of the pivot-based movement, the index where the pivot is located is returned. All these movements are carried out until the array is completely organized.

Complexity: `O(n²)`

### Heap Sort

Heap sorting is unique in that it uses the heap structure to sort the elements. Because of the peculiarity of its structure, it is easily represented by a tree, which is later understood as a special binary tree. The idea is to sort using the root and its children as a reference, so if one of the children is larger than the root, the elements are swapped, and the new root becomes the largest, bringing the sorting upwards, i.e. the largest element is at the top/root.

This was one of the most complicated structures to realize and understand, as it deals with data in a very different way, causing confusion during the process.

Complexity: `O(nlogn)`

### Swap method in the array

During the [Insertion Sort](#↪️-insertion-sort) algorithm, one of the requirements is to swap values between two indexes. This problem is simple and easy to solve using a helper, however, in c# it wasn't necessary, as the exchange can be done easily with one line of code, such as:

```c#
(randomArray[j], randomArray[j-1]) = (randomArray[j-1], randomArray[j]);
```

### Linq has no side effects

During the [Merge Sort](#↪️-merge-sort) algorithm, an error occurred where in the `Merge` method it was not possible to see the sorted array because the array did not receive the value from the `Append` function. After analyzing the *Warnings* codes, I understood that Linq itself, when using only `Append`, does not execute directly on the array, but returns the result, so it is necessary to receive the new array or use another method. In this case, we used :

```c#
sortedArray = [.. sortedArray, secondPartialArray[0]]; // For Example
```

The *Warning* received was: 

    'Merge' calls 'Append' but does not use the value the method returns. Linq methods are known to not have side effects. Use the result in a conditional statement, assign the result to a variable, or pass it as an argument to another method.


## 📦 Installation and Running

### Requirements

The project is created with C# together with the .NET SDK, so there is a need for:

- .NET SDK
- Dotnet CLI

### Running

The project is easy to install:

First, `clone` the project together with the `.sln` solution:

```bash
git clone https://github.com/devcavalcant/data-structures-cs.git
```

So, enter the project and `run`:

```bash
dotnet run
```
