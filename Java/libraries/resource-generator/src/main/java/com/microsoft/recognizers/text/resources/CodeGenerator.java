// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

package com.microsoft.recognizers.text.resources;

import com.microsoft.recognizers.text.resources.datatypes.*;
import com.microsoft.recognizers.text.resources.writters.*;
import org.yaml.snakeyaml.TypeDescription;
import org.yaml.snakeyaml.Yaml;
import org.yaml.snakeyaml.constructor.Constructor;

import java.io.*;
import java.nio.charset.StandardCharsets;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.Map;

public class CodeGenerator {

    private static final String lineBreak = "\n";

    private static final String headerComment = String.join(
            lineBreak,
            "// ------------------------------------------------------------------------------",
            "// <auto-generated>",
            "//     This code was generated by a tool.",
            "//     Changes to this file may cause incorrect behavior and will be lost if",
            "//     the code is regenerated.",
            "// </auto-generated>",
            "//",
            "// Copyright (c) Microsoft Corporation. All rights reserved.",
            "// Licensed under the MIT License.",
            "// ------------------------------------------------------------------------------");

    public static void Generate(Path yamlFilePath, Path outputFilePath, String header, String footer) throws IOException {

        // Config YAML parser
        Constructor constructor = new Constructor();
        constructor.addTypeDescription(new TypeDescription(ParamsRegex.class, "!paramsRegex"));
        constructor.addTypeDescription(new TypeDescription(SimpleRegex.class, "!simpleRegex"));
        constructor.addTypeDescription(new TypeDescription(NestedRegex.class, "!nestedRegex"));
        constructor.addTypeDescription(new TypeDescription(Character.class, "!char"));
        constructor.addTypeDescription(new TypeDescription(Boolean.class, "!bool"));
        constructor.addTypeDescription(new TypeDescription(Dictionary.class, "!dictionary"));
        constructor.addTypeDescription(new TypeDescription(List.class, "!list"));

        // Read and Parse YAML
        Yaml yaml = new Yaml(constructor);
        Map<String, Object> raw = yaml.load(new InputStreamReader(new FileInputStream(yamlFilePath.toString()), StandardCharsets.UTF_8));

        // Transform
        String[] lines = GenerateCodeLines(raw);

        // Write to file
        BufferedWriter writer = null;
        try {
            writer = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(outputFilePath.toString()), StandardCharsets.UTF_8));
            writer.write(headerComment);
            writer.write(lineBreak);
            writer.write(lineBreak);
            writer.write(header);
            writer.write(lineBreak);

            BufferedWriter finalWriter = writer;
            for (String l : lines) {
                writer.write(lineBreak);
                finalWriter.write(l);
                writer.write(lineBreak);
            }

            writer.write(footer);
            writer.write(lineBreak);
        } catch (Exception e) {
            throw e;
        } finally {
            try {
                writer.close();
            } catch (Exception e) {
                throw e;
            }
        }
    }

    private static String[] GenerateCodeLines(Map<String, Object> raw) {
        return raw.entrySet().stream().map(kv -> {
            String tokenName = kv.getKey();
            Object token = kv.getValue();
            return getWriter(tokenName, token).write();
        }).toArray(size -> new String[size]);
    }

    private static ICodeWriter getWriter(String tokenName, Object token) throws IllegalArgumentException {
        if (token instanceof ParamsRegex) {
            return new ParamsRegexWriter(tokenName, (ParamsRegex)token);
        }

        if (token instanceof SimpleRegex) {
            return new SimpleRegexWriter(tokenName, (SimpleRegex)token);
        }

        if (token instanceof NestedRegex) {
            return new NestedRegexWriter(tokenName, (NestedRegex)token);
        }

        if (token instanceof Character) {
            return new CharacterWriter(tokenName, (char)token);
        }

        if (token instanceof Boolean) {
            return new BooleanWriter(tokenName, (boolean)token);
        }

        if (token instanceof String) {
            return new DefaultWriter(tokenName, (String)token);
        }

        if (token instanceof Integer) {
            return new IntegerWriter(tokenName, (int)token);
        }

        if (token instanceof ArrayList) {
            return new ListWriter(tokenName, "String", (String[])((ArrayList) token).stream().map(o -> o.toString()).toArray(size -> new String[size]));
        }

        if (token instanceof List) {
            return new ListWriter(tokenName, ((List)token).types[0], ((List)token).entries);
        }

        if (token instanceof Dictionary) {
            return new DictionaryWriter(tokenName, (Dictionary)token);
        }

        throw new IllegalArgumentException(String.format("Data Type not supported for %s: %s", tokenName, token));
    }
}
