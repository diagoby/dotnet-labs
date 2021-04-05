using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab2
{
    class MatrixFileDataAdapter : IDataAdapter
    {
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
            int[][] matrix = StringToMatrix(ReadMatrixString());

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
            throw new NotImplementedException();
        }

        public string ReadMatrixString()
        {
            using StreamReader reader = new StreamReader(FilePath);
            return reader.ReadToEnd();
        }

        private int[][] StringToMatrix(string matrix) => Regex
            .Split(matrix, MATRIX_LINES_SEPARATOR_PATTERN)
            .Select(NumbersStringToArray)
            .ToArray();

        private int[] NumbersStringToArray(string arr) => Regex
            .Split(arr, MATRIX_LINE_SEPARATOR_PATTERN)
            .Where(token => !string.IsNullOrWhiteSpace(token))
            .Where(token => int.TryParse(token, out int _))
            .Select(int.Parse)
            .ToArray();

        private bool IsMatrixValid(int[][] matrix) => !matrix
            .Any(row => row.Length != matrix.Length);
    }
}
