-- [geometry basics distance between points in 2d]
-- [8 kyu]
-- [lua]
local solution = {}
function solution.distance_between_points(a, b)
local dx = b.x - a.x
local dy = b.y - a.y
return math.sqrt(dx*dx + dy*dy)
end
return solution