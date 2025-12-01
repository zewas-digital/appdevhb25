-- Gib alle Mitglieder der neuen Organization aus. 
-- Sind alle Mitglieder dabei, die du hinzugefügt hast?
SELECT * FROM isMember
WHERE organization = 'DCV';