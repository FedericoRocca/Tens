#!/bin/bash

# Tamaño mínimo en bytes (50 MB)
MIN_SIZE=$((50 * 1024 * 1024))

echo "Buscando archivos >= 50MB (ignorando .git)..."

# Asegura que .gitignore exista
touch .gitignore

# Inicializa array para logs
added_files=()

# Obtiene lista de archivos grandes
mapfile -t files < <(find . -type f -size +${MIN_SIZE}c ! -path "./.git/*")

# Si hay archivos, procesarlos
if [ ${#files[@]} -gt 0 ]; then
    for file in "${files[@]}"; do
        clean_path="${file#./}"

        if grep -Fxq "$clean_path" .gitignore; then
            continue
        else
            echo "$clean_path" >> .gitignore
            size=$(du -h "$file" | cut -f1)
            added_files+=("[$size] $clean_path")
        fi
    done

    # Mostrar resumen final
    echo ""
    echo "Archivos agregados al .gitignore:"
    for entry in "${added_files[@]}"; do
        echo "$entry"
    done

else
    echo "No se encontraron archivos >= 50MB."
fi

echo "Proceso finalizado."
