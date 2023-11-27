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