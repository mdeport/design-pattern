using System.Runtime.CompilerServices;

class Builder
{
    private string? _table;
    private string? _tableInsert;
    private List<string> _columns = new List<string>();
    private List<string> _conditions = new List<string>();
    private List<string> _In = new List<string>();
    private List<string> _Or = new List<string>();
    private List<string> _joins = new List<string>();
    private string? _orderBy;
    private int? _top;



    public Builder Select(params string[] columns)
    {
        _columns.AddRange(columns);
        return this;
    }

    public Builder Top(int top)
    {
        _top = top;
        return this;
    }

    public Builder From(string NomTable)
    {
        _table = NomTable;
        return this;
    }

    public Builder where(params string[] condition)
    {
        _conditions.AddRange(condition);
        return this;
    }

    public Builder In (params string[] inCondition)
    {
        _In.AddRange(inCondition);
        return this;
    }

    public Builder Or (params string[] orCondition)
    {
        _Or.AddRange(orCondition);
        return this;
    }
    
    public Builder orderBy(string orderBy)
    {
        _orderBy = orderBy;
        return this;
    }

    public Builder Insert(string table, Dictionary<string, object> values)
    {
        _tableInsert = table;
        var columns = string.Join(", ", values.Keys);
        _columns.Add($"INSERT INTO {_tableInsert} ({columns}) VALUES ({string.Join(", ", values.Values)})");
        return this;
    }

    public string Build()
    {
        var query = "";

        if (string.IsNullOrEmpty(_table) && string.IsNullOrEmpty(_tableInsert))
        {
            throw new InvalidOperationException("Table name is required to build the query.");
        }

        if (_columns.Count == 0 && !_top.HasValue)
        {
            throw new InvalidOperationException("At least one column or a limit must be specified to build the query.");
        }

        if (_columns.Count > 0)
        {
            query += $"SELECT ";
        }

        if (_top.HasValue)
        {
            query += $"TOP {_top.Value} ";
        }

        if (_columns.Count > 0)
        {
            query +=  string.Join(", ", _columns) + " ";
        }else if (_top.HasValue)
        {
            query += " * ";
        }

        if (!string.IsNullOrEmpty(_table))
        {
            query += $" FROM {_table} ";
        }

        if (_joins.Count > 0)
        {
            query += string.Join(" ", _joins) + " ";
        }

        if (_conditions.Count > 0)
        {
            query += "WHERE " + string.Join(" AND ", _conditions) + " ";
        }

        if (_In.Count > 0)
        {
            if (_conditions.Count == 0)
            {
                query += "WHERE ";
            }
            else
            {
                query += " AND ";
            }
            query += "IN(" + string.Join(",", _In) + ") ";
        }

        if (_Or.Count > 0)
        {
            if (_conditions.Count == 0 && _In.Count == 0)
            {
                query += "WHERE ";
            }
            else
            {
                query += " OR ";
            }
            query += "(" + string.Join(" AND ", _Or) + ") ";
        }

        if (!string.IsNullOrEmpty(_orderBy))
        {
            query += $"ORDER BY {_orderBy} ";
        }

        if (!string.IsNullOrEmpty(_tableInsert))
        {
            query = _columns[0];
        }

        return query;
    }
}

