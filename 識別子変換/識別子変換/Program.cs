using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

class IdentifierRenamer
{
    // �ϊ��O��̎��ʎq�̃}�b�s���O���i�[���鎫��
    public Dictionary<string, string> IdentifierMap { get; private set; }

    public IdentifierRenamer()
    {
        IdentifierMap = new Dictionary<string, string>();
    }

    public string RenameIdentifiers(string code)
    {
        // �R�����g���폜
        string codeWithoutComments = Regex.Replace(code, @"//.*|/\*[\s\S]*?\*/", "");

        // �ϊ��Ώۂ��珜�O����C#�̃L�[���[�h�A�W���N���X�A�W�����\�b�h�̃��X�g
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

        // ���K�\���Ŏ��ʎq�𒊏o�i�\���⃊�e�����A�����ȊO�j
        var identifierRegex = new Regex(@"\b\w+\b");

        Dictionary<string, int> identifierCounter = new Dictionary<string, int>();

        foreach (Match match in identifierRegex.Matches(codeWithoutComments))
        {
            string originalIdentifier = match.Value;

            // �\���⏜�O�L�[���[�h�̏ꍇ�̓X�L�b�v
            if (keywords.Contains(originalIdentifier) || IdentifierMap.ContainsKey(originalIdentifier))
            {
                continue;
            }

            // �擪2�������擾�A���ʎq��2�����ȉ��Ȃ炻�̂܂�
            string newIdentifier = originalIdentifier.Length > 3 ? originalIdentifier.Substring(0, 3) : originalIdentifier;

            // �d���`�F�b�N�ƘA�ԕt��
            if (IdentifierMap.ContainsValue(newIdentifier))
            {
                if (!identifierCounter.ContainsKey(newIdentifier))
                {
                    identifierCounter[newIdentifier] = 1;
                }
                identifierCounter[newIdentifier]++;
                newIdentifier += identifierCounter[newIdentifier].ToString();
            }

            // �}�b�s���O�ɒǉ�
            IdentifierMap[originalIdentifier] = newIdentifier;
        }

        // ���̃R�[�h���Ŏ��ʎq��u��
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
                // ���̓t�@�C������R�[�h��ǂݍ���
                string code = File.ReadAllText(inputFilePath);

                // ���l�[�������̎��s
                IdentifierRenamer renamer = new IdentifierRenamer();
                string renamedCode = renamer.RenameIdentifiers(code);

                // �\�����[�V�������ɁuOutput�v�t�H���_���쐬���A�o�̓t�@�C����ۑ�
                string solutionDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string outputDirectory = Path.Combine(solutionDirectory, "Output");
                Directory.CreateDirectory(outputDirectory); // �t�H���_���Ȃ��ꍇ�͍쐬

                // ���l�[����̃R�[�h�t�@�C����ۑ�
                string renamedCodeFilePath = Path.Combine(outputDirectory, "RenamedCode.cs");
                File.WriteAllText(renamedCodeFilePath, renamedCode);

                // �ϊ��O��̎��ʎq�}�b�s���O�t�@�C����ۑ�
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
