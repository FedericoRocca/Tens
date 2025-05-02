#!/bin/bash

# Tamaño mínimo en bytes (100 MB)
MIN_SIZE=$((100 * 1024 * 1024))

echo "Buscando archivos >= 100MB (ignorando .git)..."

# Asegura que .gitignore exista
touch .gitignore

# Buscar archivos grandes excluyendo la carpeta .git
find . -type f -size +${MIN_SIZE}c ! -path "./.git/*" | while read -r file; do
    # Limpiar el prefijo "./"
    clean_path="${file#./}"

    # Verificar si ya está en .gitignore (línea exacta)
    if grep -Fxq "$clean_path" .gitignore; then
        echo "Ya ignorado: $clean_path"
    else
        echo "$clean_path" >> .gitignore
        echo "Agregado a .gitignore: $clean_path"
    fi
done

echo "Proceso finalizado."
