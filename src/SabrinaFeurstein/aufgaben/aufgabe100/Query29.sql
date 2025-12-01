-- DELETE: Großbritannien hat die EU verlassen.
DELETE FROM isMember 
WHERE Organization = 'EU'
AND Country = 'GB';