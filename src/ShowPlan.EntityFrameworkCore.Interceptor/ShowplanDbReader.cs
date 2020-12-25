using System;
using System.Collections;
using System.Data.Common;

namespace ShowPlan.EntityFrameworkCore.Interceptor
{
    internal class ShowplanDbReader : DbDataReader
    {
        private readonly DbDataReader _dbDataReaderImplementation;
        private readonly Action<string> _foundShowPlan;

        public ShowplanDbReader(DbDataReader dbDataReaderImplementation, Action<string> foundShowPlan)
        {
            _dbDataReaderImplementation = dbDataReaderImplementation;
            _foundShowPlan = foundShowPlan;
        }

        private bool CheckForPlan()
        {
            var columnName = _dbDataReaderImplementation.GetName(0);
            if (columnName != "Microsoft SQL Server 2005 XML Showplan")
            {
                return false;
            }

            _dbDataReaderImplementation.Read();
            _foundShowPlan(_dbDataReaderImplementation.GetString(0));
            return true;
        }

        public override bool NextResult()
        {
            var nextResult = _dbDataReaderImplementation.NextResult();
            if (nextResult && CheckForPlan())
            {
                // this result was the showplan so we need to jump ahead to the next one
                nextResult = _dbDataReaderImplementation.NextResult();
            }

            return nextResult;
        }

        public override void Close()
        {
            // EF doesn't call NextResult if it thinks there should be only one result set
            // Let's nudge it if we are still open on the request to see if we have a showplan waiting
            if (_dbDataReaderImplementation.IsClosed == false)
            {
                NextResult();
            }

            _dbDataReaderImplementation.Close();
        }

        #region Delegated to _dbDataReaderImplementation members

        public override bool GetBoolean(int ordinal)
        {
            return _dbDataReaderImplementation.GetBoolean(ordinal);
        }

        public override byte GetByte(int ordinal)
        {
            return _dbDataReaderImplementation.GetByte(ordinal);
        }

        public override long GetBytes(int ordinal, long dataOffset, byte[]? buffer, int bufferOffset, int length)
        {
            return _dbDataReaderImplementation.GetBytes(ordinal, dataOffset, buffer, bufferOffset, length);
        }

        public override char GetChar(int ordinal)
        {
            return _dbDataReaderImplementation.GetChar(ordinal);
        }

        public override long GetChars(int ordinal, long dataOffset, char[]? buffer, int bufferOffset, int length)
        {
            return _dbDataReaderImplementation.GetChars(ordinal, dataOffset, buffer, bufferOffset, length);
        }

        public override string GetDataTypeName(int ordinal)
        {
            return _dbDataReaderImplementation.GetDataTypeName(ordinal);
        }

        public override DateTime GetDateTime(int ordinal)
        {
            return _dbDataReaderImplementation.GetDateTime(ordinal);
        }

        public override decimal GetDecimal(int ordinal)
        {
            return _dbDataReaderImplementation.GetDecimal(ordinal);
        }

        public override double GetDouble(int ordinal)
        {
            return _dbDataReaderImplementation.GetDouble(ordinal);
        }

        public override Type GetFieldType(int ordinal)
        {
            return _dbDataReaderImplementation.GetFieldType(ordinal);
        }

        public override float GetFloat(int ordinal)
        {
            return _dbDataReaderImplementation.GetFloat(ordinal);
        }

        public override Guid GetGuid(int ordinal)
        {
            return _dbDataReaderImplementation.GetGuid(ordinal);
        }

        public override short GetInt16(int ordinal)
        {
            return _dbDataReaderImplementation.GetInt16(ordinal);
        }

        public override int GetInt32(int ordinal)
        {
            return _dbDataReaderImplementation.GetInt32(ordinal);
        }

        public override long GetInt64(int ordinal)
        {
            return _dbDataReaderImplementation.GetInt64(ordinal);
        }

        public override string GetName(int ordinal)
        {
            return _dbDataReaderImplementation.GetName(ordinal);
        }

        public override int GetOrdinal(string name)
        {
            return _dbDataReaderImplementation.GetOrdinal(name);
        }

        public override string GetString(int ordinal)
        {
            return _dbDataReaderImplementation.GetString(ordinal);
        }

        public override object GetValue(int ordinal)
        {
            return _dbDataReaderImplementation.GetValue(ordinal);
        }

        public override int GetValues(object[] values)
        {
            return _dbDataReaderImplementation.GetValues(values);
        }

        public override bool IsDBNull(int ordinal)
        {
            return _dbDataReaderImplementation.IsDBNull(ordinal);
        }

        public override int FieldCount => _dbDataReaderImplementation.FieldCount;

        public override object this[int ordinal] => _dbDataReaderImplementation[ordinal];

        public override object this[string name] => _dbDataReaderImplementation[name];

        public override int RecordsAffected => _dbDataReaderImplementation.RecordsAffected;

        public override bool HasRows => _dbDataReaderImplementation.HasRows;

        public override bool IsClosed => _dbDataReaderImplementation.IsClosed;

        public override bool Read()
        {
            return _dbDataReaderImplementation.Read();
        }

        public override int Depth => _dbDataReaderImplementation.Depth;

        public override IEnumerator GetEnumerator()
        {
            return _dbDataReaderImplementation.GetEnumerator();
        }

        #endregion
    }
}
