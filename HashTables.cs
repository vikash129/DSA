   int hashKey = hashFunction(key);

    cout << "remove at ";
    cout << hashKey << endl;

    auto &cell = table[hashKey];
    auto bItr = begin(cell);

    bool keyExists = false;

    while (bItr != end(cell))
    {
        if (bItr->first == key)
        {
            keyExists = true;
            bItr = cell.erase(bItr);
            cout << "[Success] Item Removed \n";
            break;
        }
        bItr++;
    }

    if (!keyExists)
    {
        cout << "[warning] key does not exist!!!!! \n";
    }
};

void HashTable ::printTable()
{
    for (int i{}; i < hashGroups; i++)
    {

        if (table[i].size() == 0)
            continue;

        auto bItr = table[i].begin();

        while (bItr != table[i].end())
        {
            cout << "[Info] key : " << bItr->first << " , value : " << bItr->second << endl;
            bItr++;
        }
    }
};

string HashTable ::search(int key){
    int hashKey = hashFunction(key);

    cout << "search\n";
    cout << hashKey << endl;

    auto &cell = table[hashKey];
    auto bItr = begin(cell);

    bool keyExists = false;

    while (bItr != end(cell))
    {
        if (bItr->first == key)
        {
            keyExists = true;
            cout << "[Success] Item find \n" ;
            return  bItr->second ;
        }
        bItr++;
    }

    if (!keyExists)
    {
        cout << "[warning] key does not exist!!!!! \n";
    }
