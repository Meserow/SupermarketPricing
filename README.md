# Supermarket Pricing Kata
A unit testing code kata centered around pricing of items in a grocery store

## The Problem 
Our customer--the owner of a small grocery store--would like us to develop a library to be used during the checkout process to calculate the net total for the shoppers. In general, the net total for a single product is given by `quantity * unit price`. However, the store owner may decide to offer some products for sale. Some examples of products on sale are "Buy 2 cans of beans get 1 free" or "Buy 3 cans of beans for $4.50." 

**For Example**

| Sale | Quantity | Unit Price | Net Total | |
| ---- | -------: | ---------: | --------: | - |
| N/A  | 1 | 200 | 200 | |
| | 2 | | 400 | |
| | 3 | | 600 | |
| | ... | | ... | |
| Buy 2 Get 1 Free | 1 | 200 | 200 | |
| | 2 | | 400 | |
| | 3 | | **400** | Sale Applies |
| | 4 | | 600 | |
| | 5 | | 800 | |
| | 6 | | **800** | Sale Applies |
| | ... | | ... | |
| Buy 3 for $4.50 | 1 | 200 | 200 | |
| | 2 | | 400 | |
| | 3 | | **450** | Sale Applies |
| | 4 | | 650 | |
| | 5 | | 850 | | 
| | 6 | | **900** | Sale Applies |
| | ... | | ... | |


## Requirements

* Implement the `CalculateNetTotal` method in the `CheckOut` class to handle the above sales logic.

## Constraints

* You cannot change the signature of `CalculateNetTotal`.

## Other Notes

* The `CheckOut` class contains a list of `Product`s. 
* A `Product` contains the quantity and unit price.
* You may add new classes or methods as you see fit.
* There is no current representation of the concept of a "sale" in the code. You will need to decide how to model that.
* You will not likely finish the problem in an hour. Don't be discouraged if you see the clock winding down.
* If you are not familiar with C#, you may psuedo-code in the language of your choice and the interviewer will help you translate the syntax to C#.