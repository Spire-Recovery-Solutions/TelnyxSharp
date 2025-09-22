#!/bin/bash

# Fix JsonStringEnumConverter warnings by using generic version
for file in TelnyxSharp/Enums/*.cs; do
    if [ -f "$file" ]; then
        # Get just the enum name
        enum_name=$(grep -E "^\s*public\s+enum\s+" "$file" | sed -E 's/.*public\s+enum\s+([A-Za-z0-9_]+).*/\1/' | head -1)
        
        if [ ! -z "$enum_name" ]; then
            echo "Processing $file - Enum: $enum_name"
            
            # Replace [JsonConverter(typeof(JsonStringEnumConverter))] with generic version
            # Also handle the case where it was already partially updated
            sed -i '' "s/\[JsonConverter(typeof(JsonStringEnumConverter))\]/[JsonConverter(typeof(JsonStringEnumConverter<${enum_name}>))]/g" "$file"
            
            # Fix any malformed ones from previous attempt
            sed -i '' "s/\[JsonConverter(typeof(JsonStringEnumConverter<.*public enum ${enum_name}>))\]/[JsonConverter(typeof(JsonStringEnumConverter<${enum_name}>))]/g" "$file"
        fi
    fi
done

echo "Conversion complete!"