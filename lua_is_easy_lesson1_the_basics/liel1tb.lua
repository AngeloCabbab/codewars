-- [lua is easy lesson1 the basics]
-- [8 kyu]
-- [lua]
kata = {}
function kata.firstLua(a, b, c)
if b >= c then 
return a .. " " .. (a * b) .. " Lua"
else
return a .. " " .. (a * b) .. " Codewars"
end
end
return kata