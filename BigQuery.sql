// Custo x Performance
Preço - número de bytes processados

Armazenamento ~U0,02
Processamento ~U$5,00

SELECT
    max, ROUND((max-32)*5/9,1) celsius, mo, da, year
FROM
   SELECT * FROM `bigquery-public-data.noaa_gsod.gsod1930` UNION ALL    
WHERE
    da = "18" AND
    mo = "11" AND
    year = "1940" AND
    max <> 9999.9
ORDER BY
    max DESC