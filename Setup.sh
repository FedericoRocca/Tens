#!/bin/bash

# Verificar si se pasó un parámetro
if [ -z "$1" ]; then
  echo "Uso: ./Setup.sh \"/ruta/al/directorio del proyecto\""
  exit 1
fi

DEST="$1"

# Comprobar si el directorio existe
if [ ! -d "$DEST" ]; then
  echo "El directorio \"$DEST\" no existe."
  exit 1
fi

# Copiar dirSetup.sh al destino
cp dirSetup.sh "$DEST"

# Cambiar al directorio destino
cd "$DEST" || exit 1

# Dar permisos de ejecución y ejecutar
chmod +x dirSetup.sh
./dirSetup.sh

# Eliminar el script si se desea
rm dirSetup.sh

echo "Estructura creada en \"$DEST/Assets\""
