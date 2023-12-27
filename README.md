
## The Prisoner's Dilemma

An implementation of the prisoner's dilemma in C#.

You can read more about the prisoner's dilemma [here](https://en.wikipedia.org/wiki/Prisoner%27s_dilemma).

The twist is, a rich man giving coins to the prisoners. The prisoners can either cooperate or defect. If they both cooperate, they both get 3 coins. If they both defect, they both get 1 coin. If one cooperates and the other defects, the defector gets 5 coins and the cooperator gets 0 coins.

Cooperation is represented by a boolean value of True and Defection is represented by False.

There are different strategies that the prisoners can use. The strategies are as follows:

- Joss : Once betrayed, always defect.
- TitForTat : Cooperate on the first round, then do whatever the opponent did on the previous round.
- AlwaysDefect : Always defect.

More to come

- Giving players access to all moves played in a game so far. (for more complex decision making)
- Adding 'noise' to the game. Making it so that a players intentions can be randomly misintepreted.
