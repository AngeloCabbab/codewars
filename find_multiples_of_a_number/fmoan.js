// [find multiples of a number]
// [8 kyu]
// [javascript]
function findMultiples(integer, limit)
{
const multiples = []
for (let i = integer; i <= limit; i += integer)
{
multiples.push(i);
}
return multiples;
}