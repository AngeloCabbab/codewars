// [geometry basics distance between points in 2d]
// [8 kyu]
// [c++]
#include <cmath>
double distance_between_two_points(const Point& a, const Point& b) 
{
double dx = b.x - a.x;
double dy = b.y - a.y;
double distance = std::hypot(dx, dy);
return distance;
}
