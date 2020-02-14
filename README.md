# kata-2019-SBamford-TShearer

## Constraints

Before we knew what the problem was, we decided to try the Analysis OOP Style First constraint (https://docs.google.com/document/d/1kBkXCf5DkVozMK31i8EvWLLQ7Y4iUMM5Q8KqqRHdnbQ/edit), but this proved to be overkill for this problem.
We also applied the No Primitives constraint (https://docs.google.com/document/d/1RSvUaGhxf8Gc46wEVAGgyGRDAE8YSZrQwIC70UukxsE/edit).

## Thoughts

The Analysis OOP Style First wasted our first session.
After that, we proceded slowly, but we eventually came up with a reasonable solution of having a Row class that can be used to calculate the output for each row of the clock.

We should separate the Row and Light classes (and the Colour enum) into different classes.

We should also look at using the Row class to calculate the output of the TopYellowLight. 
