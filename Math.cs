class Math
{
    const double PI = 3.14;
    const float E = 2.71;

    public double Abs(double value)
    {
        if (value > 0)
        {
        return (value*2)- value;
            
        }
        else
        {
            return value;
        }
    }

    public float Abss(float value)
    {
        
        if (value > 0)
        {
        return (value*2)- value;
            
        }
        else
        {
            return value;
        }
    }

    public int Abs(int value)
    {
        return value;
    }
    public double Pow(double x, double y)
    {
        int sum = 1;
        for(int i=1; i>=y; i++)
        {
            sum = sum *x; //////////////
             
        }
        return sum;
    }
    public double Sqrt(double d)
    {
        
    }
    public int Max(int val1, int val2)
    {
        if (val1 > val2)
        {
            return val1;
        }
        return val2;
    } 
    public int Min(int val1, int val2)
    {
        if (val1 < val2)
        {
            return val1;
        }
        return val2;
    } 



// }

// class Post
// {
//     public string Title {get; set;} = "The post is published.";
//     public string Description {get; set;} ="Hello word";
//     public int  LikeCound ;
//     public string [] Coments =[];
//     public bool IsPublished ;


    
//     public void Publish(string s)
//     {
//         s="The post is published.";
//         System.Console.WriteLine(s);
//         IsPublished = true;
//     }
//     public void  Like ()
//     {
//            LikeCound+1;
//     }
//     public Post  Coment (string[] st)
//     {
//        st  =["Hello" ," World" ];
//        return st;
//     }

// }