# ATM Console App for Unit Testing Lab
#### lab02-unit-testing
##### *Author: Andrew Curtis*

------------------------------

## Description
This is a C# console app that simulates an ATM machine and lets the user interactively perform standard ATM operations such as view balance and withdraw funds. The user will also be able to do other mock ATM operations like add/deposit money. It anticipates and handles a variety of exceptions and was built using TDD principles. 

------------------------------

## Getting Started

Clone this repository to your local machine.
```
$ git clone [repo url here]
```
#### To run the program from Visual Studio:
Select `File` -> `Open` -> `Project/Solution`

Next navigate to the location where you cloned the repository.

Double-click on the `lab02-unit-testing` directory.

Then select and open `lab02-unit-testing.sln`

------------------------------

## Visuals

##### Application Start

![Application Start Screen](https://github.com/amjcurtis/lab02-unit-testing/blob/unit-testing-lab02/images/application_start_screen.png)

![Display Balance](https://github.com/amjcurtis/lab02-unit-testing/blob/unit-testing-lab02/images/display_balance.png)

![Withdraw and Deposit Actions](https://github.com/amjcurtis/lab02-unit-testing/blob/unit-testing-lab02/images/withdraw_and_deposit_actions.png)

![Exit Process](https://github.com/amjcurtis/lab02-unit-testing/blob/unit-testing-lab02/images/exit_process.png)

------------------------------

## Change Log

`1.1` `2019-03-20`: Built out UI to offer multiple ATM functions; created tests for individual non-void methods; implemented methods for the individual ATM functions. 

------------------------------

## Attribution

* I was pointed to the idea of using Environment.Exit(0) to close my console app from the TA of a 201 class I talked to.