using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

class IdentifierRenamer
{
    // 変換前後の識別子のマッピングを格納する辞書
    public Dictionary<string, string> IdentifierMap { get; private set; }

    public IdentifierRenamer()
    {
        IdentifierMap = new Dictionary<string, string>();
    }

    public string RenameIdentifiers(string code)
    {
        // コメントを削除
        string codeWithoutComments = Regex.Replace(code, @"//.*|/\*[\s\S]*?\*/", "");

        // 変換対象から除外するC#のキーワード、標準クラス、標準メソッドのリスト
        HashSet<string> keywords = new HashSet<string>
        {
        "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class",
        "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event",
        "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if",
        "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null",
        "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly",
        "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct",
        "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
        "using", "virtual", "void", "volatile", "while",
        "System", "Console", "WriteLine", "ReadLine", "Array", "DateTime", "List", "Dictionary", "HashSet",
        "Queue", "Stack", "LinkedList", "SortedList", "SortedDictionary", "Math", "Random", "File", "Stream",
        "Dispose", "Add", "Remove", "Count", "Clear", "Contains", "Equals", "ToString", "GetHashCode",
        "GetType", "Parse", "TryParse", "Substring", "IndexOf", "Length", "Trim", "ToUpper", "ToLower",
        "ContainsKey", "ContainsValue", "Keys", "Values", "GetEnumerator", "DataTable", "DataRow",
        "DataGridView", "Rows", "Columns", "AcceptChanges", "RejectChanges", "BeginEdit", "EndEdit",
        "Commit", "Value", "Close", "Dispose", "sender", "EventArgs", "Exception", "dialog",
        "Collections", "Generic"
        };

        // 正規表現で識別子を抽出（予約語やリテラル、数字以外）
        var identifierRegex = new Regex(@"\b\w+\b");

        Dictionary<string, int> identifierCounter = new Dictionary<string, int>();

        foreach (Match match in identifierRegex.Matches(codeWithoutComments))
        {
            string originalIdentifier = match.Value;

            // 予約語や除外キーワードの場合はスキップ
            if (keywords.Contains(originalIdentifier) || IdentifierMap.ContainsKey(originalIdentifier))
            {
                continue;
            }

            // 先頭2文字を取得、識別子が2文字以下ならそのまま
            string newIdentifier = originalIdentifier.Length > 3 ? originalIdentifier.Substring(0, 3) : originalIdentifier;

            // 重複チェックと連番付加
            if (IdentifierMap.ContainsValue(newIdentifier))
            {
                if (!identifierCounter.ContainsKey(newIdentifier))
                {
                    identifierCounter[newIdentifier] = 1;
                }
                identifierCounter[newIdentifier]++;
                newIdentifier += identifierCounter[newIdentifier].ToString();
            }

            // マッピングに追加
            IdentifierMap[originalIdentifier] = newIdentifier;
        }

        // 元のコード内で識別子を置換
        string renamedCode = codeWithoutComments;
        foreach (var kvp in IdentifierMap)
        {
            renamedCode = Regex.Replace(renamedCode, $@"\b{kvp.Key}\b", kvp.Value);
        }

        return renamedCode;
    }

    public void SaveIdentifierMap(string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Original Identifier,Renamed Identifier");
            foreach (var kvp in IdentifierMap)
            {
                writer.WriteLine($"{kvp.Key},{kvp.Value}");
            }
        }
    }
}

class Program
{
    [STAThread]
    static void Main()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
        openFileDialog.Title = "Select a C# File to Rename Identifiers";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string inputFilePath = openFileDialog.FileName;

            try
            {
                // 入力ファイルからコードを読み込む
                string code = File.ReadAllText(inputFilePath);

                // リネーム処理の実行
                IdentifierRenamer renamer = new IdentifierRenamer();
                string renamedCode = renamer.RenameIdentifiers(code);

                // ソリューション内に「Output」フォルダを作成し、出力ファイルを保存
                string solutionDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string outputDirectory = Path.Combine(solutionDirectory, "Output");
                Directory.CreateDirectory(outputDirectory); // フォルダがない場合は作成

                // リネーム後のコードファイルを保存
                string renamedCodeFilePath = Path.Combine(outputDirectory, "RenamedCode.cs");
                File.WriteAllText(renamedCodeFilePath, renamedCode);

                // 変換前後の識別子マッピングファイルを保存
                string identifierMapFilePath = Path.Combine(outputDirectory, "IdentifiersMapping.csv");
                renamer.SaveIdentifierMap(identifierMapFilePath);

                Console.WriteLine($"Code has been renamed and saved to: {renamedCodeFilePath}");
                Console.WriteLine($"Identifiers mapping saved to: {identifierMapFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("No file was selected.");
        }
    }
}
