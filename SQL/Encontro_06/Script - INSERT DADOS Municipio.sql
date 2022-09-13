INSERT INTO Municipio (CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, CodigoUF, SiglaUF, Regiao, Populacao, Porte)


SELECT RAW_Municipios_Complementar_IBGE_UTF8.MunicipioID, RAW_Municipios_Complementar_IBGE_UTF8.Nome, RAW_Lista_de_Municipios_com_IBGE_Brasil_UTF8.IBGE, RAW_Lista_de_Municipios_com_IBGE_Brasil_UTF8.IBGE7, 
                  RAW_Cidades_IBGE6_UTF8.CEP, RAW_Municipios_Complementar_IBGE_UTF8.UFID, RAW_Cidades_IBGE6_UTF8.UF, RAW_Lista_de_Municipios_com_IBGE_Brasil_UTF8.Região, 
                  RAW_Lista_de_Municipios_com_IBGE_Brasil_UTF8.População_2010, RAW_Lista_de_Municipios_com_IBGE_Brasil_UTF8.Porte
FROM     RAW_Cidades_IBGE6_UTF8 INNER JOIN
                  RAW_Lista_de_Municipios_com_IBGE_Brasil_UTF8 ON RAW_Cidades_IBGE6_UTF8.IBGE = RAW_Lista_de_Municipios_com_IBGE_Brasil_UTF8.IBGE INNER JOIN
                  RAW_Municipios_Complementar_IBGE_UTF8 ON RAW_Lista_de_Municipios_com_IBGE_Brasil_UTF8.IBGE7 = RAW_Municipios_Complementar_IBGE_UTF8.CodigoIBGE
