# tower-hopping-problem
C# implementation of the Tower Hopping Problem.

Original Problem:

> Given a list of integers representing a series of towers and their corresponding heights,
> determine if a path can be found such that the jumper escapes the towers by leaping from one tower to the next when starting 
> from index 0. Note that the jumper can only jump as far as the height of the tower he's currently standing on.

For example, `IsHoppable([4, 2, 0, 0, 2, 0]) -> True` by using the path `0 -> 4 -> 6`. However, `IsHoppable([1,0]) -> False` because the jumper would start at index `0`, jump one tower to index `1`, and then be stuck because `Towers[1] = 0`.

[Problem and solution originally found on YouTube.](https://www.youtube.com/watch?v=kHWy5nEfRIQ) Note that the original problem only required that a boolean be returned, indicating whether a path exists. My implementation also returns the found path to make debugging simpler.
