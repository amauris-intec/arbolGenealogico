# Parseador de Árbol Genealógico


[Link al video donde creamos este proyecto en vivo](https://estintecedu.sharepoint.com/:v:/s/IDS326L-01-T4/EVjzCKm7LiZMr53QLtoZyUMBAl1azO2hr8zbkzjXCynfWQ?e=QJmqZO)
__(Importante: el error del segundo 1:39:30 resultó no ser un error. Simplemente empezó a funcionar luego de intentarlo otra vez)__

Este es un ejemplo del archivo que se puede parsear:

```
{Jose#+Maria# { Carlos, Alfredo + Clara{Juana#+Pedro{ Armandito }, Matilda+Alexis { 
    Pepe } 
   } 
}}
```

Esta sería la salida al parsear el archivo de ejemplo
```
V2: Jose (que en paz descance) se casó con Maria (que en paz descance)
V2: Carlos se quedó jamón
V2: Alfredo se casó con Clara
V2: Juana (que en paz descance) se casó con Pedro
V2: Armandito se quedó jamón
V2: Matilda se casó con Alexis
V2: Pepe se quedó jamón
```
