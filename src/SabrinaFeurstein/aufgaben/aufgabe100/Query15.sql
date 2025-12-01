-- Welche Organisationen haben deren Hauptsitz in Österreich? 
-- Wie viele Mitglieder haben diese Organisationen?
SELECT organization.Name, COUNT(isMember.Country) AS Members FROM country
JOIN organization ON country.Code = organization.Country
JOIN isMember ON organization.Abbreviation = isMember.Organization
WHERE country.Name = 'Austria'
GROUP BY organization.Name;