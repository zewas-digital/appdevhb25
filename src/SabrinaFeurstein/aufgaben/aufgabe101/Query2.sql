-- 2. Was ist der größte Berg pro Kontinent? Wie hoch sind diese?
select encompasses.Continent, mountain.Name, mountain.Height from mountain
join geo_mountain ON mountain.name = geo_mountain.mountain
join encompasses ON geo_mountain.country = encompasses.country
join ( 
    select encompasses.Continent, max(mountain.height) as MaxHeight from mountain
    join geo_mountain ON mountain.name = geo_mountain.mountain
    join encompasses ON geo_mountain.country = encompasses.country
    group by encompasses.Continent
) as HighestMountainPerContinent
on encompasses.Continent = HighestMountainPerContinent.Continent
and mountain.height = HighestMountainPerContinent.MaxHeight
group by encompasses.continent, mountain.name;