The stable marriage problem is defined as follows:

Suppose you have N men and N women, and each person has ranked their prospective opposite-sex partners in order of preference.

For example, if N = 3, the input could be something like this:

```
guy_preferences = {
'andrew': ['caroline', 'abigail', 'betty'],
'bill': ['caroline', 'betty', 'abigail'],
'chester': ['betty', 'caroline', 'abigail'],
}

gal_preferences = {
'abigail': ['andrew', 'bill', 'chester'],
'betty': ['bill', 'andrew', 'chester'],
'caroline': ['bill', 'chester', 'andrew']
}
```

Write an algorithm that pairs the men and women together in such a way that no two people of opposite sex would both rather be with each other than with their current partners.


# Solution:

so my approach to this is we put the men in a queue and start proccessing that queue. 

for each guy we will look over the list of gals he selected and check if that gal is already matched with someone and if she isn't we just match them up if she is then we check if that match is a better match for the gal based on the rank she picked.

if the rank is higher than the current rank then we select the new guy as a match, remove old match and add the removed guy from the match to the queue again, and update the score of the paired gal.

## Time Complexity:

O(N^2)

## Space Complexity:

O(N)


