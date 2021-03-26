using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2
{
    class MatrixFileDataAdapter : IDataAdapter
    {
        private const string MATRIX_LINES_SEPARATOR_PATTERN = "\r\n";
        private const string MATRIX_LINE_SEPARATOR_PATTERN = "[^\\d-]+";

        private const string FILE_NAME = "matrix.txt";

        public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITableMappingCollection TableMappings => throw new NotImplementedException();

        public int Fill(DataSet dataSet)
        {
            DataTable matrixTable = new DataTable();
            int[][] matrix = StringToMatrix(ReadMatrixString());

            foreach (var row in matrix)
            {
                matrixTable.Rows.Add(row);
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

        public async Task WriteFileAsync()
        {
            string path = Path.Combine(Environment.CurrentDirectory, FILE_NAME);

            using StreamWriter writer = new StreamWriter(path);

            await writer.WriteLineAsync("Hello, Alex");
        }

        public async Task<string> ReadFileAsync()
        {
            string path = Path.Combine(Environment.CurrentDirectory, FILE_NAME);
            using StreamReader reader = new StreamReader(path);
            return await reader.ReadToEndAsync();
        }

        public string ReadMatrixString()
        {
            string path = Path.Combine(Environment.CurrentDirectory, FILE_NAME);
            using StreamReader reader = new StreamReader(path);
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
    }
}
