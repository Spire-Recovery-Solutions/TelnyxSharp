#!/bin/bash

# Fix JsonStringEnumConverter warnings by using generic version
for file in TelnyxSharp/Enums/*.cs; do
    if [ -f "$file" ]; then
        # Get the enum name from the file
        enum_name=$(grep -E "^\s*public\s+enum\s+" "$file" | sed -E 's/.*enum\s+([A-Za-z0-9_]+).*/\1/')
        
        if [ ! -z "$enum_name" ]; then
            echo "Processing $file - Enum: $enum_name"
            
            # Replace [JsonConverter(typeof(JsonStringEnumConverter))] with generic version
            sed -i '' "s/\[JsonConverter(typeof(JsonStringEnumConverter))\]/[JsonConverter(typeof(JsonStringEnumConverter<$enum_name>))]/g" "$file"
        fi
    fi
done

echo "Conversion complete!"