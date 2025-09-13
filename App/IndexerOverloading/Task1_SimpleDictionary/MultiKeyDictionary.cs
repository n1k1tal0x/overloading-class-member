// Задача: Перегрузка индексаторов — MultiKeyDictionary
// Реализуйте два индексатора: по ключу и по паре (category, key).
// При чтении отсутствующих ключей кидайте KeyNotFoundException.

namespace App.IndexerOverloading.Task1_SimpleDictionary;

public class MultiKeyDictionary
{
    Dictionary<string, int> _content;
    Dictionary<string, Dictionary<string, int>> __content; // других идей нет как сделать
    public MultiKeyDictionary()
    {
        this._content = new Dictionary<string, int> { };
        this.__content = new Dictionary<string, Dictionary<string, int>> { };
    }
    // Индексатор по одному ключу
    public int this[string key]
    {
        get
        {
            int res;
            if (!_content.TryGetValue(key, out res)) throw new KeyNotFoundException();
            return res;
        }
        set
        {
            _content[key] = value;
        }
    }

    // Индексатор по категории и ключу
    public int this[string category, string key]
    {
        get
        {
            // можно на & заменить
            if (__content.ContainsKey(category)) if (__content[category].ContainsKey(key)) return __content[category][key];
            throw new KeyNotFoundException();
        }
        set
        {
            if (!__content.ContainsKey(category))
            {
                __content[category] = new Dictionary<string, int> {};
            }
            __content[category][key] = value;
        }
    }
}