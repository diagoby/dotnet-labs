using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab2
{
    class MatrixFileDataAdapter : IDataAdapter
    {
        private const string MATRIX_LINES_SEPARATOR = "\r\n";
        private const string MATRIX_LINE_SEPARATOR = ", ";

        private const string MATRIX_LINES_SEPARATOR_PATTERN = "\r\n";
        private const string MATRIX_LINE_SEPARATOR_PATTERN = "[^\\d-]+";

        public string FilePath { get; set; }

        public MatrixFileDataAdapter(string filePath)
        {
            FilePath = filePath;
        }

        public MissingMappingAction MissingMappingAction { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public MissingSchemaAction MissingSchemaAction { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public ITableMappingCollection TableMappings => throw new NotImplementedException();

        public int Fill(DataSet dataSet)
        {
            DataTable matrixTable = new DataTable();
            int[][] matrix = ReadMatrixFromFile();

            if (!IsMatrixValid(matrix))
            {
                throw new Exception(
                    "It should be a valid square matrix of integers"
                );
            }

            foreach (var _col in matrix)
            {
                matrixTable.Columns.Add();
            }

            foreach (var row in matrix)
            {
                string[] stringRow = row.Select(num => num.ToString()).ToArray();
                matrixTable.Rows.Add(stringRow);
            }

            dataSet.Tables.Add(matrixTable);

            return matrix.Length;
        }
        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            DataTable table = dataSet.Tables[0];

            int [][] matrix = table.AsEnumerable()
                .Select(row => row.ItemArray
                    .Where(item => item != DBNull.Value)
                    .Select(item => int.Parse((string) item))
                    .ToArray())
                .ToArray();

            if(!IsMatrixValid(matrix))
            {
                throw new Exception(
                    "All cells should be filled with integers"
                );
            }

            WriteMatrixToFile(matrix);

            return matrix.Length;
        }

        public int[][] ReadMatrixFromFile()
        {
            using StreamReader reader = new StreamReader(FilePath);
            return StringToMatrix(reader.ReadToEnd());
        }

        public void WriteMatrixToFile(int [][] matrix)
        {
            using StreamWriter writer = new StreamWriter(FilePath);
            writer.Write(MatrixToString(matrix));
        }

        private int[][] StringToMatrix(string matrix) => Regex
            .Split(matrix, MATRIX_LINES_SEPARATOR_PATTERN)
            .Select(StringToArray)
            .ToArray();

        private string MatrixToString(int[][] matrix) => string
            .Join(MATRIX_LINES_SEPARATOR, matrix.Select(ArrayToString));

        private string ArrayToString(int[] arr) => string.Join(MATRIX_LINE_SEPARATOR, arr);

        private int[] StringToArray(string arr) => Regex
            .Split(arr, MATRIX_LINE_SEPARATOR_PATTERN)
            .Where(token => !string.IsNullOrWhiteSpace(token))
            .Where(token => int.TryParse(token, out int _))
            .Select(int.Parse)
            .ToArray();

        private bool IsMatrixValid(int[][] matrix) => !matrix
            .Any(row => row.Length != matrix.Length);
    }
}
