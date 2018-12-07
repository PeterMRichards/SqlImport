using System.Data;
using SqlImport.DataReader.Configuration;

namespace SqlImport.DataReader
{
    public interface IDataReaderFactory
    {
        IDataReader GetCsvDataReader(CsvDataReaderConfiguration configuration);
    }
}
