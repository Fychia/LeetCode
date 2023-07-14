namespace _1108;

public class Solution
{
    public string DefangIPaddr(string address)
    {
        var qualquerNome = address.ToCharArray();
        for (int i = 0; i < qualquerNome.Length; i++)
        {
            if (qualquerNome[i] == '.')
            {
                qualquerNome[i] = (char)('[' + '.' + ']');
            }
        }
        return qualquerNome.ToString();
    }

}