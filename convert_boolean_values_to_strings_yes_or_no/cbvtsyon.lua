-- [convert boolean values to strings yes or no]
-- [8 kyu]
-- [lua]
local solution = {}
function solution.bool_to_word(boolean)
if boolean then
return "Yes"
else 
return "No"
end
end 
return solution