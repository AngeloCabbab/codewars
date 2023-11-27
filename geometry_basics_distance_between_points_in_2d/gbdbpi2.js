// [geometry basics distance between points in 2d]
// [8 kyu]
// [javascript]
function distanceBetweenPoints(a, b) 
{
const
{
x: x1, y: y1
} = a;
const
{
x: x2, y: y2
} = b;
return Math.sqrt((x2 - x1) ** 2 + (y2 - y1) ** 2);
}
